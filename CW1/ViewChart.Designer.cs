namespace CW1
{
    partial class ViewChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartvisitors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbvisitors = new System.Windows.Forms.RadioButton();
            this.rbearnig = new System.Windows.Forms.RadioButton();
            this.btpervious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartearning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartvisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartearning)).BeginInit();
            this.SuspendLayout();
            // 
            // chartvisitors
            // 
            chartArea1.Name = "ChartArea1";
            this.chartvisitors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartvisitors.Legends.Add(legend1);
            this.chartvisitors.Location = new System.Drawing.Point(241, 85);
            this.chartvisitors.Name = "chartvisitors";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Visitor";
            this.chartvisitors.Series.Add(series1);
            this.chartvisitors.Size = new System.Drawing.Size(447, 347);
            this.chartvisitors.TabIndex = 0;
            this.chartvisitors.Text = "chart1";
            // 
            // rbvisitors
            // 
            this.rbvisitors.AutoSize = true;
            this.rbvisitors.Location = new System.Drawing.Point(94, 139);
            this.rbvisitors.Name = "rbvisitors";
            this.rbvisitors.Size = new System.Drawing.Size(110, 20);
            this.rbvisitors.TabIndex = 1;
            this.rbvisitors.TabStop = true;
            this.rbvisitors.Text = "No. of Visitors";
            this.rbvisitors.UseVisualStyleBackColor = true;
            this.rbvisitors.CheckedChanged += new System.EventHandler(this.rbvisitors_CheckedChanged);
            // 
            // rbearnig
            // 
            this.rbearnig.AutoSize = true;
            this.rbearnig.Location = new System.Drawing.Point(94, 201);
            this.rbearnig.Name = "rbearnig";
            this.rbearnig.Size = new System.Drawing.Size(108, 20);
            this.rbearnig.TabIndex = 2;
            this.rbearnig.TabStop = true;
            this.rbearnig.Text = "Total Earning";
            this.rbearnig.UseVisualStyleBackColor = true;
            this.rbearnig.CheckedChanged += new System.EventHandler(this.rbearnig_CheckedChanged);
            // 
            // btpervious
            // 
            this.btpervious.Location = new System.Drawing.Point(94, 285);
            this.btpervious.Name = "btpervious";
            this.btpervious.Size = new System.Drawing.Size(108, 33);
            this.btpervious.TabIndex = 3;
            this.btpervious.Text = "Pervious";
            this.btpervious.UseVisualStyleBackColor = true;
            this.btpervious.Click += new System.EventHandler(this.btpervious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Chart";
            // 
            // chartearning
            // 
            chartArea2.Name = "ChartArea1";
            this.chartearning.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartearning.Legends.Add(legend2);
            this.chartearning.Location = new System.Drawing.Point(241, 85);
            this.chartearning.Name = "chartearning";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Earning";
            this.chartearning.Series.Add(series2);
            this.chartearning.Size = new System.Drawing.Size(447, 347);
            this.chartearning.TabIndex = 5;
            this.chartearning.Text = "chart1";
            // 
            // ViewChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 526);
            this.Controls.Add(this.chartearning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btpervious);
            this.Controls.Add(this.rbearnig);
            this.Controls.Add(this.rbvisitors);
            this.Controls.Add(this.chartvisitors);
            this.Name = "ViewChart";
            this.Text = "ViewChart";
            ((System.ComponentModel.ISupportInitialize)(this.chartvisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartearning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartvisitors;
        private System.Windows.Forms.RadioButton rbvisitors;
        private System.Windows.Forms.RadioButton rbearnig;
        private System.Windows.Forms.Button btpervious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartearning;
    }
}