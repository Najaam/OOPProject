using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPProject.Form1;
using static System.Net.WebRequestMethods;

namespace OOPProject
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

      public class Datauser     {
            protected static string useremail;
            protected string userpassword;

            public Datauser(string email)
            {
                useremail = email;
            }

            
                public Datauser() { }
            public Datauser(string e,string p) {
            useremail = e;
            userpassword = p;   
            }

            public string updateData(string role,  int newotp)
            {
                return $"UPDATE {role.ToLower()} SET v_otp = '{newotp}' WHERE email = '{useremail}'";
            }

            public string getData(string role)
            {
                return $"SELECT * FROM {role.ToLower()} WHERE email = '{useremail}'";
            }
        }


        class ForgotOTP
            {


            public bool otpsent = false;
            private SqlConnection Connection;

            public ForgotOTP(SqlConnection connection)
            {
                Connection = connection;
            }

            public int GenerateOTP()
            {
                Random rand = new Random();
                return rand.Next(1000, 9999);
            }

          public void updateotp(Datauser d, string role,int newotp)
            {
                SqlCommand cmd = new SqlCommand(d.updateData(role,newotp), Connection);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                { 
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                   
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

        class fetchdata : Datauser
        {
            private SqlConnection Connection;

            public fetchdata(SqlConnection connection, string e, string p):base(e,p)
            {
                Connection = connection;
            }

            public bool isverified = false;
            public void assigndata( string role)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(getData(role), Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string userEmail = row["email"].ToString();
                    string userPass = row["pass"].ToString();

                    if (useremail.Equals(userEmail)&& userpassword.Equals(userPass))
                    {
                        Home h = new Home();
                        h.Show();
                        isverified = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credentials", "Warning");
                    }

                }
            }
        }
                public Login()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtmail.Text;
            string pass = txtpass.Text;
            string role = Rolebox.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || role !="Buyer" && role != "Seller")
            {
                MessageBox.Show("Fill All the Remaining feilds","Warning");
            }
            else
            {
                

            fetchdata fetch = new fetchdata(conn,email,pass);
            fetch.assigndata( role);
            if (fetch.isverified)
            {
                Visible = false;
                }
                else
                {
                    MessageBox.Show("Wrong Credentials", "Warning");
                }


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string email = txtmail.Text;
            string role = Rolebox.Text;
         
                if (string.IsNullOrEmpty(email)|| role != "Buyer" && role != "Seller")
                {
                    MessageBox.Show("Enter Your email Address and select your role too", "Warning");
                }
                else
                {
                    Datauser data = new Datauser(email);
                    ForgotOTP fotp = new ForgotOTP(conn);
                    int otp = fotp.GenerateOTP();
                    fotp.SendOtpByEmail(email, otp);

                    if (fotp.otpsent)
                    {
                        Otpforget f2 = new Otpforget();
                        f2.Show();
                        Visible = false;
                        fotp.updateotp(data, role, otp);
                    }
                    else
                    {
                        Visible = true;
                        MessageBox.Show("Somthing Wrong", "warning");
                    }
                

            }
        }
    }
}
