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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        public static string id;
        MySqlCommand cmd;
        string mode = "insert";
        public Form3()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadDataGrid();
        }
        void loadDataGrid()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT id_jenis as 'ID Alat Musik', nama_jenis as 'Nama Jenis' FROM jenis_alat_musik";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void btnkembaliTAdmin_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            clear_screen();
        }

        public void autogennumber()
        {
            MySqlCommand sqlauto = new MySqlCommand("select max(id_jenis) + 1 from jenis_alat_musik", conn);
            string autonumber = sqlauto.ExecuteScalar().ToString();
            tbIDAlat.Text = autonumber;
        }

        public void clear_screen()
        {
            tbIDAlat.Enabled = false;
            autogennumber();
            tbnamajenis.Text = "";
            mode = "insert";
            lblInsert.Text = "INSERT";
            lblDelete.Enabled = false;
            loadDataGrid();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblInsert.Text == "INSERT")
                {
                    string ins = "insert into jenis_alat_musik values (@id_jenis , @nama_jenis)";

                    cmd = new MySqlCommand(ins, conn);

                    cmd.Parameters.Add(new MySqlParameter("@id_jenis", tbIDAlat.Text));
                    cmd.Parameters.Add(new MySqlParameter("@nama_jenis", tbnamajenis.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Insert");
                    clear_screen();
                }
                else
                {
                    string upd = "update jenis_alat_musik set nama_jenis= @nama_jenis where id_jenis=@id_jenis ";

                    cmd = new MySqlCommand(upd, conn);

                    cmd.Parameters.Add(new MySqlParameter("@id_jenis", tbIDAlat.Text));
                    cmd.Parameters.Add(new MySqlParameter("@nama_jenis", tbnamajenis.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Update");
                    clear_screen();
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Tidak bisa diupdate karena " + excep.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mode = "update";
            int idx = dataGridView1.CurrentRow.Index;
            tbIDAlat.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            tbnamajenis.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            lblInsert.Text = "UPDATE";
            lblDelete.Enabled = true;
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Data yakin dihapus ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string upd = "delete from jenis_alat_musik  where id_jenis=@id_jenis ";

                    cmd = new MySqlCommand(upd, conn);

                    cmd.Parameters.Add(new MySqlParameter("@id_jenis", tbIDAlat.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil delete");
                    clear_screen();
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Tidak bisa dihapus karena " + excep.Message);
            }
        }
    }
}
