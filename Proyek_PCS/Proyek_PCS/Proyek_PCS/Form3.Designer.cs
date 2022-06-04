
namespace Proyek_PCS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkKembali = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pesan = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.tbnamajenis = new System.Windows.Forms.TextBox();
            this.tbIDAlat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.linkKembali);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 106);
            this.panel1.TabIndex = 35;
            // 
            // linkKembali
            // 
            this.linkKembali.AutoSize = true;
            this.linkKembali.BackColor = System.Drawing.Color.Transparent;
            this.linkKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkKembali.Location = new System.Drawing.Point(746, 65);
            this.linkKembali.Name = "linkKembali";
            this.linkKembali.Size = new System.Drawing.Size(106, 25);
            this.linkKembali.TabIndex = 35;
            this.linkKembali.TabStop = true;
            this.linkKembali.Text = "KEMBALI";
            this.linkKembali.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKembali_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Proyek_PCS.Properties.Resources.My_project;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 39);
            this.label8.TabIndex = 24;
            this.label8.Text = "Master Jenis Alat Musik";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pesan
            // 
            this.pesan.Name = "pesan";
            this.pesan.Size = new System.Drawing.Size(0, 16);
            this.pesan.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblDelete);
            this.panel2.Controls.Add(this.lblInsert);
            this.panel2.Controls.Add(this.tbnamajenis);
            this.panel2.Controls.Add(this.tbIDAlat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 338);
            this.panel2.TabIndex = 46;
            // 
            // lblDelete
            // 
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Image = global::Proyek_PCS.Properties.Resources.buttonsdasar___Copy;
            this.lblDelete.Location = new System.Drawing.Point(834, 86);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(203, 70);
            this.lblDelete.TabIndex = 43;
            this.lblDelete.Text = "DELETE";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.BackColor = System.Drawing.Color.Transparent;
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Image = global::Proyek_PCS.Properties.Resources.buttonsdasar___Copy;
            this.lblInsert.Location = new System.Drawing.Point(620, 86);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(193, 70);
            this.lblInsert.TabIndex = 42;
            this.lblInsert.Text = "INSERT";
            this.lblInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInsert.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbnamajenis
            // 
            this.tbnamajenis.Location = new System.Drawing.Point(769, 46);
            this.tbnamajenis.Name = "tbnamajenis";
            this.tbnamajenis.Size = new System.Drawing.Size(187, 22);
            this.tbnamajenis.TabIndex = 41;
            // 
            // tbIDAlat
            // 
            this.tbIDAlat.Location = new System.Drawing.Point(769, 16);
            this.tbIDAlat.Name = "tbIDAlat";
            this.tbIDAlat.Size = new System.Drawing.Size(187, 22);
            this.tbIDAlat.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nama Jenis Alat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(624, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "ID Alat :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 318);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Master Jenis Alat Musik";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkKembali;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pesan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.TextBox tbnamajenis;
        private System.Windows.Forms.TextBox tbIDAlat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDelete;
    }
}