using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_PCS
{
    public partial class CashierScreen : Form
    {
        public static MySqlConnection conn;
        public static DataSet ds;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter da;
        private string namaKasir;
        public CashierScreen()
        {
            InitializeComponent();
            conn = SelectionScreen.conn;
            namaKasir = LogInForCashier.nama;

            loadData();
        }

        private void btnkembaliTAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()//isi datagridview
        {           
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT am.nama_alat_musik AS 'Alat Musik', jam.nama_jenis AS 'Jenis Alat Musik', am.merek AS 'Merk', am.stock AS 'Stok', am.harga AS 'Harga' FROM alat_musik am, jenis_alat_musik jam WHERE am.id_jenis = jam.id_jenis AND am.stock > 0;";                
                conn.Open();

                conn.Close();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//search
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT am.nama_alat_musik AS 'Alat Musik', jam.nama_jenis AS 'Jenis Alat Musik', am.merek AS 'Merk', am.stock AS 'Stok', am.harga AS 'Harga' FROM alat_musik am, jenis_alat_musik jam WHERE am.id_jenis = jam.id_jenis AND am.stock > 0 AND LOWER(am.nama_alat_musik) LIKE LOWER('%{textBox1.Text}%');";
                conn.Open();

                conn.Close();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateSubtotal()//update subtotal
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[3].Value = Int32.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()) * Int32.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
        }

        private void updateTotal()//update total
        {
            int nominal = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                nominal = nominal + Int32.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
            }
            lbtotal.Text = nominal.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool existInTray = false;

            string namaBarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int jumlah = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            int harga = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            int subtotal = jumlah * harga;

            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                    {
                        existInTray = true;
                        int newQuantity = Int32.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()) + 1;
                        dataGridView2.Rows[i].Cells[1].Value = newQuantity;
                    }
                }

                if (!existInTray)
                {
                    dataGridView2.Rows.Add(namaBarang, 1, harga, harga);
                }

                updateSubtotal();
                updateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
