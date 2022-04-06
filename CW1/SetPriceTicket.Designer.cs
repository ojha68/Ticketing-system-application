namespace CW1
{
    partial class SetPriceTicket
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
            this.tb1hrprice = new System.Windows.Forms.TextBox();
            this.tb2hrprice = new System.Windows.Forms.TextBox();
            this.tb3hrprice = new System.Windows.Forms.TextBox();
            this.tb4hrprice = new System.Windows.Forms.TextBox();
            this.tbunlimitedprice = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btset = new System.Windows.Forms.Button();
            this.perviousbt = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btcleardata = new System.Windows.Forms.Button();
            this.btshowprice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1hrprice
            // 
            this.tb1hrprice.Location = new System.Drawing.Point(146, 125);
            this.tb1hrprice.Name = "tb1hrprice";
            this.tb1hrprice.Size = new System.Drawing.Size(137, 22);
            this.tb1hrprice.TabIndex = 10;
            // 
            // tb2hrprice
            // 
            this.tb2hrprice.Location = new System.Drawing.Point(146, 164);
            this.tb2hrprice.Name = "tb2hrprice";
            this.tb2hrprice.Size = new System.Drawing.Size(137, 22);
            this.tb2hrprice.TabIndex = 10;
            // 
            // tb3hrprice
            // 
            this.tb3hrprice.Location = new System.Drawing.Point(146, 192);
            this.tb3hrprice.Name = "tb3hrprice";
            this.tb3hrprice.Size = new System.Drawing.Size(137, 22);
            this.tb3hrprice.TabIndex = 10;
            // 
            // tb4hrprice
            // 
            this.tb4hrprice.Location = new System.Drawing.Point(146, 220);
            this.tb4hrprice.Name = "tb4hrprice";
            this.tb4hrprice.Size = new System.Drawing.Size(137, 22);
            this.tb4hrprice.TabIndex = 10;
            // 
            // tbunlimitedprice
            // 
            this.tbunlimitedprice.Location = new System.Drawing.Point(146, 260);
            this.tbunlimitedprice.Name = "tbunlimitedprice";
            this.tbunlimitedprice.Size = new System.Drawing.Size(137, 22);
            this.tbunlimitedprice.TabIndex = 10;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(23, 83);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(62, 16);
            this.Category.TabIndex = 11;
            this.Category.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "1Hr Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "2Hr Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "3Hr Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "4Hr Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unlimited";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Set Price Ticket";
            // 
            // btset
            // 
            this.btset.Location = new System.Drawing.Point(519, 316);
            this.btset.Name = "btset";
            this.btset.Size = new System.Drawing.Size(75, 23);
            this.btset.TabIndex = 12;
            this.btset.Text = "Set Price";
            this.btset.UseVisualStyleBackColor = true;
            this.btset.Click += new System.EventHandler(this.btset_Click);
            // 
            // perviousbt
            // 
            this.perviousbt.Location = new System.Drawing.Point(434, 373);
            this.perviousbt.Name = "perviousbt";
            this.perviousbt.Size = new System.Drawing.Size(75, 23);
            this.perviousbt.TabIndex = 14;
            this.perviousbt.Text = "pervious ";
            this.perviousbt.UseVisualStyleBackColor = true;
            this.perviousbt.Click += new System.EventHandler(this.perviousbt_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(422, 38);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(335, 269);
            this.DGV.TabIndex = 15;
            // 
            // btcleardata
            // 
            this.btcleardata.Location = new System.Drawing.Point(606, 373);
            this.btcleardata.Name = "btcleardata";
            this.btcleardata.Size = new System.Drawing.Size(117, 23);
            this.btcleardata.TabIndex = 14;
            this.btcleardata.Text = "Clear Data";
            this.btcleardata.UseVisualStyleBackColor = true;
            this.btcleardata.Click += new System.EventHandler(this.btcleardata_Click);
            // 
            // btshowprice
            // 
            this.btshowprice.Location = new System.Drawing.Point(51, 316);
            this.btshowprice.Name = "btshowprice";
            this.btshowprice.Size = new System.Drawing.Size(174, 23);
            this.btshowprice.TabIndex = 13;
            this.btshowprice.Text = "Show The Ticket Price";
            this.btshowprice.UseVisualStyleBackColor = true;
            this.btshowprice.Click += new System.EventHandler(this.btshowprice_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-338, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "pervious ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Child (5-12)",
            "Adult >12",
            "Group 5",
            "Group 10",
            "Group 15",
            "Group greater than 15"});
            this.cbCategory.Location = new System.Drawing.Point(165, 74);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 16;
            // 
            // SetPriceTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btcleardata);
            this.Controls.Add(this.btshowprice);
            this.Controls.Add(this.perviousbt);
            this.Controls.Add(this.btset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.tbunlimitedprice);
            this.Controls.Add(this.tb4hrprice);
            this.Controls.Add(this.tb3hrprice);
            this.Controls.Add(this.tb2hrprice);
            this.Controls.Add(this.tb1hrprice);
            this.Name = "SetPriceTicket";
            this.Text = "SetPriceTicket";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb1hrprice;
        private System.Windows.Forms.TextBox tb2hrprice;
        private System.Windows.Forms.TextBox tb3hrprice;
        private System.Windows.Forms.TextBox tb4hrprice;
        private System.Windows.Forms.TextBox tbunlimitedprice;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btset;
        private System.Windows.Forms.Button perviousbt;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btcleardata;
        private System.Windows.Forms.Button btshowprice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}