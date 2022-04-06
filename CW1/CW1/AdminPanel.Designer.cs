namespace CW1
{
    partial class AdminPanel
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
            this.btRegisterEmployee = new System.Windows.Forms.Button();
            this.btnViewChart = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetPriceTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegisterEmployee
            // 
            this.btRegisterEmployee.Location = new System.Drawing.Point(135, 94);
            this.btRegisterEmployee.Name = "btRegisterEmployee";
            this.btRegisterEmployee.Size = new System.Drawing.Size(153, 31);
            this.btRegisterEmployee.TabIndex = 0;
            this.btRegisterEmployee.Text = "Register Employee";
            this.btRegisterEmployee.UseVisualStyleBackColor = true;
            this.btRegisterEmployee.Click += new System.EventHandler(this.btRegisterEmployee_Click);
            // 
            // btnViewChart
            // 
            this.btnViewChart.Location = new System.Drawing.Point(94, 169);
            this.btnViewChart.Name = "btnViewChart";
            this.btnViewChart.Size = new System.Drawing.Size(155, 32);
            this.btnViewChart.TabIndex = 1;
            this.btnViewChart.Text = "View Chart";
            this.btnViewChart.UseVisualStyleBackColor = true;
            this.btnViewChart.Click += new System.EventHandler(this.btnViewChart_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(305, 94);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(175, 31);
            this.btnViewReport.TabIndex = 1;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(466, 169);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetPriceTicket
            // 
            this.btnSetPriceTicket.Location = new System.Drawing.Point(275, 169);
            this.btnSetPriceTicket.Name = "btnSetPriceTicket";
            this.btnSetPriceTicket.Size = new System.Drawing.Size(155, 32);
            this.btnSetPriceTicket.TabIndex = 1;
            this.btnSetPriceTicket.Text = "Set Price Ticket";
            this.btnSetPriceTicket.UseVisualStyleBackColor = true;
            this.btnSetPriceTicket.Click += new System.EventHandler(this.btnSetPriceTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Panel";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetPriceTicket);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnViewChart);
            this.Controls.Add(this.btRegisterEmployee);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegisterEmployee;
        private System.Windows.Forms.Button btnViewChart;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetPriceTicket;
        private System.Windows.Forms.Label label1;
    }
}