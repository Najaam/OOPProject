using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static OOPProject.Login;

namespace OOPProject
{
    public partial class Address : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

        class UpdateData : Datauser
        {
            string email;
            string State;
            int Postalcode;
            string City;
            string Address;

            public UpdateData(string st, int pc, string c, string add)
            {
                email = useremail;
                State = st;
                Postalcode = pc;
                City = c;
                Address = add;
            }

            public void UpdateUserData(SqlConnection connection)
            {
                string query = $"UPDATE userdata SET states = '{State}', pcode = '{Postalcode}', city = '{City}', Adress = '{Address}' WHERE email = '{email}'";

                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing Address Updated Successfully", "Alert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }

            }
        }
        class HaveData : Datauser
        {
            public bool DataExists;

            public HaveData(SqlConnection connect, ComboBox statebox, TextBox pcodetxt, TextBox city, TextBox add)
            {
                string query = $"SELECT * FROM userdata WHERE email = '{useremail}'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    statebox.Text = dt.Rows[0]["states"].ToString();
                    pcodetxt.Text = dt.Rows[0]["pcode"].ToString();
                    city.Text = dt.Rows[0]["city"].ToString();
                    add.Text = dt.Rows[0]["Adress"].ToString();

                    DataExists = true;
                }
                else
                {
                    DataExists = false;
                }
            }
        }

        class Adddata : Datauser
        {
            string email;
            string State;
            int Postalcode;
            string City;
            string Address;
            public Adddata(string st, int pc, string c, string add)
            {
                email = useremail;
                State = st;
                Postalcode = pc;
                City = c;
                Address = add;
            }
            public void addData(SqlConnection connection)
            {
                string qurey = $"INSERT INTO userdata VALUES ('{email}','{Postalcode}', '{State}', '{City}', '{Address}')";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Billing Address Added SuccessFully", "Alert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                connection.Close();
            }
        }

        public Address()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Visible = false;
        }

        private void savedata_Click(object sender, EventArgs e)
        {

            string State = statebox.Text;
            int Postalcode = int.Parse(pcodetxt.Text);
            string City = city.Text;
            string address = add.Text;

            if (string.IsNullOrEmpty(State) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(address) || Postalcode == 0)
            {
                MessageBox.Show("Fill all given fields", "Warning");
            }
            else
            {
                Adddata add = new Adddata(State, Postalcode, City, address);
                add.addData(conn);
            }
        }

        private void Address_Load(object sender, EventArgs e)
        {
            HaveData haveData = new HaveData(conn, statebox, pcodetxt, city, add);
            savedata.Enabled = !haveData.DataExists;
            update.Enabled = haveData.DataExists;
        }

        private void update_Click(object sender, EventArgs e)
        {
            string State = statebox.Text;
            int Postalcode = int.Parse(pcodetxt.Text);
            string City = city.Text;
            string address = add.Text;
            if (string.IsNullOrEmpty(State) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(address) || Postalcode == null) {
                MessageBox.Show("Fill all input feild","Alert");
            }
            else
            {
            UpdateData update = new UpdateData(State, Postalcode, City, address);
            update.UpdateUserData(conn);
            }
            
        }
    }
}
