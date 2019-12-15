namespace OOP.Class_Ornek
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefon = new System.Windows.Forms.TextBox();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.cmbPersonelDepartman = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tsmYeniPersonel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tsmYeniPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Personel Mail : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Personel Departman : ";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(210, 27);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(253, 26);
            this.txtPersonelAdi.TabIndex = 2;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(210, 59);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(253, 26);
            this.txtPersonelSoyadi.TabIndex = 2;
            // 
            // txtPersonelTelefon
            // 
            this.txtPersonelTelefon.Location = new System.Drawing.Point(210, 91);
            this.txtPersonelTelefon.Name = "txtPersonelTelefon";
            this.txtPersonelTelefon.Size = new System.Drawing.Size(253, 26);
            this.txtPersonelTelefon.TabIndex = 2;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(210, 123);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(253, 26);
            this.txtPersonelMail.TabIndex = 2;
            // 
            // cmbPersonelDepartman
            // 
            this.cmbPersonelDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelDepartman.FormattingEnabled = true;
            this.cmbPersonelDepartman.Location = new System.Drawing.Point(210, 155);
            this.cmbPersonelDepartman.Name = "cmbPersonelDepartman";
            this.cmbPersonelDepartman.Size = new System.Drawing.Size(253, 28);
            this.cmbPersonelDepartman.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.tsmYeniPersonel;
            this.groupBox1.Controls.Add(this.txtPersonelAdi);
            this.groupBox1.Controls.Add(this.cmbPersonelDepartman);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersonelTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPersonelSoyadi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekleme Ekranı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(23, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol Paneli";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(242, 39);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(221, 45);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 39);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(221, 45);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(510, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 305);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Listesi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 264);
            this.listBox1.TabIndex = 0;
            // 
            // tsmYeniPersonel
            // 
            this.tsmYeniPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelToolStripMenuItem});
            this.tsmYeniPersonel.Name = "tsmYeniPersonel";
            this.tsmYeniPersonel.Size = new System.Drawing.Size(181, 48); 
            // 
            // yeniPersonelToolStripMenuItem
            // 
            this.yeniPersonelToolStripMenuItem.Image = global::OOP.Class_Ornek.Properties.Resources.icons8_add_user_male_96px_1;
            this.yeniPersonelToolStripMenuItem.Name = "yeniPersonelToolStripMenuItem";
            this.yeniPersonelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniPersonelToolStripMenuItem.Text = "Yeni Personel";
            this.yeniPersonelToolStripMenuItem.Click += new System.EventHandler(this.yeniPersonelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 335);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tsmYeniPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelTelefon;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.ComboBox cmbPersonelDepartman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip tsmYeniPersonel;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelToolStripMenuItem;
    }
}

