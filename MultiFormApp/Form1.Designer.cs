namespace MultiFormApp
{
    partial class FrmWelcome
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
            this.btnOpenAddStudentForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenAddStudentForm
            // 
            this.btnOpenAddStudentForm.Location = new System.Drawing.Point(89, 134);
            this.btnOpenAddStudentForm.Name = "btnOpenAddStudentForm";
            this.btnOpenAddStudentForm.Size = new System.Drawing.Size(142, 56);
            this.btnOpenAddStudentForm.TabIndex = 0;
            this.btnOpenAddStudentForm.Text = " Open Add Student Form";
            this.btnOpenAddStudentForm.UseVisualStyleBackColor = true;
            this.btnOpenAddStudentForm.Click += new System.EventHandler(this.btnOpenAddStudentForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hey you beautiful person, do you want to add a student today?!";
            // 
            // FrmWelcome
            // 
            this.AcceptButton = this.btnOpenAddStudentForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenAddStudentForm);
            this.Name = "FrmWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddStudentForm;
        private System.Windows.Forms.Label label1;
    }
}

