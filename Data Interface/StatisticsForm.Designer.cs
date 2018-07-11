namespace Data_Interface
{
    partial class StatisticsForm
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
            this.avgsListView = new System.Windows.Forms.ListView();
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AverageMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreePointsLabel = new System.Windows.Forms.Label();
            this.fourPointsLabel = new System.Windows.Forms.Label();
            this.fivePointsLabel = new System.Windows.Forms.Label();
            this.points3Label = new System.Windows.Forms.Label();
            this.points4Label = new System.Windows.Forms.Label();
            this.points5Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // avgsListView
            // 
            this.avgsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Year,
            this.AverageMark});
            this.avgsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.avgsListView.Location = new System.Drawing.Point(0, 0);
            this.avgsListView.Name = "avgsListView";
            this.avgsListView.Size = new System.Drawing.Size(274, 419);
            this.avgsListView.TabIndex = 1;
            this.avgsListView.UseCompatibleStateImageBehavior = false;
            this.avgsListView.View = System.Windows.Forms.View.Details;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // AverageMark
            // 
            this.AverageMark.Text = "Average Mark";
            // 
            // ThreePointsLabel
            // 
            this.ThreePointsLabel.AutoSize = true;
            this.ThreePointsLabel.Location = new System.Drawing.Point(280, 185);
            this.ThreePointsLabel.Name = "ThreePointsLabel";
            this.ThreePointsLabel.Size = new System.Drawing.Size(132, 25);
            this.ThreePointsLabel.TabIndex = 2;
            this.ThreePointsLabel.Text = "Three points";
            // 
            // fourPointsLabel
            // 
            this.fourPointsLabel.AutoSize = true;
            this.fourPointsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fourPointsLabel.Location = new System.Drawing.Point(280, 223);
            this.fourPointsLabel.Name = "fourPointsLabel";
            this.fourPointsLabel.Size = new System.Drawing.Size(120, 25);
            this.fourPointsLabel.TabIndex = 3;
            this.fourPointsLabel.Text = "Four points";
            // 
            // fivePointsLabel
            // 
            this.fivePointsLabel.AutoSize = true;
            this.fivePointsLabel.Location = new System.Drawing.Point(280, 261);
            this.fivePointsLabel.Name = "fivePointsLabel";
            this.fivePointsLabel.Size = new System.Drawing.Size(117, 25);
            this.fivePointsLabel.TabIndex = 4;
            this.fivePointsLabel.Text = "Five points";
            // 
            // points3Label
            // 
            this.points3Label.AutoSize = true;
            this.points3Label.Location = new System.Drawing.Point(462, 185);
            this.points3Label.Name = "points3Label";
            this.points3Label.Size = new System.Drawing.Size(36, 25);
            this.points3Label.TabIndex = 5;
            this.points3Label.Text = "00";
            // 
            // points4Label
            // 
            this.points4Label.AutoSize = true;
            this.points4Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.points4Label.Location = new System.Drawing.Point(462, 223);
            this.points4Label.Name = "points4Label";
            this.points4Label.Size = new System.Drawing.Size(36, 25);
            this.points4Label.TabIndex = 6;
            this.points4Label.Text = "00";
            // 
            // points5Label
            // 
            this.points5Label.AutoSize = true;
            this.points5Label.Location = new System.Drawing.Point(462, 261);
            this.points5Label.Name = "points5Label";
            this.points5Label.Size = new System.Drawing.Size(36, 25);
            this.points5Label.TabIndex = 7;
            this.points5Label.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mark needed for Avg";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(398, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 419);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.points5Label);
            this.Controls.Add(this.points4Label);
            this.Controls.Add(this.points3Label);
            this.Controls.Add(this.fivePointsLabel);
            this.Controls.Add(this.fourPointsLabel);
            this.Controls.Add(this.ThreePointsLabel);
            this.Controls.Add(this.avgsListView);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView avgsListView;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader AverageMark;
        private System.Windows.Forms.Label ThreePointsLabel;
        private System.Windows.Forms.Label fourPointsLabel;
        private System.Windows.Forms.Label fivePointsLabel;
        private System.Windows.Forms.Label points3Label;
        private System.Windows.Forms.Label points4Label;
        private System.Windows.Forms.Label points5Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}