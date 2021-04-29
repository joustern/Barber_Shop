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
        //public Boolean _log_in = false;
        public temp_customer(Main_form m, MySqlConnection msc)
        {
            InitializeComponent();
            this.msc = msc;
            log_in.Checked = true;
            m_form = m;
            this.DialogResult = DialogResult.Cancel;
            m_name.Text = null;
        }

        private void m_submit_Click(object sender, EventArgs e)
        {
            string get_name = "select customer_account from barbershop.customer where customer_account='" + m_account.Text + "'";
            command = msc.CreateCommand();
            msc.Open();
            command.CommandText = get_name;
            string _account = (string)command.ExecuteScalar();
            if (log_in.Checked)
            {
                if (_account == null)
                {
                    MessageBox.Show("incorrect account");
                }
                else
                {
                    string get_pw = "select password from barbershop.customer where customer_account='" + m_account.Text + "'";
                    command.CommandText = get_pw;
                    string _pw = (string)command.ExecuteScalar();
                    if (string.Equals(_pw, m_password.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                        msc.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("incorrect password");
                        
                    }
                }
            }
            else
            {
                if (_account == null)
                {
                    if (string.Equals(m_password.Text, password_check.Text))
                    {
                        if (!String.IsNullOrEmpty(m_name.Text))
                        {
                            string add_account = "insert into customer(customer_account,Name,password,vip_member) values('"+m_account.Text+"','" + m_name.Text + "','" + m_password.Text + "',false)";
                            command.CommandText = add_account;
                            command.ExecuteNonQuery();
                            msc.Close();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("enter your name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("password must be equal");
                    }
                }
                else
                {
                    MessageBox.Show("account has existed");
                }                
            }
            msc.Close();
        }

        private void log_in_CheckedChanged(object sender, EventArgs e)
        {
            password_check.Visible = false;
            pw_check_lb.Visible = false;
            name_lb.Visible = false;
            m_name.Visible = false;
        }

        private void sign_up_CheckedChanged(object sender, EventArgs e)
        {
            password_check.Visible = true;
            pw_check_lb.Visible = true;
            name_lb.Visible = true;
            m_name.Visible = true;
        }
        private void Temp_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();

        }
        public string get_account
        {
            get
            {
                return m_account.Text;
            }
        }
    }
}
