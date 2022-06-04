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
    public partial class Form7 : Form
    {
        MySqlConnection conn;
        public static string id;
        MySqlCommand cmd;
        string mode = "insert";
        public static DataSet ds;
        public static MySqlDataAdapter da;
        public Form7()
        {
            InitializeComponent();
            conn = Form1.conn;
            loadDataGrid();
            
        }
        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        public void autogennumber()
        {
            MySqlCommand sqlauto = new MySqlCommand("select max(cast(id_customer as int)) + 1 from customer ", conn);
            string autonumber = sqlauto.ExecuteScalar().ToString();
            tbidcust.Text = autonumber.ToString().PadLeft(3,'0');
        }
        public void clear_screen()
        {
            tbidcust.Enabled = false;
            autogennumber();
            tbnamacust.Text = "";
            tbalamatcust.Text = "";
            tbnotelpcust.Text = "";
            rblaki.Checked = false;
            rbperem.Checked = false;
            mode = "insert";
            lblInsert.Text = "INSERT";
            lblDelete.Enabled = false;
            loadDataGrid();
        }
        void loadDataGrid()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT id_customer, nama_customer, if(jk_customer='L','Laki-laki','Perempuan'),alamat_customer,notelp_customer FROM customer";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[3].HeaderText = "Alamat";
            dataGridView1.Columns[4].HeaderText = "No Telp";
        }

        private void lblInsert_Click(object sender, EventArgs e)
        {
            string gendcust = "";
            try
            {
                if (lblInsert.Text == "INSERT")
                {
                    string ins = "insert into customer values (@id_customer , @nama_customer, @jk_customer, @alamat_customer, @notelp_customer)";

                    cmd = new MySqlCommand(ins, conn);

                    if(rblaki.Checked == true)
                    {
                        gendcust = "L";
                    }
                    else if (rbperem.Checked == true)
                    {
                        gendcust = "P";
                    }
                    cmd.Parameters.Add(new MySqlParameter("@id_customer", tbidcust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@nama_customer", tbnamacust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@jk_customer", gendcust));
                    cmd.Parameters.Add(new MySqlParameter("@alamat_customer", tbalamatcust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@notelp_customer", tbnotelpcust.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Insert");
                    clear_screen();
                }
                else
                {
                    string upd = "update customer set nama_customer= @nama_customer,jk_customer=@jk_customer,alamat_customer=@alamat_customer,notelp_customer=@notelp_customer where id_customer=@id_customer ";

                    cmd = new MySqlCommand(upd, conn);

                    cmd.Parameters.Add(new MySqlParameter("@nama_customer", tbnamacust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@jk_customer", gendcust));
                    cmd.Parameters.Add(new MySqlParameter("@alamat_customer", tbalamatcust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@notelp_customer", tbnotelpcust.Text));
                    cmd.Parameters.Add(new MySqlParameter("@id_customer", tbidcust.Text));

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
            tbidcust.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            tbnamacust.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            if (dataGridView1.Rows[idx].Cells[2].Value.ToString() == "Laki-laki") rblaki.Checked = true;
            else rbperem.Checked = true;
            tbalamatcust.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            tbnotelpcust.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            tbalamatcust.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            lblInsert.Text = "UPDATE";
            lblDelete.Enabled = true;
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Data yakin dihapus ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string upd = "delete from customer  where id_customer=@id_customer ";

                    cmd = new MySqlCommand(upd, conn);

                    cmd.Parameters.Add(new MySqlParameter("@id_customer", tbidcust.Text));

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
