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
    public partial class customer_part : Form
    {
        Main_form m_form;
        MySqlConnection msc;
        MySqlCommand command;
        string _account;
        public customer_part(Main_form m, MySqlConnection msc,string account)
        {
            InitializeComponent();
            this.msc = msc;
            _account = account;
            m_form = m;
            Console.WriteLine(_account);
        }
        private void Customer_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();

        }
    }
}
