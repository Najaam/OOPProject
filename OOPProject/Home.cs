using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnmart_Click(object sender, EventArgs e)
        {
            Mart m = new Mart();
            m.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart C = new Cart();
            C.Show();
            Visible = false;
        }

        private void addadress_Click(object sender, EventArgs e)
        {
            Address address = new Address();        
               address.Show();
            Visible = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            Visible =false; 
        }
    }
}
