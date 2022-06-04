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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
            conn = Form1.conn;
        }

        private void btnkembaliTAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dataFilledCompletely()
        {
            bool valid = true;

            //cek nama
            if (String.IsNullOrEmpty(tbnamakaryawan.Text))
            {
                valid = false;
                MessageBox.Show("Nama belum diisi");
            }

            //cek jenis gendcust
            if (rblk.Checked == false && rbp.Checked == false)
            {
                valid = false;
                MessageBox.Show("Jenis gendcust belum dipilih");
            }

            //cek alamat
            if (String.IsNullOrEmpty(tbalamatkaryawan.Text))
            {
                valid = false;
                MessageBox.Show("Alamat belum diisi");
            }

            //cek nomor telpon
            if (String.IsNullOrEmpty(tbnotelpkaryawan.Text))
            {
                valid = false;
                MessageBox.Show("Nomor Telepon belum diisi");
            }
            else
            {
                Int64 n;
                bool isNumeric = Int64.TryParse(tbnotelpkaryawan.Text, out n);
                if (!isNumeric)
                {
                    valid = false;
                    MessageBox.Show("Nomor Telepon harus angka");
                }
            }

            //cek tanggal lahir
            if (dateTimePicker1.Value.ToString() == "")
            {
                MessageBox.Show("Tanggal Lahir perlu diisi");
                valid = false;
            }
            else if ((DateTime.Now - dateTimePicker1.Value).Days <= 0)
            {
                MessageBox.Show("Tanggal Lahir lebih dari hari ini");
                valid = false;
            }

            //cek username
            if (String.IsNullOrEmpty(tbusnamekaryawan.Text))
            {
                valid = false;
                MessageBox.Show("Username belum diisi");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from karyawan";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(6).Equals(tbusnamekaryawan.Text))
                        {
                            valid = false;
                            MessageBox.Show("Username sudah dipakai");
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //cek password
            if (String.IsNullOrEmpty(tbpasskaryawan.Text))
            {
                valid = false;
                MessageBox.Show("Password belum diisi");
            }
            return valid;
        }
        private string padding(int a)
        {
            string paddingResult = "";
            if (a >= 10000)
            {
                paddingResult = a.ToString();
            }
            else if (a >= 1000)
            {
                paddingResult = "0" + a.ToString();
            }
            else if (a >= 100)
            {
                paddingResult = "00" + a.ToString();
            }
            else if (a >= 10)
            {
                paddingResult = "000" + a.ToString();
            }
            else if (a >= 1)
            {
                paddingResult = "0000" + a.ToString();
            }
            return paddingResult;
        }
        private void btnsubmitTAdmin_Click(object sender, EventArgs e)
        {
            if (dataFilledCompletely())
            {
                try
                {
                    int order = 1;
                    int spaceLocation = 0;
                    string kode = "";
                    bool haveSpace = false;
                    if (tbnamakaryawan.Text.Contains(" "))
                    {
                        haveSpace = true;
                        spaceLocation = tbnamakaryawan.Text.IndexOf(" ");
                    }
                    if (haveSpace == false)
                    {
                        kode = kode + tbnamakaryawan.Text.Substring(0, 4).ToUpper();
                    }
                    else if (haveSpace == true)
                    {
                        kode = kode + tbnamakaryawan.Text.Substring(0, 2).ToUpper() + tbnamakaryawan.Text.Substring(spaceLocation + 1, 2).ToUpper();
                    }
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from karyawan";
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(0).Contains(kode))
                        {
                            order++;
                        }
                    }
                    conn.Close();

                    kode = kode + padding(order);

                    string nama = tbnamakaryawan.Text;
                    string gendcust = "";
                    if (rblk.Checked == true)
                    {
                        gendcust = "L";
                    }
                    else if (rbp.Checked == true)
                    {
                        gendcust = "P";
                    }
                    string alamat = tbalamatkaryawan.Text;
                    string notelp = tbnotelpkaryawan.Text;
                    DateTime tgllahir = dateTimePicker1.Value;
                    string username = tbusnamekaryawan.Text;
                    string password = tbpasskaryawan.Text;

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into karyawan values(@id, @nama, @gendcust, @alamat, @telp, @tanggal, @username, @password)";
                    cmd.Parameters.Add(new MySqlParameter("@id", kode));
                    cmd.Parameters.Add(new MySqlParameter("@nama", nama));
                    cmd.Parameters.Add(new MySqlParameter("@gendcust", gendcust));
                    cmd.Parameters.Add(new MySqlParameter("@alamat", alamat));
                    cmd.Parameters.Add(new MySqlParameter("@telp", notelp));
                    cmd.Parameters.Add(new MySqlParameter("@tanggal", tgllahir));
                    cmd.Parameters.Add(new MySqlParameter("@username", username));
                    cmd.Parameters.Add(new MySqlParameter("@password", password));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Karyawan berhasil ditambah");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT id_karyawan, nama_karyawan , jk_karyawan ,alamat_karyawan,notelp_karyawan ,tgl_masuk, usname_karyawan , pass_karyawan  FROM Karyawan";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID Karyawan";
            dataGridView1.Columns[1].HeaderText = "Nama Karyawan";
            dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[3].HeaderText = "Alamat Karyawan";
            dataGridView1.Columns[4].HeaderText = "No Telp";
            dataGridView1.Columns[5].HeaderText = "Tanggal Masuk";
            dataGridView1.Columns[6].HeaderText = "Username";
            dataGridView1.Columns[7].HeaderText = "Password";


        }
    }
}
