namespace WindowsForm
{
    partial class EditDialog
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
            this.ulozitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jmenoInput = new System.Windows.Forms.TextBox();
            this.prijmeniInput = new System.Windows.Forms.TextBox();
            this.vekInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ulozitBtn
            // 
            this.ulozitBtn.Location = new System.Drawing.Point(117, 107);
            this.ulozitBtn.Name = "ulozitBtn";
            this.ulozitBtn.Size = new System.Drawing.Size(75, 23);
            this.ulozitBtn.TabIndex = 0;
            this.ulozitBtn.Text = "Ulozit";
            this.ulozitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijmeni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vek";
            // 
            // jmenoInput
            // 
            this.jmenoInput.Location = new System.Drawing.Point(72, 34);
            this.jmenoInput.Name = "jmenoInput";
            this.jmenoInput.Size = new System.Drawing.Size(178, 20);
            this.jmenoInput.TabIndex = 4;
            // 
            // prijmeniInput
            // 
            this.prijmeniInput.Location = new System.Drawing.Point(72, 58);
            this.prijmeniInput.Name = "prijmeniInput";
            this.prijmeniInput.Size = new System.Drawing.Size(178, 20);
            this.prijmeniInput.TabIndex = 5;
            // 
            // vekInput
            // 
            this.vekInput.Location = new System.Drawing.Point(72, 81);
            this.vekInput.Name = "vekInput";
            this.vekInput.Size = new System.Drawing.Size(178, 20);
            this.vekInput.TabIndex = 6;
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 157);
            this.Controls.Add(this.vekInput);
            this.Controls.Add(this.prijmeniInput);
            this.Controls.Add(this.jmenoInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ulozitBtn);
            this.Name = "EditDialog";
            this.Text = "EditDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ulozitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jmenoInput;
        private System.Windows.Forms.TextBox prijmeniInput;
        private System.Windows.Forms.TextBox vekInput;
    }
}