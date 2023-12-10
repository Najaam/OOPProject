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
using static OOPProject.Login;

namespace OOPProject
{
    public partial class ViewProduct : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");
        int price;
        int productid;
        class View : Datauser
        {
           
            public View(SqlConnection connect,DataGridView dView)
            {
                string qurey = $"Select * from Product where email = '{useremail}'";
                SqlDataAdapter adapter = new SqlDataAdapter(qurey, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt == null)
                {

                } else
                {
                    dView.DataSource = dt;
                    
                        }
            }
           
        }
        class updateProduct 
        {
            string email;
            int productid;
            string Productname;
            string Productdescription;
            int Productprice;
            public updateProduct(int pi,string pn, string pd, int pp)
            {
                productid = pi;
                Productname = pn;
                Productdescription = pd;
                Productprice = pp;
            }
            public void addData(SqlConnection connection)
            {
                string qurey = $"update Product  set pname ='{Productname}', pdescription = '{Productdescription}',pprice = '{Productprice}' where id = '{productid}'";
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
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            View v = new View(conn, dataView);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Sellerhome sh = new Sellerhome();
            sh.Show();
            Visible = false;
        }

        private void SelectData(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataView.CurrentRow.Index;
            productid = Convert.ToInt32(dataView.Rows[count].Cells[0].Value.ToString());

            pid.Text = productid.ToString();
            pname.Text = dataView.Rows[count].Cells[2].Value.ToString();
            pdes.Text = dataView.Rows[count].Cells[3].Value.ToString();
            price = Convert.ToInt32(dataView.Rows[count].Cells[4].Value.ToString());
            pprice.Text = price.ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Productname = pname.Text;
            string Productdescription = pdes.Text;
            int Productprice = int.Parse(pprice.Text);
            if (string.IsNullOrEmpty(Productname) || string.IsNullOrEmpty(Productdescription) || Productprice == null)
            {
                MessageBox.Show("Fill all given feilds", "Warning");
            }
            else
            {
                updateProduct update = new updateProduct(productid,Productname, Productdescription, Productprice);
                update.addData(conn);
            }
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
         

                    View v = new View(conn, dataView);
            pid.Clear();
            pname.Clear();
            pdes.Clear();
            pprice.Clear();
        }
    }
}
