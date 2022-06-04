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

namespace Proyek_PCS
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        
        public Form2()
        {
            InitializeComponent();
            conn = Form1.conn;
        }

        private void btntambahadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.ShowDialog();
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            menu_alat.Visible = false;
            menu_cust.Visible = false;
            menu_jenis.Visible = false;
            menu_kar.Visible = false;
            menu_lap_jual.Visible = false;
            menu_penjualan.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (menu_alat.Visible == false)
            {
                menu_alat.Visible = true;
                menu_cust.Visible = true;
                menu_jenis.Visible = true;
                menu_kar.Visible = true;
            }
            else
            {
                menu_alat.Visible = false;
                menu_cust.Visible = false;
                menu_jenis.Visible = false;
                menu_kar.Visible = false;
            }
        }

        private void menu_jenis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
            this.Show();
        }

        private void menu_jenis_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void menu_alat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.ShowDialog();
            this.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (menu_penjualan.Visible == false)
            {
                menu_penjualan.Visible = true;
            }
            else
            {
                menu_penjualan.Visible = false;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (menu_lap_jual.Visible == false)
            {
                menu_lap_jual.Visible = true;
            }
            else
            {
                menu_lap_jual.Visible = false;
            }
        }

        private void menu_cust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.ShowDialog();
            this.Show();
        }

        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void menu_penjualan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.ShowDialog();
            this.Show();
        }

        private void menu_kar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
            this.Show();
        }
    }
}
