namespace CW1
{
    partial class ViewReport
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
            this.btdevelopreport = new System.Windows.Forms.Button();
            this.bttransferfile = new System.Windows.Forms.Button();
            this.btearnings = new System.Windows.Forms.Button();
            this.btvisitors = new System.Windows.Forms.Button();
            this.btpervious = new System.Windows.Forms.Button();
            this.rbdailyreport = new System.Windows.Forms.RadioButton();
            this.rbweeklyreport = new System.Windows.Forms.RadioButton();
            this.dtime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGride = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGride)).BeginInit();
            this.SuspendLayout();
            // 
            // btdevelopreport
            // 
            this.btdevelopreport.Location = new System.Drawing.Point(66, 204);
            this.btdevelopreport.Name = "btdevelopreport";
            this.btdevelopreport.Size = new System.Drawing.Size(146, 32);
            this.btdevelopreport.TabIndex = 0;
            this.btdevelopreport.Text = "Develop Report";
            this.btdevelopreport.UseVisualStyleBackColor = true;
            this.btdevelopreport.Click += new System.EventHandler(this.btdevelopreport_Click);
            // 
            // bttransferfile
            // 
            this.bttransferfile.Location = new System.Drawing.Point(66, 259);
            this.bttransferfile.Name = "bttransferfile";
            this.bttransferfile.Size = new System.Drawing.Size(146, 30);
            this.bttransferfile.TabIndex = 0;
            this.bttransferfile.Text = "Transfer File To CSV";
            this.bttransferfile.UseVisualStyleBackColor = true;
            this.bttransferfile.Click += new System.EventHandler(this.bttransferfile_Click);
            // 
            // btearnings
            // 
            this.btearnings.Location = new System.Drawing.Point(424, 434);
            this.btearnings.Name = "btearnings";
            this.btearnings.Size = new System.Drawing.Size(106, 33);
            this.btearnings.TabIndex = 0;
            this.btearnings.Text = "Earnings";
            this.btearnings.UseVisualStyleBackColor = true;
            this.btearnings.Click += new System.EventHandler(this.btearnings_Click);
            // 
            // btvisitors
            // 
            this.btvisitors.Location = new System.Drawing.Point(290, 434);
            this.btvisitors.Name = "btvisitors";
            this.btvisitors.Size = new System.Drawing.Size(102, 33);
            this.btvisitors.TabIndex = 0;
            this.btvisitors.Text = "Visitors";
            this.btvisitors.UseVisualStyleBackColor = true;
            this.btvisitors.Click += new System.EventHandler(this.btvisitors_Click);
            // 
            // btpervious
            // 
            this.btpervious.Location = new System.Drawing.Point(66, 328);
            this.btpervious.Name = "btpervious";
            this.btpervious.Size = new System.Drawing.Size(146, 32);
            this.btpervious.TabIndex = 0;
            this.btpervious.Text = "Pervious";
            this.btpervious.UseVisualStyleBackColor = true;
            this.btpervious.Click += new System.EventHandler(this.btpervious_Click);
            // 
            // rbdailyreport
            // 
            this.rbdailyreport.AutoSize = true;
            this.rbdailyreport.Location = new System.Drawing.Point(66, 124);
            this.rbdailyreport.Name = "rbdailyreport";
            this.rbdailyreport.Size = new System.Drawing.Size(103, 20);
            this.rbdailyreport.TabIndex = 1;
            this.rbdailyreport.TabStop = true;
            this.rbdailyreport.Text = "Daily Report";
            this.rbdailyreport.UseVisualStyleBackColor = true;
            // 
            // rbweeklyreport
            // 
            this.rbweeklyreport.AutoSize = true;
            this.rbweeklyreport.Location = new System.Drawing.Point(66, 168);
            this.rbweeklyreport.Name = "rbweeklyreport";
            this.rbweeklyreport.Size = new System.Drawing.Size(118, 20);
            this.rbweeklyreport.TabIndex = 1;
            this.rbweeklyreport.TabStop = true;
            this.rbweeklyreport.Text = "Weekly Report";
            this.rbweeklyreport.UseVisualStyleBackColor = true;
            // 
            // dtime
            // 
            this.dtime.Location = new System.Drawing.Point(47, 70);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(200, 22);
            this.dtime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Date Time";
            // 
            // dtGride
            // 
            this.dtGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGride.Location = new System.Drawing.Point(290, 90);
            this.dtGride.Name = "dtGride";
            this.dtGride.RowHeadersWidth = 51;
            this.dtGride.RowTemplate.Height = 24;
            this.dtGride.Size = new System.Drawing.Size(522, 318);
            this.dtGride.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order By :";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtGride);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtime);
            this.Controls.Add(this.rbweeklyreport);
            this.Controls.Add(this.rbdailyreport);
            this.Controls.Add(this.btpervious);
            this.Controls.Add(this.btvisitors);
            this.Controls.Add(this.btearnings);
            this.Controls.Add(this.bttransferfile);
            this.Controls.Add(this.btdevelopreport);
            this.Name = "Report";
            this.Text = "ViewReport";
            ((System.ComponentModel.ISupportInitialize)(this.dtGride)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdevelopreport;
        private System.Windows.Forms.Button bttransferfile;
        private System.Windows.Forms.Button btearnings;
        private System.Windows.Forms.Button btvisitors;
        private System.Windows.Forms.Button btpervious;
        private System.Windows.Forms.RadioButton rbdailyreport;
        private System.Windows.Forms.RadioButton rbweeklyreport;
        private System.Windows.Forms.DateTimePicker dtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGride;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}