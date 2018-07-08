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
            this.SuspendLayout();
            // 
            // avgsListView
            // 
            this.avgsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Year,
            this.AverageMark});
            this.avgsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgsListView.Location = new System.Drawing.Point(0, 0);
            this.avgsListView.Name = "avgsListView";
            this.avgsListView.Size = new System.Drawing.Size(415, 428);
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
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 428);
            this.Controls.Add(this.avgsListView);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView avgsListView;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader AverageMark;
    }
}