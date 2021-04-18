using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barber_Shop
{
    public partial class Main_form : Form
    {
        customer_part customer_Form;
        Barber_part barber_Form;
        string connectstring = "data source=127.0.0.1;database=barbershop;user id=root;password=root;pooling=true;charset=utf8;";
        MySqlConnection msc;
        MySqlCommand command;
        public Main_form()
        {
            InitializeComponent();
            msc = new MySqlConnection(connectstring);
            msc.Open();
            
            msc.Close();
            
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer_Form = new customer_part(this,msc);
            this.Hide();
            customer_Form.Show();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            barber_Form = new Barber_part(this,msc);
            this.Hide();
            barber_Form.Show();
        }
    }
}
