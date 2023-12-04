using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace OOPProject
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

        public class User
        {
            protected static string Name;
            protected static string Username;
            protected static string Email;
            protected static string Password;
            protected static int Otp;
       
            public void getdata(string name, string username, string email, string password, int otp)
            {
                Name = name;
                Username = username;
                Email = email;
                Password = password;
                Otp = otp;
            }
            public User() { }
            public string saveData(string role)
            {
                return $"INSERT INTO {role.ToLower()} VALUES ('{Name}', '{Username}', '{Email}', '{Password}', '{Otp}')";
            }
        }

        class UserRegistrationManager
        {
            public bool otpsent = false;
            private SqlConnection Connection;

            public UserRegistrationManager(SqlConnection connection)
            {
                Connection = connection;
            }

            public int GenerateOTP()
            {
                Random rand = new Random();
                return rand.Next(1000, 9999);
            }

            public void RegisterUser(User user, string role)
            {
                SqlCommand cmd = new SqlCommand(user.saveData(role), Connection);

                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("This Email already linked with another account", "Error");
                        otpsent = false;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
                Connection.Close();
            }


            public void SendOtpByEmail(string toEmail, int otp)
            {

                string smtpServer = "smtp.gmail.com";
                string smtpUsername = "najamurrehman912@gmail.com";
                string smtpPassword = "sygg uauu kiec rehf";
                int smtpPort = 587;

                SmtpClient smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("najamurrehman912@gmail.com", "Ecom"),
                    Subject = "OTP Verification",
                    Body = $"Your OTP is: {otp}",
                    IsBodyHtml = false,
                };

                try
                {
                    mailMessage.To.Add(toEmail);
                    
                    otpsent = true;
                }
                catch (FormatException ex)
                {

                    MessageBox.Show($"Invalid email format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    ////  MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Error");
                }
            }
            

        }


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Fill in all the required fields", "Message");

            }
            else
            {
                UserRegistrationManager registrationManager = new UserRegistrationManager(conn);
                string name = txtname.Text;
                string username = txtusername.Text;
                string email = txtemail.Text;
                string password = txtpassword.Text;
                int otp = registrationManager.GenerateOTP();


                string role = Rolebox.Text;


                //User newUser = new User(name, username, email, password, otp);
                User newUser = new User();
                newUser.getdata(name, username, email, password, otp);
                registrationManager.SendOtpByEmail(email, otp);

                if (registrationManager.otpsent)
                {
                    registrationManager.RegisterUser(newUser, role);
                    otp f2 = new otp();
                    f2.Show();
                    Visible = false;
                }
                else
                {
                    Visible = true;
                }
            }
          
            }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            Visible=false;
        }
    }
    }
