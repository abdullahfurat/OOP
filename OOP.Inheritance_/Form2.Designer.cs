namespace OOP.Inheritance_
{
    partial class Form2
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
            this.btnBase = new System.Windows.Forms.Button();
            this.btnMobil = new System.Windows.Forms.Button();
            this.btnSmart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase.Location = new System.Drawing.Point(12, 12);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(453, 74);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnMobil
            // 
            this.btnMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobil.Location = new System.Drawing.Point(12, 92);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.Size = new System.Drawing.Size(453, 74);
            this.btnMobil.TabIndex = 0;
            this.btnMobil.Text = "Mobil";
            this.btnMobil.UseVisualStyleBackColor = true;
            this.btnMobil.Click += new System.EventHandler(this.btnMobil_Click);
            // 
            // btnSmart
            // 
            this.btnSmart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmart.Location = new System.Drawing.Point(12, 172);
            this.btnSmart.Name = "btnSmart";
            this.btnSmart.Size = new System.Drawing.Size(453, 74);
            this.btnSmart.TabIndex = 0;
            this.btnSmart.Text = "Smart";
            this.btnSmart.UseVisualStyleBackColor = true;
            this.btnSmart.Click += new System.EventHandler(this.btnSmart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.btnSmart);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.btnBase);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnMobil;
        private System.Windows.Forms.Button btnSmart;
    }
}