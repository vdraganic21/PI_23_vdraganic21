namespace EvaluationManager
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
            this.lblKorime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Location = new System.Drawing.Point(27, 45);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(78, 13);
            this.lblKorime.TabIndex = 0;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(55, 77);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(50, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka :";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(111, 42);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(100, 20);
            this.txtKorime.TabIndex = 2;
            this.txtKorime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(111, 74);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 3;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(136, 100);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}

