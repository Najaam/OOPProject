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


namespace OOPProject
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

        class User
        {
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int Otp { get; set; }

            public User(string name, string username, string email, string password, int otp)
            {
                Name = name;
                Username = username;
                Email = email;
                Password = password;
                Otp = otp;
            }

            public string saveData(string role)
            {
                return $"INSERT INTO {role.ToLower()} VALUES ('{Name}', '{Username}', '{Email}', '{Password}', '{Otp}')";
            }
        }

        class UserRegistrationManager
        {
            private SqlConnection Connection { get; }

            public UserRegistrationManager(SqlConnection connection)
            {
                Connection = connection;
            }

            public void RegisterUser(User user, string role)
            {
                SqlCommand cmd = new SqlCommand(user.saveData(role), Connection);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"You are successfully registered as {role}. Please login to your account.", "Message");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Username is already taken. Please choose a different username.", "Error");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
                Connection.Close();
            }

            public int GenerateOTP()
            {
                Random rand = new Random();
                return rand.Next(1000, 9999);
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

                mailMessage.To.Add(toEmail);

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Error");
                }
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistrationManager registrationManager = new UserRegistrationManager(conn);
            string name = txtname.Text;
            string username = txtusername.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            int otp = registrationManager.GenerateOTP();

            string role = Rolebox.Text.ToLower();

            User newUser = new User(name, username, email, password,otp);

            registrationManager.RegisterUser(newUser, role);
            registrationManager.SendOtpByEmail(email, otp);
           
        }
    }
}
