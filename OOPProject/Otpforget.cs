using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPProject.Form1;
using static OOPProject.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOPProject
{
    public partial class Otpforget : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");



        public class Validate : Datauser
        {

            protected int OTP;

            public Validate()
            {
            }
            public Validate(int o)
            {
                OTP = o;
            }

            public string update(string role, string newpass)
            {
                return $"UPDATE {role.ToLower()} SET pass = '{newpass}' WHERE email = '{useremail}'";
            }
            
        }

        class fetchdata : Validate
        {
            private SqlConnection Connection;

            
            public fetchdata(SqlConnection connection, int o) : base(o)
            {
                Connection = connection;
            }

            public bool isverified = false;



            public void assigndata(string pass, string role)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(getData(role), Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string userEmail = row["email"].ToString();
                    int userOTP = Convert.ToInt32(row["v_otp"]);

                    if (userEmail.Equals(useremail) && OTP == userOTP)
                    {
                        isverified = true;
                        SqlCommand cmd = new SqlCommand(update(role, pass), Connection);
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
                    else
                    {
                        MessageBox.Show("Wrong OTP Code", "Warning");
                    }
                }
            }
        }
        public Otpforget()
        {
            InitializeComponent();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
                string role = rolebox.Text;
            if (string.IsNullOrEmpty(txtotp.Text) || role != "Buyer" && role != "Seller")
            {
                MessageBox.Show("Fill all the required fields", "Warning");
            }
            else
            {
                string pass = txtpass.Text;
                int otp = int.Parse(txtotp.Text);
            //Validate val = new Validate();
            fetchdata fetch = new fetchdata(conn, otp);
            fetch.assigndata(pass,role);
            if (fetch.isverified)
            {

               Home h = new Home();
                h.Show();
                Visible = false;
            }
            else
            {
                Visible = true;
            }
                 }
        }

    private void Backbtn_Click(object sender, EventArgs e)
        {
                Login f1 = new Login();
                f1.Show();
                Visible = false;
            }
    }
}
