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
    public partial class Form1 : Form
    {
        public static MySqlConnection conn;
        public static string uid, db, pass, server;
        public static string id;
        MySqlCommand cmd;

        private void tbServer_MouseHover(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            pesan.Text = tb.Tag.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //seperti biasa, kita buat connection
                conn = new MySqlConnection();
                if (tbServer.Text == "" || tbUID.Text == "" || tbDatabase.Text == "")
                {
                    MessageBox.Show("Semua field harus diisi");
                }
                conn.ConnectionString = "server = " + tbServer.Text + "; uid =" + tbUID.Text + "; database =" + tbDatabase.Text;

                conn.Open();

                //this.Hide();
                //Form2 f = new Form2();
                //f.ShowDialog();
                //this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("gagal login");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (tbusname.Text == "" && tbpass.Text == "")
            {
                MessageBox.Show("Semua Harus terisi");
            }
            else
            {
                try
                {
                    bool usernameExist = false;
                    bool correctPassword = false;
                    id = "";

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id_karyawan, nama_karyawan, usname_karyawan, pass_karyawan FROM karyawan;";

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(2) == tbusname.Text)
                        {
                            usernameExist = true;
                            if (reader.GetString(3) == tbpass.Text)
                            {
                                correctPassword = true;
                                id = reader.GetString(0);
                            }
                        }
                    }
                    conn.Close();

                    if (usernameExist && correctPassword)
                    {
                        this.Hide();
                        Form2 f = new Form2();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (!usernameExist)
                    {
                        MessageBox.Show("User tidak ditemukan");
                    }
                    else if (!correctPassword)
                    {
                        MessageBox.Show("Password Salah");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tbusname.Text = "a"; tbpass.Text = "a";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
