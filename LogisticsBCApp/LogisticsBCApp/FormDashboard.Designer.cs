namespace LogisticsBCApp
{
    partial class FormDashboard
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
            this.buttonReseedData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReseedData
            // 
            this.buttonReseedData.Location = new System.Drawing.Point(775, 799);
            this.buttonReseedData.Name = "buttonReseedData";
            this.buttonReseedData.Size = new System.Drawing.Size(173, 51);
            this.buttonReseedData.TabIndex = 0;
            this.buttonReseedData.Text = "Reseed Data";
            this.buttonReseedData.UseVisualStyleBackColor = true;
            this.buttonReseedData.Click += new System.EventHandler(this.buttonReseedData_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 889);
            this.Controls.Add(this.buttonReseedData);
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReseedData;
    }
}

