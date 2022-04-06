namespace CW1
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbvisitorid = new System.Windows.Forms.TextBox();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.tbetime = new System.Windows.Forms.TextBox();
            this.tbts = new System.Windows.Forms.TextBox();
            this.tbta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btcalAmount = new System.Windows.Forms.Button();
            this.btpervious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entry Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exit Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time Spend :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount :";
            // 
            // tbvisitorid
            // 
            this.tbvisitorid.Location = new System.Drawing.Point(217, 94);
            this.tbvisitorid.Name = "tbvisitorid";
            this.tbvisitorid.Size = new System.Drawing.Size(119, 22);
            this.tbvisitorid.TabIndex = 1;
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(217, 146);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(119, 22);
            this.tbtime.TabIndex = 1;
            // 
            // tbetime
            // 
            this.tbetime.Location = new System.Drawing.Point(217, 185);
            this.tbetime.Name = "tbetime";
            this.tbetime.Size = new System.Drawing.Size(119, 22);
            this.tbetime.TabIndex = 1;
            // 
            // tbts
            // 
            this.tbts.Location = new System.Drawing.Point(604, 94);
            this.tbts.Name = "tbts";
            this.tbts.Size = new System.Drawing.Size(119, 22);
            this.tbts.TabIndex = 1;
            this.tbts.TextChanged += new System.EventHandler(this.tbts_TextChanged);
            // 
            // tbta
            // 
            this.tbta.Location = new System.Drawing.Point(604, 146);
            this.tbta.Name = "tbta";
            this.tbta.Size = new System.Drawing.Size(119, 22);
            this.tbta.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Checkout";
            // 
            // btcalAmount
            // 
            this.btcalAmount.Location = new System.Drawing.Point(604, 220);
            this.btcalAmount.Name = "btcalAmount";
            this.btcalAmount.Size = new System.Drawing.Size(134, 34);
            this.btcalAmount.TabIndex = 2;
            this.btcalAmount.Text = "Calcualate Amount";
            this.btcalAmount.UseVisualStyleBackColor = true;
            this.btcalAmount.Click += new System.EventHandler(this.btcalAmount_Click);
            // 
            // btpervious
            // 
            this.btpervious.Location = new System.Drawing.Point(217, 231);
            this.btpervious.Name = "btpervious";
            this.btpervious.Size = new System.Drawing.Size(103, 34);
            this.btpervious.TabIndex = 3;
            this.btpervious.Text = "Pervious";
            this.btpervious.UseVisualStyleBackColor = true;
            this.btpervious.Click += new System.EventHandler(this.btpervious_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.btpervious);
            this.Controls.Add(this.btcalAmount);
            this.Controls.Add(this.tbta);
            this.Controls.Add(this.tbts);
            this.Controls.Add(this.tbetime);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.tbvisitorid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbvisitorid;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.TextBox tbetime;
        private System.Windows.Forms.TextBox tbts;
        private System.Windows.Forms.TextBox tbta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btcalAmount;
        private System.Windows.Forms.Button btpervious;
    }
}