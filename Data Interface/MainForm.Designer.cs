﻿namespace Data_Interface
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
            this.dataListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.saveChangesCheckBox = new System.Windows.Forms.CheckBox();
            this.avrgMarkLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
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
            this.dataListView.FullRowSelect = true;
            this.dataListView.GridLines = true;
            this.dataListView.Location = new System.Drawing.Point(28, 172);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(721, 814);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveChangesCheckBox
            // 
            this.saveChangesCheckBox.AutoSize = true;
            this.saveChangesCheckBox.Location = new System.Drawing.Point(28, 124);
            this.saveChangesCheckBox.Name = "saveChangesCheckBox";
            this.saveChangesCheckBox.Size = new System.Drawing.Size(181, 29);
            this.saveChangesCheckBox.TabIndex = 2;
            this.saveChangesCheckBox.Text = "Save changes";
            this.saveChangesCheckBox.UseVisualStyleBackColor = true;
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
            this.markLabel.Size = new System.Drawing.Size(53, 38);
            this.markLabel.TabIndex = 4;
            this.markLabel.Text = "00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 1008);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.avrgMarkLabel);
            this.Controls.Add(this.saveChangesCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListView);
            this.MinimumSize = new System.Drawing.Size(792, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox saveChangesCheckBox;
        private System.Windows.Forms.Label avrgMarkLabel;
        private System.Windows.Forms.Label markLabel;
    }
}