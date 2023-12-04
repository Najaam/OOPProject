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

namespace OOPProject
{

    public partial class otp : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

        
    
        class Validate : User
        {
            
            protected int OTP;

            public Validate()
            {
            }
            public Validate(int o)
            {
                OTP = o;
            }

            public string getData(string role)
            {
                return $"SELECT * FROM {role.ToLower()} WHERE email = '{Email}'";
            }
        }

        class fetchdata : Validate
        {
            private SqlConnection Connection;

            // Corrected the constructor
            public fetchdata(SqlConnection connection, int o) : base(o)
            {
                Connection = connection;
            }

            public bool isverified = false;



            public void assigndata(Validate val, string role)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(val.getData(role), Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string userEmail = row["email"].ToString();
                    int userOTP = Convert.ToInt32(row["v_otp"]);

                    if (Email.Equals(userEmail) && OTP == userOTP)
                {
                        Home h = new Home();
                        h.Show();
                        isverified = true;  
                    }
                    else
                    {
                        MessageBox.Show("Wrong OTP Code", "Warning");
                    }
                }

            }



        }

        public otp()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            int otp = int.Parse(txtotp.Text);
            string role = rolebox.Text;
            Validate val = new Validate();
            fetchdata fetch = new fetchdata(conn, otp);
            fetch.assigndata(val, role);
            if (fetch.isverified)
            {
                Visible = false;
            }
        }
    }
}