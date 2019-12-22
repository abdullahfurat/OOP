namespace OOP.Struct_
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
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStrcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClass
            // 
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(12, 12);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(277, 73);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "CLASS";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStrcut
            // 
            this.btnStrcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrcut.Location = new System.Drawing.Point(12, 91);
            this.btnStrcut.Name = "btnStrcut";
            this.btnStrcut.Size = new System.Drawing.Size(277, 73);
            this.btnStrcut.TabIndex = 0;
            this.btnStrcut.Text = "STRUCT";
            this.btnStrcut.UseVisualStyleBackColor = true;
            this.btnStrcut.Click += new System.EventHandler(this.btnStrcut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 177);
            this.Controls.Add(this.btnStrcut);
            this.Controls.Add(this.btnClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStrcut;
    }
}

