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
    public partial class Form5 : Form
    {
        public static MySqlConnection conn;
        public static DataSet ds;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter da;
        private string idKasir;
        public string sql;
        public Form5()
        {
            InitializeComponent();
            conn = Form1.conn;
            idKasir = Form1.id;
            loadData();
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
            if (Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) > 0)
            {
                bool existInTray = false;

                string namaBarang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int jumlah = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                int harga = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                int subtotal = jumlah * harga;
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1;

                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                        {
                            existInTray = true;
                            int newQuantity = Int32.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()) + 1;
                            dataGridView2.Rows[i].Cells[2].Value = newQuantity;
                        }
                    }

                    if (!existInTray)
                    {
                        dataGridView2.Rows.Add(namaBarang, harga, 1, subtotal);
                    }

                    updateSubtotal();
                    updateTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Barang Kosong");
            }
            
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
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT am.nama_alat_musik AS 'Alat Musik', jam.nama_jenis AS 'Jenis Alat Musik', am.merek AS 'Merk', am.stock AS 'Stok', am.harga AS 'Harga' FROM alat_musik am, jenis_alat_musik jam WHERE am.id_jenis = jam.id_jenis AND am.stock > 0 AND LOWER(am.nama_alat_musik) LIKE LOWER('%{textBox1.Text}%');";

                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            lbtotal.Text = "";
        }

        private void btnkembaliTAdmin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string ctr2 = "select count(*) from customer";

            cmd = new MySqlCommand(ctr2, conn);

            string tempctr2 = cmd.ExecuteScalar().ToString();

            for (int i = 0; i < Convert.ToInt32(tempctr2); i++)
            {
                string customer = "select nama_customer from customer WHERE id_customer = 00" + (i + 1);
                cmd = new MySqlCommand(customer, conn);

                string j = cmd.ExecuteScalar().ToString();
                comboBox1.Items.Add(j);

            }
        }

        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string nota_beli="";
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Pilih dulu pembelinya pada combobox");
            }
            else
            {
                
                try
                {

                    string ctrht = "select count(*) from htrans";
                    MySqlCommand countht = new MySqlCommand(ctrht, conn);
                    string tempctrht = countht.ExecuteScalar().ToString();

                    
                    if (Convert.ToInt32(tempctrht) < 9)
                    {
                        nota_beli = "N00" + (Convert.ToInt32(tempctrht) + 1);
                    }
                    else
                    {
                        nota_beli = "N0" + (Convert.ToInt32(tempctrht) + 1);
                    }
                    string[] id = new string[dataGridView2.RowCount];
                    string[] harga_beli = new string[dataGridView2.RowCount];
                    string[] quantity = new string[dataGridView2.RowCount];

                   

                    string idcust = "select id_customer from customer where nama_customer = '" + comboBox1.Text + "'";
                    cmd = new MySqlCommand(idcust, conn);
                    string tempidcust = cmd.ExecuteScalar().ToString();
                    string tgl = DateTime.Now.ToString("yyyy-MM-dd");
                    sql = "insert into htrans values(@id_ht,@nota_beli,@tgl_beli,@id_karyawan,@id_customer,@subtotal_beli)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.Add(new MySqlParameter("@id_ht", Convert.ToInt32(tempctrht) + 1));
                    cmd.Parameters.Add(new MySqlParameter("@nota_beli", nota_beli));
                    cmd.Parameters.Add(new MySqlParameter("@tgl_beli", tgl));
                    cmd.Parameters.Add(new MySqlParameter("@id_karyawan", idKasir));
                    cmd.Parameters.Add(new MySqlParameter("@id_customer", tempidcust));
                    cmd.Parameters.Add(new MySqlParameter("@subtotal_beli", lbtotal.Text));
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        string sql = "select id_alat_musik from alat_musik where nama_alat_musik = '" + dataGridView2.Rows[i].Cells[0].Value + "'";
                        MySqlCommand temp = new MySqlCommand(sql, conn);
                        string tempid = temp.ExecuteScalar().ToString();
                        id[i] = tempid;

                        string tempctrdt = "select count(*) from dtrans";
                        MySqlCommand tempcountdt = new MySqlCommand(tempctrdt, conn);
                        string tempctrdt2 = tempcountdt.ExecuteScalar().ToString();

                        harga_beli[i] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                        quantity[i] = dataGridView2.Rows[i].Cells[2].Value.ToString();
                        sql = "insert into dtrans values(@id_dt,@nota_beli,@id_alat_musik,@harga_beli,@quantity,@id_ht)";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.Add(new MySqlParameter("@id_dt", Convert.ToInt32(tempctrdt2) + 1));
                        cmd.Parameters.Add(new MySqlParameter("@nota_beli", nota_beli));
                        cmd.Parameters.Add(new MySqlParameter("@id_alat_musik", id[i]));
                        cmd.Parameters.Add(new MySqlParameter("@harga_beli", harga_beli[i]));
                        cmd.Parameters.Add(new MySqlParameter("@quantity", quantity[i]));
                        cmd.Parameters.Add(new MySqlParameter("@id_ht", Convert.ToInt32(tempctrht)+1));
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Berhasil");
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
                this.Hide();
                Form8 f = new Form8();
                f.nonota = nota_beli;
                f.ShowDialog();
                this.Show();
            }
        
        }
    }
}
