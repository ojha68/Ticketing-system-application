namespace CW1
{
    partial class EmployeePanel
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
            this.btlogout = new System.Windows.Forms.Button();
            this.btcheckOut = new System.Windows.Forms.Button();
            this.btcheckIn = new System.Windows.Forms.Button();
            this.btviewReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(159, 300);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(129, 36);
            this.btlogout.TabIndex = 0;
            this.btlogout.Text = "LogOut";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btcheckOut
            // 
            this.btcheckOut.Location = new System.Drawing.Point(247, 150);
            this.btcheckOut.Name = "btcheckOut";
            this.btcheckOut.Size = new System.Drawing.Size(129, 36);
            this.btcheckOut.TabIndex = 0;
            this.btcheckOut.Text = "Check Out";
            this.btcheckOut.UseVisualStyleBackColor = true;
            this.btcheckOut.Click += new System.EventHandler(this.btcheckOut_Click);
            // 
            // btcheckIn
            // 
            this.btcheckIn.Location = new System.Drawing.Point(62, 150);
            this.btcheckIn.Name = "btcheckIn";
            this.btcheckIn.Size = new System.Drawing.Size(129, 36);
            this.btcheckIn.TabIndex = 0;
            this.btcheckIn.Text = "Check In";
            this.btcheckIn.UseVisualStyleBackColor = true;
            this.btcheckIn.Click += new System.EventHandler(this.btcheckIn_Click);
            // 
            // btviewReport
            // 
            this.btviewReport.Location = new System.Drawing.Point(159, 231);
            this.btviewReport.Name = "btviewReport";
            this.btviewReport.Size = new System.Drawing.Size(129, 36);
            this.btviewReport.TabIndex = 0;
            this.btviewReport.Text = "View Report";
            this.btviewReport.UseVisualStyleBackColor = true;
            this.btviewReport.Click += new System.EventHandler(this.btviewReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Panel";
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btviewReport);
            this.Controls.Add(this.btcheckIn);
            this.Controls.Add(this.btcheckOut);
            this.Controls.Add(this.btlogout);
            this.Name = "EmployeePanel";
            this.Text = "EmployeePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btcheckOut;
        private System.Windows.Forms.Button btcheckIn;
        private System.Windows.Forms.Button btviewReport;
        private System.Windows.Forms.Label label1;
    }
}