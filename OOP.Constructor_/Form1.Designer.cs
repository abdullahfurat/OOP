namespace OOP.Constructor_
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
            this.btnForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrRed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrGreen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrBlue = new System.Windows.Forms.NumericUpDown();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForm
            // 
            this.btnForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm.Location = new System.Drawing.Point(13, 13);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(502, 71);
            this.btnForm.TabIndex = 0;
            this.btnForm.Text = "Form2 Aç";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kırmızı : ";
            // 
            // nmrRed
            // 
            this.nmrRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrRed.Location = new System.Drawing.Point(87, 123);
            this.nmrRed.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nmrRed.Name = "nmrRed";
            this.nmrRed.Size = new System.Drawing.Size(273, 26);
            this.nmrRed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeşil : ";
            // 
            // nmrGreen
            // 
            this.nmrGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrGreen.Location = new System.Drawing.Point(87, 155);
            this.nmrGreen.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nmrGreen.Name = "nmrGreen";
            this.nmrGreen.Size = new System.Drawing.Size(273, 26);
            this.nmrGreen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mavi : ";
            // 
            // nmrBlue
            // 
            this.nmrBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrBlue.Location = new System.Drawing.Point(87, 187);
            this.nmrBlue.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nmrBlue.Name = "nmrBlue";
            this.nmrBlue.Size = new System.Drawing.Size(273, 26);
            this.nmrBlue.TabIndex = 2;
            // 
            // btnRenk
            // 
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenk.Location = new System.Drawing.Point(87, 219);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(273, 57);
            this.btnRenk.TabIndex = 3;
            this.btnRenk.Text = "Renk Değiştir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(128, 321);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(273, 57);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Personel Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 428);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.nmrBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrBlue;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnEkle;
    }
}

