namespace Adminkerja
{
    partial class Formmenuadmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            btnmanajemenuser = new Button();
            btnbuatlaporanpenjualan = new Button();
            btnmasukmenugudang = new Button();
            btnmasukmenukasir = new Button();
            btnkeluarpaneladmin = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 762);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 128);
            panel3.Location = new Point(446, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1441, 104);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.esemkitalogo;
            pictureBox1.Location = new Point(55, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 128);
            textBox2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(474, 194);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(370, 55);
            textBox2.TabIndex = 1;
            textBox2.Text = "Silahkan pilih tugas:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnmanajemenuser
            // 
            btnmanajemenuser.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmanajemenuser.Location = new Point(781, 303);
            btnmanajemenuser.Name = "btnmanajemenuser";
            btnmanajemenuser.Size = new Size(300, 77);
            btnmanajemenuser.TabIndex = 2;
            btnmanajemenuser.Text = "Manajemen User";
            btnmanajemenuser.UseVisualStyleBackColor = true;
            btnmanajemenuser.Click += button1_Click;
            // 
            // btnbuatlaporanpenjualan
            // 
            btnbuatlaporanpenjualan.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuatlaporanpenjualan.Location = new Point(212, 303);
            btnbuatlaporanpenjualan.Name = "btnbuatlaporanpenjualan";
            btnbuatlaporanpenjualan.Size = new Size(300, 77);
            btnbuatlaporanpenjualan.TabIndex = 3;
            btnbuatlaporanpenjualan.Text = "Buat Laporan Penjualan";
            btnbuatlaporanpenjualan.UseVisualStyleBackColor = true;
            btnbuatlaporanpenjualan.Click += button2_Click;
            // 
            // btnmasukmenugudang
            // 
            btnmasukmenugudang.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmasukmenugudang.Location = new Point(212, 481);
            btnmasukmenugudang.Name = "btnmasukmenugudang";
            btnmasukmenugudang.Size = new Size(300, 77);
            btnmasukmenugudang.TabIndex = 4;
            btnmasukmenugudang.Text = "Masuk Menu Gudang";
            btnmasukmenugudang.UseVisualStyleBackColor = true;
            btnmasukmenugudang.Click += button3_Click;
            // 
            // btnmasukmenukasir
            // 
            btnmasukmenukasir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmasukmenukasir.Location = new Point(781, 481);
            btnmasukmenukasir.Name = "btnmasukmenukasir";
            btnmasukmenukasir.Size = new Size(300, 77);
            btnmasukmenukasir.TabIndex = 5;
            btnmasukmenukasir.Text = "Masuk Menu Kasir";
            btnmasukmenukasir.UseVisualStyleBackColor = true;
            // 
            // btnkeluarpaneladmin
            // 
            btnkeluarpaneladmin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkeluarpaneladmin.ForeColor = Color.Red;
            btnkeluarpaneladmin.Location = new Point(1091, 704);
            btnkeluarpaneladmin.Name = "btnkeluarpaneladmin";
            btnkeluarpaneladmin.Size = new Size(228, 46);
            btnkeluarpaneladmin.TabIndex = 6;
            btnkeluarpaneladmin.Text = "Keluar";
            btnkeluarpaneladmin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnkeluarpaneladmin);
            panel2.Controls.Add(btnmanajemenuser);
            panel2.Controls.Add(btnmasukmenukasir);
            panel2.Controls.Add(btnmasukmenugudang);
            panel2.Controls.Add(btnbuatlaporanpenjualan);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(404, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1445, 806);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 0);
            label1.Name = "label1";
            label1.Size = new Size(1326, 145);
            label1.TabIndex = 7;
            label1.Text = "Selamat Datang Petugas Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Formmenuadmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1777, 762);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Formmenuadmin";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Button btnmanajemenuser;
        private Button btnbuatlaporanpenjualan;
        private Button btnmasukmenugudang;
        private Button btnmasukmenukasir;
        private Button btnkeluarpaneladmin;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}
