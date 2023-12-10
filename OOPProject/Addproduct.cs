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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOPProject
{
    public partial class Addproduct : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5EIA8UT\\SQLEXPRESS;Initial Catalog=OOP;Integrated Security=True");
        class AddProduct : Datauser
        {
            string email;
            string Productname;
            string Productdescription;
            int Productprice;
            public AddProduct(string pn, string pd, int pp)
            {
                email = useremail;
                Productname = pn;
                Productdescription = pd;
                Productprice = pp;
            }
            public void addData(SqlConnection connection)
            {
                string qurey = $"INSERT INTO Product VALUES ('{email}','{Productname}', '{Productdescription}', '{Productprice}')";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added SuccessFully", "Alert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
                connection.Close(); 
                }
        }
        public Addproduct()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
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
                AddProduct add = new AddProduct(Productname,Productdescription,Productprice);
                add.addData(conn);
            }
            pname.Clear();
            pdes.Clear();
            pprice.Clear(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sellerhome sh = new Sellerhome();   
            sh.Show();  
            Visible = false;
        }
    }
}
