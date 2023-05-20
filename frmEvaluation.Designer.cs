namespace Evaluation_Manager
{
    partial class frmEvaluation
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblMinForGrade = new System.Windows.Forms.Label();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.lblMinForSignature = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(237, 247);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 2;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(234, 231);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(57, 13);
            this.lblTeacher.TabIndex = 3;
            this.lblTeacher.Text = "Ocjenjivač";
            this.lblTeacher.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(340, 231);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Datum evaluacije";
            this.lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(343, 247);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(96, 20);
            this.txtEvaluationDate.TabIndex = 4;
            this.txtEvaluationDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(442, 231);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(40, 13);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Bodovi";
            this.lblPoints.Click += new System.EventHandler(this.lblPoints_Click);
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(445, 247);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(75, 20);
            this.numPoints.TabIndex = 8;
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(12, 25);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(250, 21);
            this.cboActivities.TabIndex = 9;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Location = new System.Drawing.Point(12, 9);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(53, 13);
            this.lblActivities.TabIndex = 10;
            this.lblActivities.Text = "Aktivnosti";
            this.lblActivities.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblMinForGrade
            // 
            this.lblMinForGrade.AutoSize = true;
            this.lblMinForGrade.Location = new System.Drawing.Point(421, 10);
            this.lblMinForGrade.Name = "lblMinForGrade";
            this.lblMinForGrade.Size = new System.Drawing.Size(81, 13);
            this.lblMinForGrade.TabIndex = 14;
            this.lblMinForGrade.Text = "Uvjet za ocjenu";
            this.lblMinForGrade.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(424, 26);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(96, 20);
            this.txtMinForGrade.TabIndex = 13;
            this.txtMinForGrade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblMinForSignature
            // 
            this.lblMinForSignature.AutoSize = true;
            this.lblMinForSignature.Location = new System.Drawing.Point(315, 10);
            this.lblMinForSignature.Name = "lblMinForSignature";
            this.lblMinForSignature.Size = new System.Drawing.Size(77, 13);
            this.lblMinForSignature.TabIndex = 12;
            this.lblMinForSignature.Text = "Uvjet za potpis";
            this.lblMinForSignature.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(318, 26);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 11;
            this.txtMinForSignature.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(12, 67);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(508, 161);
            this.txtActivityDescription.TabIndex = 15;
            // 
            // frmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 318);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.lblMinForGrade);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.lblMinForSignature);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEvaluation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.Label lblMinForGrade;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label lblMinForSignature;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtActivityDescription;
    }
}