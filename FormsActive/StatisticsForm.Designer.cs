﻿namespace FormsActive
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelFreePointsChoose = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBest = new System.Windows.Forms.Label();
            this.labelSecoundBest = new System.Windows.Forms.Label();
            this.buttonMulitiCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // avgsListView
            // 
            this.avgsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Year,
            this.AverageMark});
            this.avgsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgsListView.Location = new System.Drawing.Point(0, 0);
            this.avgsListView.Name = "avgsListView";
            this.avgsListView.Size = new System.Drawing.Size(402, 502);
            this.avgsListView.TabIndex = 1;
            this.avgsListView.UseCompatibleStateImageBehavior = false;
            this.avgsListView.View = System.Windows.Forms.View.Details;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 70;
            // 
            // AverageMark
            // 
            this.AverageMark.Text = "Average Mark";
            this.AverageMark.Width = 125;
            // 
            // ThreePointsLabel
            // 
            this.ThreePointsLabel.AutoSize = true;
            this.ThreePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreePointsLabel.Location = new System.Drawing.Point(421, 185);
            this.ThreePointsLabel.Name = "ThreePointsLabel";
            this.ThreePointsLabel.Size = new System.Drawing.Size(195, 37);
            this.ThreePointsLabel.TabIndex = 2;
            this.ThreePointsLabel.Text = "Three points";
            // 
            // fourPointsLabel
            // 
            this.fourPointsLabel.AutoSize = true;
            this.fourPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourPointsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fourPointsLabel.Location = new System.Drawing.Point(421, 223);
            this.fourPointsLabel.Name = "fourPointsLabel";
            this.fourPointsLabel.Size = new System.Drawing.Size(179, 37);
            this.fourPointsLabel.TabIndex = 3;
            this.fourPointsLabel.Text = "Four points";
            // 
            // fivePointsLabel
            // 
            this.fivePointsLabel.AutoSize = true;
            this.fivePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivePointsLabel.Location = new System.Drawing.Point(421, 261);
            this.fivePointsLabel.Name = "fivePointsLabel";
            this.fivePointsLabel.Size = new System.Drawing.Size(171, 37);
            this.fivePointsLabel.TabIndex = 4;
            this.fivePointsLabel.Text = "Five points";
            // 
            // points3Label
            // 
            this.points3Label.AutoSize = true;
            this.points3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points3Label.Location = new System.Drawing.Point(653, 185);
            this.points3Label.Name = "points3Label";
            this.points3Label.Size = new System.Drawing.Size(53, 37);
            this.points3Label.TabIndex = 5;
            this.points3Label.Text = "00";
            // 
            // points4Label
            // 
            this.points4Label.AutoSize = true;
            this.points4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points4Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.points4Label.Location = new System.Drawing.Point(653, 223);
            this.points4Label.Name = "points4Label";
            this.points4Label.Size = new System.Drawing.Size(53, 37);
            this.points4Label.TabIndex = 6;
            this.points4Label.Text = "00";
            // 
            // points5Label
            // 
            this.points5Label.AutoSize = true;
            this.points5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points5Label.Location = new System.Drawing.Point(653, 261);
            this.points5Label.Name = "points5Label";
            this.points5Label.Size = new System.Drawing.Size(53, 37);
            this.points5Label.TabIndex = 7;
            this.points5Label.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mark needed for Avg";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(655, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(136, 44);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(780, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wanted Avrg";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(432, 368);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(122, 44);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Visible = false;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelFreePointsChoose
            // 
            this.labelFreePointsChoose.AutoSize = true;
            this.labelFreePointsChoose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFreePointsChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreePointsChoose.ForeColor = System.Drawing.Color.White;
            this.labelFreePointsChoose.Location = new System.Drawing.Point(648, 372);
            this.labelFreePointsChoose.Name = "labelFreePointsChoose";
            this.labelFreePointsChoose.Size = new System.Drawing.Size(53, 37);
            this.labelFreePointsChoose.TabIndex = 13;
            this.labelFreePointsChoose.Text = "00";
            this.labelFreePointsChoose.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(426, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(290, 41);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Free Style Points";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Best course to improve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Secound Best course to improve:";
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBest.Location = new System.Drawing.Point(519, 538);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(184, 37);
            this.labelBest.TabIndex = 17;
            this.labelBest.Text = "Not avilable";
            // 
            // labelSecoundBest
            // 
            this.labelSecoundBest.AutoSize = true;
            this.labelSecoundBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecoundBest.Location = new System.Drawing.Point(519, 592);
            this.labelSecoundBest.Name = "labelSecoundBest";
            this.labelSecoundBest.Size = new System.Drawing.Size(184, 37);
            this.labelSecoundBest.TabIndex = 18;
            this.labelSecoundBest.Text = "Not avilable";
            // 
            // buttonMulitiCourse
            // 
            this.buttonMulitiCourse.Enabled = false;
            this.buttonMulitiCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulitiCourse.Location = new System.Drawing.Point(426, 442);
            this.buttonMulitiCourse.Name = "buttonMulitiCourse";
            this.buttonMulitiCourse.Size = new System.Drawing.Size(251, 60);
            this.buttonMulitiCourse.TabIndex = 19;
            this.buttonMulitiCourse.Text = "Multi Courses";
            this.buttonMulitiCourse.UseVisualStyleBackColor = true;
            this.buttonMulitiCourse.Visible = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 651);
            this.Controls.Add(this.buttonMulitiCourse);
            this.Controls.Add(this.labelSecoundBest);
            this.Controls.Add(this.labelBest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelFreePointsChoose);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.points5Label);
            this.Controls.Add(this.points4Label);
            this.Controls.Add(this.points3Label);
            this.Controls.Add(this.fivePointsLabel);
            this.Controls.Add(this.fourPointsLabel);
            this.Controls.Add(this.ThreePointsLabel);
            this.Controls.Add(this.avgsListView);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 490);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelFreePointsChoose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBest;
        private System.Windows.Forms.Label labelSecoundBest;
        private System.Windows.Forms.Button buttonMulitiCourse;
    }
}