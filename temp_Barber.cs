﻿using System;
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
    public partial class temp_Barber : Form
    {
        Main_form m_form;
        MySqlConnection msc;
        MySqlCommand command;
        public temp_Barber()
        {
            InitializeComponent();
        }
        public temp_Barber(Main_form m, MySqlConnection msc)
        {
            InitializeComponent();
            this.msc = msc;
            this.m_form = m;
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msc.Open();
            string get_admin = "select admin_name from admin";
            command = msc.CreateCommand();
            command.CommandText = get_admin;
            string _account = (string)command.ExecuteScalar();
            if (_account == _name.Text)
            {
                string get_pw = "select admin_pw from admin";
                command.CommandText = get_pw;
                string _pw = (string)command.ExecuteScalar();
                if (_pw == _password.Text)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("incorrect password");
                }
            }
            else
            {
                MessageBox.Show("incorrect account");
            }
            msc.Close();
        }
        private void Temp_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();

        }
    }
}
