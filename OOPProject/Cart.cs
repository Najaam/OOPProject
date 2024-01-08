using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPProject.Login;

namespace OOPProject
{
    public partial class Cart : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");

        class CheckAddress : Datauser
        {
            public bool isAvailable = false;

            public CheckAddress(SqlConnection connect)
            {
                string query = $"SELECT * FROM userdata WHERE email = '{useremail}'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isAvailable = true;
                }
                else
                {
                    MessageBox.Show("Bill Address not set yet");
                }
            }
        }

        class cartview :Datauser
        {
            public cartview(SqlConnection connect, DataGridView dView)
            {
                string qurey = $"SELECT pname, pprice, pquant FROM cart WHERE email = '{useremail}'";

                SqlDataAdapter adapter = new SqlDataAdapter(qurey, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt == null)
                {
                    MessageBox.Show("Data is Empty");
                }
                else
                {
                    dView.DataSource = dt;

                }
            }

        }

        class History : Datauser
        {
            string email;
            string Productname;
            int Productprice;
            int quantity;
            int totalprice;

            public History(string pn, int quant, int pp, int tp)
            {
                email = useremail;
                Productname = pn;
                Productprice = pp;
                quantity = quant;
                totalprice = tp;
            }

            public void addData(SqlConnection connection)
            {
                string qurey = $"INSERT INTO history (email, pname, tprice, pquant, purchase_date) " +
                               $"VALUES ('{email}', '{Productname}', {Productprice}, {quantity}, GETDATE())";  // Assuming GETDATE() is used to get the current date and time

                SqlCommand cmd = new SqlCommand(qurey, connection);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Orders Placed Sucessfully", "Alert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                    connection.Close();
            }
            public void DeleteFromCart(SqlConnection connection, string productName)
            {
                string deleteQuery = $"DELETE FROM cart WHERE email = '{useremail}' AND pname = '{productName}'";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception");
                    }
                }
                connection.Close();
            }

        }
        public Cart()
        {
            InitializeComponent();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            CheckAddress check = new CheckAddress(conn);
            if (check.isAvailable == true)
            {
            int Productquantity = int.Parse(quantity.Text);
            string Productname = pname.Text;
            int Productprice = int.Parse(price.Text);
            int Totalprice = int.Parse(totalprice.Text);
            if (string.IsNullOrEmpty(Productname) || Productprice == null || Productprice == null)
            {
                MessageBox.Show("Fill all given feilds", "Warning");
            }
            else
            {
                History add = new History(Productname, Productquantity, Productprice,Totalprice);
                add.addData(conn);
                add.DeleteFromCart(conn, Productname);
                RefreshCartView();
            }
            }
            else
            {
                MessageBox.Show("Bill Address not set yet");
            }
            pname.Clear();
            price.Clear();
            quantity.Clear();
            totalprice.Clear();        
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            cartview c = new cartview(conn, datagrid);
        }
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
private void selectdata(object sender, DataGridViewCellEventArgs e)
        {
            int count = datagrid.CurrentRow.Index;
            pname.Text = datagrid.Rows[count].Cells[0].Value.ToString();
            price.Text = datagrid.Rows[count].Cells[1].Value.ToString();
            quantity.Text = datagrid.Rows[count].Cells[2].Value.ToString();
            int priceval = int.Parse(price.Text);
            int quantval = int.Parse(quantity.Text);
            int totalval = priceval * quantval;
            totalprice.Text = totalval.ToString();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Visible = false;
        }
        private void RefreshCartView()
        {
            cartview c = new cartview(conn, datagrid);
        }
    }

}

