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
    public partial class Barber_part : Form
    {
        Main_form m_form;
        MySqlConnection msc;
        public Barber_part(Main_form m, MySqlConnection msc)
        {
            InitializeComponent();
            m_form = m;
            this.msc = msc;
            this.get_customer();
            this.get_history();
            this.get_barber();
        }

        private void Barber_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void get_customer()
        {
            //msc.Open();
            string sql = "SELECT * FROM barbershop.customer_view";
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = new MySqlCommand(sql, msc);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            this._customer.DataSource = dt1.DefaultView;
            msc.Close();
            msc.Dispose();
            _customer.ReadOnly = true;
        }
        public void get_history()
        {
            string sql = "SELECT * FROM barbershop.history";
            //MySqlCommand sc = new MySqlCommand(sql, msc);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = new MySqlCommand(sql, msc);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            this._history.DataSource = dt1.DefaultView;
            msc.Close();
            msc.Dispose();
            _history.ReadOnly = true;
        }
        public void get_barber()
        {
            string sql = "SELECT * FROM barbershop.barber";
            //MySqlCommand sc = new MySqlCommand(sql, msc);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = new MySqlCommand(sql, msc);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            this._barber.DataSource = dt1.DefaultView;
            msc.Close();
            msc.Dispose();
            _barber.ReadOnly = true;
        }

        private void _barber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = _barber.CurrentCell.RowIndex;
            //int j = _barber.CurrentCell.ColumnIndex;
            string value = _barber.Rows[i].Cells[0].Value.ToString();
            //Console.WriteLine(value);
            try
            {
                Barber_View b = new Barber_View(int.Parse(value), msc,this);
                b.Show();
                get_barber();
            }
            catch
            {

            }
        }
    }
}
