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
    public partial class temp_customer : Form
    {
        Main_form m_form;
        MySqlConnection msc;
        MySqlCommand command;
        public temp_customer(Main_form m, MySqlConnection msc)
        {
            InitializeComponent();
            this.msc = msc;
            log_in.Checked = true;
            m_form = m;
        }

        private void m_submit_Click(object sender, EventArgs e)
        {
            if (log_in.Checked)
            {
                string get_name = "select Name from barbershop.customer where Name='" + m_account.Text + "'";
                command = msc.CreateCommand();
                msc.Open();
                command.CommandText = get_name;
                string _name = (string)command.ExecuteScalar();
                if (_name == null)
                {
                    
                }
                else
                {
                    string get_pw = "select password from barbershop.customer where Name='" + m_account.Text + "'";
                    command.CommandText = get_pw;
                    string _pw = (string)command.ExecuteScalar();
                    if (string.Equals(_pw, m_password.Text))
                    {

                    }
                    else
                    {

                    }
                }
                //Console.WriteLine(_name);
                msc.Close();
            }
            else
            {
                string str = "insert into customer(Name,password) values('" + m_account.Text + "','" + m_password.Text + "')";
                //string str = "insert into customer(Name,password) values(" + m_account.Text + "," + m_password.Text + ");";
                command = msc.CreateCommand();
                msc.Open();
                command.CommandText = str;
                command.ExecuteNonQuery();
                msc.Close();
            }
        }

        private void log_in_CheckedChanged(object sender, EventArgs e)
        {
            password_check.Visible = false;
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
