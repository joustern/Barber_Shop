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
        public Barber_part(Main_form m)
        {
            InitializeComponent();
            m_form = m;
        }

        private void Barber_FormClosing(Object sender, FormClosingEventArgs e)
        {
            m_form.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_form.Show();
            
            this.Close();
        }

        
    }
}
