namespace FormsActive
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageHiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPotensialValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewButton = new System.Windows.Forms.Button();
            this.avrgMarkLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelTotalPoints = new System.Windows.Forms.Label();
            this.checkBoxSortCol = new System.Windows.Forms.CheckBox();
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
            this.dataListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListView.FullRowSelect = true;
            this.dataListView.GridLines = true;
            this.dataListView.Location = new System.Drawing.Point(28, 172);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(994, 770);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            this.dataListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.dataListView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Name";
            this.columnHeader1.Width = 200;
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
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Semester";
            this.columnHeader5.Width = 85;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageHiToolStripMenuItem,
            this.changeMarkToolStripMenuItem,
            this.showPotensialValueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(316, 112);
            // 
            // messageHiToolStripMenuItem
            // 
            this.messageHiToolStripMenuItem.Name = "messageHiToolStripMenuItem";
            this.messageHiToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.messageHiToolStripMenuItem.Text = "Remove course";
            this.messageHiToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // changeMarkToolStripMenuItem
            // 
            this.changeMarkToolStripMenuItem.Name = "changeMarkToolStripMenuItem";
            this.changeMarkToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.changeMarkToolStripMenuItem.Text = "Change mark";
            this.changeMarkToolStripMenuItem.Click += new System.EventHandler(this.changeMarkToolStripMenuItem_Click);
            // 
            // showPotensialValueToolStripMenuItem
            // 
            this.showPotensialValueToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.showPotensialValueToolStripMenuItem.Name = "showPotensialValueToolStripMenuItem";
            this.showPotensialValueToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.showPotensialValueToolStripMenuItem.Text = "Show Potensial Value";
            this.showPotensialValueToolStripMenuItem.Click += new System.EventHandler(this.showPotensialValueToolStripMenuItem_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(846, 75);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(176, 68);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // avrgMarkLabel
            // 
            this.avrgMarkLabel.AutoSize = true;
            this.avrgMarkLabel.Font = new System.Drawing.Font("Cooper Black", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avrgMarkLabel.Location = new System.Drawing.Point(21, 31);
            this.avrgMarkLabel.Name = "avrgMarkLabel";
            this.avrgMarkLabel.Size = new System.Drawing.Size(316, 42);
            this.avrgMarkLabel.TabIndex = 3;
            this.avrgMarkLabel.Text = "Average mark  :";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Cooper Black", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markLabel.Location = new System.Drawing.Point(347, 31);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(117, 42);
            this.markLabel.TabIndex = 4;
            this.markLabel.Text = "00.00";
            // 
            // statisticsButton
            // 
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Location = new System.Drawing.Point(644, 75);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(181, 68);
            this.statisticsButton.TabIndex = 5;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(469, 106);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(106, 37);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "Points";
            // 
            // labelTotalPoints
            // 
            this.labelTotalPoints.AutoSize = true;
            this.labelTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPoints.Location = new System.Drawing.Point(356, 106);
            this.labelTotalPoints.Name = "labelTotalPoints";
            this.labelTotalPoints.Size = new System.Drawing.Size(98, 37);
            this.labelTotalPoints.TabIndex = 11;
            this.labelTotalPoints.Text = "00.00";
            // 
            // checkBoxSortCol
            // 
            this.checkBoxSortCol.AutoSize = true;
            this.checkBoxSortCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSortCol.Location = new System.Drawing.Point(65, 111);
            this.checkBoxSortCol.Name = "checkBoxSortCol";
            this.checkBoxSortCol.Size = new System.Drawing.Size(165, 41);
            this.checkBoxSortCol.TabIndex = 12;
            this.checkBoxSortCol.Text = "Sort Col";
            this.checkBoxSortCol.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 1487);
            this.Controls.Add(this.checkBoxSortCol);
            this.Controls.Add(this.labelTotalPoints);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.avrgMarkLabel);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.dataListView);
            this.MinimumSize = new System.Drawing.Size(1075, 1550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source";
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
        private System.Windows.Forms.ToolStripMenuItem showPotensialValueToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelTotalPoints;
        private System.Windows.Forms.CheckBox checkBoxSortCol;
    }
}