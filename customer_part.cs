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
        public customer_part(Main_form m)
        {
            InitializeComponent();
            log_in.Checked = true;
            m_form = m;
        }

        private void m_submit_Click(object sender, EventArgs e)
        {

        }

        private void log_in_CheckedChanged(object sender, EventArgs e)
        {
            password_check.Visible=false;
            pw_check_lb.Visible = false;
        }

        private void sign_up_CheckedChanged(object sender, EventArgs e)
        {
            password_check.Visible = true;
            pw_check_lb.Visible = true;
        }
        private void Customer_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();

        }
    }
}
