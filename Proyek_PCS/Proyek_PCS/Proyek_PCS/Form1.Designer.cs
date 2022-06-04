
namespace Proyek_PCS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pesan = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbusname = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(395, 146);
            this.tbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(102, 22);
            this.tbDatabase.TabIndex = 30;
            this.tbDatabase.Tag = "Input Database Name";
            this.tbDatabase.Text = "db_proyekpcs";
            this.tbDatabase.Visible = false;
            this.tbDatabase.MouseHover += new System.EventHandler(this.tbServer_MouseHover);
            // 
            // tbUID
            // 
            this.tbUID.Location = new System.Drawing.Point(395, 116);
            this.tbUID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(102, 22);
            this.tbUID.TabIndex = 29;
            this.tbUID.Tag = "Input User ID/Name";
            this.tbUID.Text = "root";
            this.tbUID.Visible = false;
            this.tbUID.MouseHover += new System.EventHandler(this.tbServer_MouseHover);
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(395, 86);
            this.tbServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(102, 22);
            this.tbServer.TabIndex = 28;
            this.tbServer.Tag = "Input Server Name";
            this.tbServer.Text = "localhost";
            this.tbServer.Visible = false;
            this.tbServer.MouseHover += new System.EventHandler(this.tbServer_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Username :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 39);
            this.label8.TabIndex = 24;
            this.label8.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 79);
            this.panel1.TabIndex = 33;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(529, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // pesan
            // 
            this.pesan.Name = "pesan";
            this.pesan.Size = new System.Drawing.Size(0, 16);
            this.pesan.Tag = "";
            // 
            // tbusname
            // 
            this.tbusname.Location = new System.Drawing.Point(177, 107);
            this.tbusname.Name = "tbusname";
            this.tbusname.Size = new System.Drawing.Size(187, 22);
            this.tbusname.TabIndex = 35;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(177, 137);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(187, 22);
            this.tbpass.TabIndex = 36;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Proyek_PCS.Properties.Resources.mini;
            this.label1.Location = new System.Drawing.Point(174, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 70);
            this.label1.TabIndex = 37;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Proyek_PCS.Properties.Resources.buttonsdasar;
            this.pictureBox1.Location = new System.Drawing.Point(451, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbusname);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: LOGIN FORM :.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pesan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbusname;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label1;
    }
}

