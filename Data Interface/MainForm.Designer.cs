namespace Data_Interface
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewButton = new System.Windows.Forms.Button();
            this.avrgMarkLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageHiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListView
            // 
            this.dataListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.dataListView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataListView.FullRowSelect = true;
            this.dataListView.GridLines = true;
            this.dataListView.Location = new System.Drawing.Point(28, 172);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(721, 814);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            //this.dataListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.dataListView_AfterLabelEdit);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mark";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Points";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Semester";
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(591, 65);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(129, 57);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // avrgMarkLabel
            // 
            this.avrgMarkLabel.AutoSize = true;
            this.avrgMarkLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avrgMarkLabel.Location = new System.Drawing.Point(21, 51);
            this.avrgMarkLabel.Name = "avrgMarkLabel";
            this.avrgMarkLabel.Size = new System.Drawing.Size(250, 38);
            this.avrgMarkLabel.TabIndex = 3;
            this.avrgMarkLabel.Text = "Average mark  :";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markLabel.Location = new System.Drawing.Point(277, 51);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(98, 38);
            this.markLabel.TabIndex = 4;
            this.markLabel.Text = "00.00";
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(446, 65);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(129, 57);
            this.statisticsButton.TabIndex = 5;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageHiToolStripMenuItem,
            this.changeMarkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 76);
            // 
            // messageHiToolStripMenuItem
            // 
            this.messageHiToolStripMenuItem.Name = "messageHiToolStripMenuItem";
            this.messageHiToolStripMenuItem.Size = new System.Drawing.Size(300, 36);
            this.messageHiToolStripMenuItem.Text = "Remove course";
            this.messageHiToolStripMenuItem.Click += new System.EventHandler(this.messageHiToolStripMenuItem_Click);
            // 
            // changeMarkToolStripMenuItem
            // 
            this.changeMarkToolStripMenuItem.Name = "changeMarkToolStripMenuItem";
            this.changeMarkToolStripMenuItem.Size = new System.Drawing.Size(300, 36);
            this.changeMarkToolStripMenuItem.Text = "Change mark";
            this.changeMarkToolStripMenuItem.Click += new System.EventHandler(this.changeMarkToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 1008);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.avrgMarkLabel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.dataListView);
            this.MinimumSize = new System.Drawing.Size(792, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label avrgMarkLabel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messageHiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMarkToolStripMenuItem;
    }
}