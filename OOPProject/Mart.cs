using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPProject.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace OOPProject
{
    public partial class Mart : Form
    {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");
        class martview 
        {

            public martview(SqlConnection connect, DataGridView dView)
            {
                string qurey = $"Select pname,pprice from Product ";
                SqlDataAdapter adapter = new SqlDataAdapter(qurey, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt == null)
                {

                }
                else
                {
                    dView.DataSource = dt;

                }
            }
        }


        class Addtocart: Datauser
        {
            string email;
            string Productname;
            int Productprice;
            int quantity;
            public Addtocart( string pn, int quant, int pp)
            {
                email = useremail;
                Productname = pn;
                Productprice = pp;
                quantity = quant;

            }
            public void addData(SqlConnection connection)
            {
                string qurey = $"INSERT INTO cart VALUES ('{email}','{Productname}', '{Productprice}','{quantity}')";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated SuccessFully", "Alert");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                connection.Close();
            }
        }

        public Mart()
        {
            InitializeComponent();
        }

        private void Mart_Load(object sender, EventArgs e)
        {
            martview v = new martview(conn, dataview);
        }

        private void SelectData(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataview.CurrentRow.Index;
            //productid = Convert.ToInt32(dataview.Rows[count].Cells[0].Value.ToString());

            Pname.Text = dataview.Rows[count].Cells[0].Value.ToString();
            Pprice.Text = dataview.Rows[count].Cells[1].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addtocart_Click(object sender, EventArgs e)
        {
            string Productname = Pname.Text;
            int Productquantity = int.Parse(Qbox.Text);
            int Productprice = int.Parse(Pprice.Text);
            if (string.IsNullOrEmpty(Productname) || Productprice == null || Productprice == null)
            {
                MessageBox.Show("Fill all given feilds", "Warning");
            }
            else
            {
                Addtocart add = new Addtocart(Productname, Productquantity, Productprice);
                add.addData(conn);
            }
            Pname.Clear();
            Qbox.Clear();
            Pprice.Clear();
        }
    }
}
