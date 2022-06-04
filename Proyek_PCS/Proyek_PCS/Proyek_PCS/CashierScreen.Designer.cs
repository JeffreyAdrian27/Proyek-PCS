
namespace Proyek_PCS
{
    partial class CashierScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnkembaliTAdmin = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namaAlatMusik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "C A S H I E R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbtotal
            // 
            this.tbtotal.AutoSize = true;
            this.tbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(686, 496);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(111, 32);
            this.tbtotal.TabIndex = 3;
            this.tbtotal.Text = "TOTAL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 326);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(840, 496);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(25, 32);
            this.lbtotal.TabIndex = 5;
            this.lbtotal.Text = "-";
            // 
            // btnkembaliTAdmin
            // 
            this.btnkembaliTAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnkembaliTAdmin.Name = "btnkembaliTAdmin";
            this.btnkembaliTAdmin.Size = new System.Drawing.Size(105, 28);
            this.btnkembaliTAdmin.TabIndex = 20;
            this.btnkembaliTAdmin.Text = "Kembali";
            this.btnkembaliTAdmin.UseVisualStyleBackColor = true;
            this.btnkembaliTAdmin.Click += new System.EventHandler(this.btnkembaliTAdmin_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaAlatMusik,
            this.harga,
            this.jumlah,
            this.subtotal});
            this.dataGridView2.Location = new System.Drawing.Point(525, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(511, 326);
            this.dataGridView2.TabIndex = 21;
            // 
            // namaAlatMusik
            // 
            this.namaAlatMusik.FillWeight = 101.7099F;
            this.namaAlatMusik.HeaderText = "Nama";
            this.namaAlatMusik.MinimumWidth = 6;
            this.namaAlatMusik.Name = "namaAlatMusik";
            this.namaAlatMusik.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.FillWeight = 99.68084F;
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.FillWeight = 99.04591F;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.FillWeight = 99.56332F;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // CashierScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 556);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnkembaliTAdmin);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashierScreen";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbtotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btnkembaliTAdmin;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaAlatMusik;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}