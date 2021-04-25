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
    public partial class Barber_View : Form
    {
        MySqlConnection msc;
        int m_id;
        Barber_part b;
        public Barber_View(int _id, MySqlConnection msc,Barber_part b)
        {
            InitializeComponent();
            this.b = b;
            this.msc = msc;
            m_id = _id;
            get_barber_info();
        }
        public Barber_View()
        {
            InitializeComponent();
        }
        private void get_barber_info()
        {
            string sql = "SELECT * FROM barbershop.barber where barber_id='" + m_id + "'";
            show_lb();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = new MySqlCommand(sql, msc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            msc.Close();
            msc.Dispose();
            b_name_lb.Text = dt.Rows[0][1].ToString();
            b_gender_lb.Text = dt.Rows[0][2].ToString();
            b_phone_lb.Text = dt.Rows[0][3].ToString();
            b_salary_lb.Text = dt.Rows[0][4].ToString();
            b_rate_lb.Text = dt.Rows[0][5].ToString();
            b_name.Text = b_name_lb.Text;
            b_gender.Text = b_gender_lb.Text;
            b_phone.Text = b_phone_lb.Text;
            b_salary.Text = b_salary_lb.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b_name_lb.Visible)
            {
                show_text();
            }
            barber_store.Show();
            barber_modify.Enabled = false;
        }
        private void show_text()
        {
            b_name_lb.Hide();
            b_gender_lb.Hide();
            b_phone_lb.Hide();
            b_salary_lb.Hide();
            b_name.Show();
            b_gender.Show();
            b_phone.Show();
            b_salary.Show();
        }
        private void show_lb()
        {
            b_name.Hide();
            b_gender.Hide();
            b_phone.Hide();
            b_salary.Hide();
            b_name_lb.Show();
            b_gender_lb.Show();
            b_phone_lb.Show();
            b_salary_lb.Show();
        }

        private void barber_store_Click(object sender, EventArgs e)
        {
            string sql = "update barber set barber_name='"+b_name.Text+"' ,Gender='"+b_gender.Text+"' ,Cellphone='"+b_phone.Text+"' ,salary='"+int.Parse(b_salary.Text)+"' where barber_id='"+m_id+"'";
            MySqlCommand command = msc.CreateCommand();
            msc.Open();
            command.CommandText = sql;
            command.ExecuteScalar();
            barber_modify.Enabled = true;
            barber_store.Hide();
            get_barber_info();
            show_lb();
            msc.Close();
        }
        private void View_FormClosing(Object sender, FormClosingEventArgs e)
        {
            b.get_barber();

        }
    }
}
