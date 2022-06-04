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
    public partial class Form6 : Form
    {
        MySqlConnection conn;
        int id_jenis=0;
        bool msg = false;
        public Form6()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadDataGrid();
        }
        private void clear_screen()
        {
            tbadminid.Text = "-"; tbadminbarang.Text = "";
            tbadminharga.Text = ""; numadminstock.Text= "0";
            cbadminbarang.Text = "";tbadminmerek.Text = "";
            tbcaribarang.Text = "Masukkan ID atau Nama";
            tbcaribarang.ForeColor = Color.LightGray;
            btnadminbarang.Enabled = true;
            tbadminid.Enabled = false;
        }

        private void btnkembaliTAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadDataGrid()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            string query = "SELECT id_alat_musik as 'ID Alat Musik', nama_alat_musik as 'Nama Alat Musik', CASE WHEN id_jenis = '1' THEN 'Guitar' WHEN id_jenis = '2' THEN 'Piano' END as 'Jenis Alat Musik'," +
                " merek as Merk,concat(stock,' pcs') as 'Stock',concat('Rp ',harga) as 'Harga',id_jenis FROM alat_musik";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Visible = false; //untuk idjenis
        }
        private void btnadminbarang_Click(object sender, EventArgs e)
        {
            if (tbadminbarang.Text == "")
            {
                MessageBox.Show("nama harus diisi ");
            }
            else if (cbadminbarang.Text == "")
            {
                MessageBox.Show("tipe jenis barang harus dipilih");
            }
            else if (tbadminharga.Text == "")
            {
                MessageBox.Show("harga harus diisi");
            }
            else if (numadminstock.Text== "" )
            {
                MessageBox.Show("pilih dulu status ketersediaan");
            }
            else
            {
                int value, value1;
                bool bgm = int.TryParse(tbadminharga.Text, out value);
                bool bgm1 = int.TryParse(numadminstock.Text, out value1);
                if (bgm == false)
                {
                    MessageBox.Show("Harga harus berupa integer");
                }
                else if (bgm1 == false)
                {
                    MessageBox.Show("Stock harus berupa integer");
                }
                else
                {
                    if (int.Parse(tbadminharga.Text) <= 0)
                    {
                        MessageBox.Show("Harga Tidak boleh lebih kecil dari 0");
                    }
                    else if (int.Parse(numadminstock.Text) < 0)
                    {
                        MessageBox.Show("Stock Tidak boleh lebih kecil dari 0");
                    }
                    else
                    {
                        try
                        {
                            int idj = 0;
                            string kode=" ",id;
                            if (cbadminbarang.Text == "Guitar")
                            {
                                idj = 1;
                                kode = "G";
                            }else if(cbadminbarang.Text == "Piano")
                            {
                                idj = 2;
                                kode = "P";
                            }
                            string ctr = "select count(*) from alat_musik where id_jenis = '"+idj+"'";
                            MySqlCommand count = new MySqlCommand(ctr, conn);
                            string tempctr = count.ExecuteScalar().ToString();
                           
                            id = kode + "00" + (Convert.ToInt32(tempctr)+1);
                            String sql = "insert into alat_musik values( @id_alat_musik,@nama_alat_musik,@id_jenis,@merek,@stock,@harga)";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.Add(new MySqlParameter("@id_alat_musik", id));
                            cmd.Parameters.Add(new MySqlParameter("@nama_alat_musik", tbadminbarang.Text));
                            if (cbadminbarang.Text == "Guitar") cmd.Parameters.Add(new MySqlParameter("@id_jenis", 1));
                            else if (cbadminbarang.Text == "Piano") cmd.Parameters.Add(new MySqlParameter("@id_jenis", 2));
                            cmd.Parameters.Add(new MySqlParameter("@merek", tbadminmerek.Text));
                            cmd.Parameters.Add(new MySqlParameter("@stock", numadminstock.Value));
                            cmd.Parameters.Add(new MySqlParameter("@harga", tbadminharga.Text));

                            cmd.ExecuteNonQuery();
                            loadDataGrid();
                            clear_screen();
                            MessageBox.Show("Berhasil Insert!");
                        }

                        catch (System.Exception excep)
                        {
                            MessageBox.Show(excep.Message);
                        }
                    }
                }
            }
        }

        private void btnadminclear_Click(object sender, EventArgs e)
        {
            clear_screen();
            loadDataGrid();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string ctr = "select count(*) from jenis_alat_musik";
            MySqlCommand count = new MySqlCommand(ctr, conn);
            string tempctr = count.ExecuteScalar().ToString();
            for (int i = 0; i < Convert.ToInt32(tempctr); i++)
            {
                string jenis = "select nama_jenis from jenis_alat_musik jam WHERE id_jenis = " + (i + 1);
                MySqlCommand jen = new MySqlCommand(jenis, conn);
                string j = jen.ExecuteScalar().ToString();
                cbadminbarang.Items.Add(j);
            }
        }

        private void btnadminupdate_Click(object sender, EventArgs e)
        {
            if (tbadminid.Text == "-")
            {
                MessageBox.Show("Id tidak ditemukan!");
            }
            else
            {
                try
                {
                    if (cbadminbarang.Text == "Guitar") id_jenis = 1;
                    else if (cbadminbarang.Text == "Piano") id_jenis = 2;
                    string sql = "update alat_musik set nama_alat_musik=@nama_alat_musik,id_jenis=@id_jenis,merek=@merek,stock=@stock,harga=@harga where id_alat_musik=@id_alat_musik";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.Add(new MySqlParameter("@id_alat_musik", tbadminid.Text));
                    cmd.Parameters.Add(new MySqlParameter("@nama_alat_musik", tbadminbarang.Text));
                    if (cbadminbarang.Text == "Guitar") cmd.Parameters.Add(new MySqlParameter("@id_jenis", 1));
                    else if (cbadminbarang.Text == "Piano") cmd.Parameters.Add(new MySqlParameter("@id_jenis", 2));
                    cmd.Parameters.Add(new MySqlParameter("@merek", tbadminmerek.Text));
                    cmd.Parameters.Add(new MySqlParameter("@stock", numadminstock.Text));
                    cmd.Parameters.Add(new MySqlParameter("@harga", tbadminharga.Text));
                
                    cmd.ExecuteNonQuery();
                    loadDataGrid();
                    clear_screen();
                    MessageBox.Show("Berhasil Update!");
                    btnadminbarang.Enabled = true;
                    tbadminid.Enabled = false;
                }

                catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbadminid.Enabled = true;
            btnadminbarang.Enabled = false;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            tbadminid.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            tbadminbarang.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            cbadminbarang.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            tbadminmerek.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string stock = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            string[] subs = stock.Split(' ');
            numadminstock.Text = subs[0];
            string harga = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            string[] sub = harga.Split(' ');
            tbadminharga.Text = sub[1];
        }

        private void btnadmindelete_Click(object sender, EventArgs e)
        {
            if (tbadminid.Text == "-")
            {
                MessageBox.Show("Id tidak ditemukan!");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Yakin hapus ? ","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "delete from alat_musik where id_alat_musik=@id_alat_musik";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.Add(new MySqlParameter("@id_alat_musik", tbadminid.Text));

                        cmd.ExecuteNonQuery();
                        loadDataGrid();
                        clear_screen();
                        MessageBox.Show("Berhasil Delete!");
                        btnadminbarang.Enabled = true;
                        tbadminid.Enabled = false;
                    }
                }

                catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        private void btnadmincari_Click(object sender, EventArgs e)
        {
            if (tbcaribarang.Text == tbcaribarang.Text.Substring(0,1)+ "0"+ tbcaribarang.Text.Substring(2, 2))
            {
                string query = "SELECT id_alat_musik as 'ID Alat Musik', nama_alat_musik as 'Nama Alat Musik', CASE WHEN id_jenis = '1' THEN 'Guitar' WHEN id_jenis = '2' THEN 'Piano' END as 'Jenis Alat Musik'," +
                " merek as Merk,concat(stock,' pcs') as 'Stock',concat('Rp ',harga) as 'Harga' FROM alat_musik where id_alat_musik='" + tbcaribarang.Text + "'"; ;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows[0].Cells[0].Value  == null)
                {
                    msg = true;
                }

                if (msg == true)
                {
                    MessageBox.Show("Id tidak ditemukan");
                    msg = false;
                    clear_screen();
                    loadDataGrid();
                }
            }
            else
            {
                string query = "SELECT id_alat_musik as 'ID Alat Musik', nama_alat_musik as 'Nama Alat Musik', CASE WHEN id_jenis = '1' THEN 'Guitar' WHEN id_jenis = '2' THEN 'Piano' END as 'Jenis Alat Musik'," +
                " merek as Merk,concat(stock,' pcs') as 'Stock',concat('Rp ',harga) as 'Harga' FROM alat_musik where nama_alat_musik LIKE '%" + tbcaribarang.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows[0].Cells[1].Value == null)
                {
                    msg = true;
                }

                if (msg == true)
                {
                    MessageBox.Show("Nama alat musik tidak ditemukan");
                    msg = false;
                    clear_screen();
                    loadDataGrid();
                }   
            }

        }

        private void tbcaribarang_Enter(object sender, EventArgs e)
        {
            if (tbcaribarang.Text == "Masukkan ID atau Nama")
            {
                tbcaribarang.Text = "";
                tbcaribarang.ForeColor = Color.Black;
            }
            else
            {
                clear_screen(); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
