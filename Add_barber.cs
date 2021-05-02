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
    public partial class Add_barber : Form
    {
        MySqlConnection msc;
        public Add_barber(MySqlConnection msc)
        {
            this.msc = msc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            msc.Open();
            MySqlCommand command = msc.CreateCommand();
            if (String.IsNullOrEmpty(name_tx.Text)||String.IsNullOrEmpty(gender_tx.Text)||String.IsNullOrEmpty(salary_tx.Text))
            {
                MessageBox.Show("");
            }
            else
            {
                if (String.IsNullOrEmpty(phone_tx.Text))
                {
                    sql = "insert into barber (barber_name,Gender,salary) values('" + name_tx.Text + "','" + gender_tx.Text + "','" + int.Parse(salary_tx.Text) + "')";
                    command.CommandText = sql;
                    command.ExecuteScalar();
                }
                else
                {
                    sql = "insert into barber (barber_name,Gender,Cellphone,salary) values('" + name_tx.Text + "','" + gender_tx.Text + "','"+phone_tx.Text+"','" + int.Parse(salary_tx.Text) + "')";
                    command.CommandText = sql;
                    command.ExecuteScalar();
                }
            }
            msc.Close();
            this.Close();
        }
    }
}
