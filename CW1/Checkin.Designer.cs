namespace CW1
{
    partial class Checkin
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
            this.label6 = new System.Windows.Forms.Label();
            this.hel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddagegroup = new System.Windows.Forms.ComboBox();
            this.ddgroup = new System.Windows.Forms.ComboBox();
            this.tbvisitorid = new System.Windows.Forms.TextBox();
            this.tbfullname = new System.Windows.Forms.TextBox();
            this.tbnumberofv = new System.Windows.Forms.TextBox();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btpervious = new System.Windows.Forms.Button();
            this.rbindividual = new System.Windows.Forms.RadioButton();
            this.rbgroup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Visitor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age Group :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date of Visit :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact Number :";
            // 
            // hel
            // 
            this.hel.AutoSize = true;
            this.hel.Location = new System.Drawing.Point(465, 228);
            this.hel.Name = "hel";
            this.hel.Size = new System.Drawing.Size(74, 16);
            this.hel.TabIndex = 0;
            this.hel.Text = "EntryTime :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Group :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Check IN";
            // 
            // ddagegroup
            // 
            this.ddagegroup.FormattingEnabled = true;
            this.ddagegroup.Items.AddRange(new object[] {
            "Group",
            "Child (5-12)",
            "Adult > 12"});
            this.ddagegroup.Location = new System.Drawing.Point(210, 275);
            this.ddagegroup.Name = "ddagegroup";
            this.ddagegroup.Size = new System.Drawing.Size(132, 24);
            this.ddagegroup.TabIndex = 2;
            this.ddagegroup.SelectedIndexChanged += new System.EventHandler(this.ddagegroup_SelectedIndexChanged);
            // 
            // ddgroup
            // 
            this.ddgroup.FormattingEnabled = true;
            this.ddgroup.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "15<"});
            this.ddgroup.Location = new System.Drawing.Point(601, 270);
            this.ddgroup.Name = "ddgroup";
            this.ddgroup.Size = new System.Drawing.Size(132, 24);
            this.ddgroup.TabIndex = 2;
            this.ddgroup.SelectedIndexChanged += new System.EventHandler(this.ddgroup_SelectedIndexChanged);
            // 
            // tbvisitorid
            // 
            this.tbvisitorid.Location = new System.Drawing.Point(210, 113);
            this.tbvisitorid.Name = "tbvisitorid";
            this.tbvisitorid.Size = new System.Drawing.Size(132, 22);
            this.tbvisitorid.TabIndex = 3;
            // 
            // tbfullname
            // 
            this.tbfullname.Location = new System.Drawing.Point(210, 162);
            this.tbfullname.Name = "tbfullname";
            this.tbfullname.Size = new System.Drawing.Size(132, 22);
            this.tbfullname.TabIndex = 3;
            // 
            // tbnumberofv
            // 
            this.tbnumberofv.Location = new System.Drawing.Point(210, 222);
            this.tbnumberofv.Name = "tbnumberofv";
            this.tbnumberofv.Size = new System.Drawing.Size(132, 22);
            this.tbnumberofv.TabIndex = 3;
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(601, 110);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(132, 22);
            this.tbdate.TabIndex = 3;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(601, 162);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(132, 22);
            this.tbcontact.TabIndex = 3;
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(601, 222);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(132, 22);
            this.tbtime.TabIndex = 3;
     
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(240, 357);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(102, 39);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btpervious
            // 
            this.btpervious.Location = new System.Drawing.Point(423, 357);
            this.btpervious.Name = "btpervious";
            this.btpervious.Size = new System.Drawing.Size(102, 39);
            this.btpervious.TabIndex = 4;
            this.btpervious.Text = "Pervious";
            this.btpervious.UseVisualStyleBackColor = true;
            this.btpervious.Click += new System.EventHandler(this.btpervious_Click);
            // 
            // rbindividual
            // 
            this.rbindividual.AutoSize = true;
            this.rbindividual.Location = new System.Drawing.Point(86, 40);
            this.rbindividual.Name = "rbindividual";
            this.rbindividual.Size = new System.Drawing.Size(85, 20);
            this.rbindividual.TabIndex = 5;
            this.rbindividual.TabStop = true;
            this.rbindividual.Text = "Individual";
            this.rbindividual.CheckedChanged += new System.EventHandler(this.rbindividual_CheckedChanged);
            // 
            // rbgroup
            // 
            this.rbgroup.AutoSize = true;
            this.rbgroup.Location = new System.Drawing.Point(86, 77);
            this.rbgroup.Name = "rbgroup";
            this.rbgroup.Size = new System.Drawing.Size(65, 20);
            this.rbgroup.TabIndex = 5;
            this.rbgroup.TabStop = true;
            this.rbgroup.Text = "Group";
            this.rbgroup.UseVisualStyleBackColor = true;
            this.rbgroup.CheckedChanged += new System.EventHandler(this.rbgroup_CheckedChanged);
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbgroup);
            this.Controls.Add(this.rbindividual);
            this.Controls.Add(this.btpervious);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.tbcontact);
            this.Controls.Add(this.tbdate);
            this.Controls.Add(this.tbnumberofv);
            this.Controls.Add(this.tbfullname);
            this.Controls.Add(this.tbvisitorid);
            this.Controls.Add(this.ddgroup);
            this.Controls.Add(this.ddagegroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Checkin";
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddagegroup;
        private System.Windows.Forms.ComboBox ddgroup;
        private System.Windows.Forms.TextBox tbvisitorid;
        private System.Windows.Forms.TextBox tbfullname;
        private System.Windows.Forms.TextBox tbnumberofv;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.TextBox tbcontact;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btpervious;
        private System.Windows.Forms.RadioButton rbindividual;
        private System.Windows.Forms.RadioButton rbgroup;
    }
}