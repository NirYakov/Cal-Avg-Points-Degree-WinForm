namespace FormsActive
{
    partial class FormChangeMark
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
            this.numericUpDownMarkToChange = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelAverageChange = new System.Windows.Forms.Label();
            this.labelChangeMark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkToChange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change course mark in  :\r\n";
            // 
            // numericUpDownMarkToChange
            // 
            this.numericUpDownMarkToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMarkToChange.Location = new System.Drawing.Point(19, 98);
            this.numericUpDownMarkToChange.Name = "numericUpDownMarkToChange";
            this.numericUpDownMarkToChange.Size = new System.Drawing.Size(102, 44);
            this.numericUpDownMarkToChange.TabIndex = 1;
            this.numericUpDownMarkToChange.ValueChanged += new System.EventHandler(this.numericUpDownMarkToChange_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(571, 98);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 51);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(433, 25);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(209, 37);
            this.labelCourseName.TabIndex = 3;
            this.labelCourseName.Text = "Course name";
            // 
            // labelAverageChange
            // 
            this.labelAverageChange.AutoSize = true;
            this.labelAverageChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageChange.Location = new System.Drawing.Point(150, 98);
            this.labelAverageChange.Name = "labelAverageChange";
            this.labelAverageChange.Size = new System.Drawing.Size(267, 37);
            this.labelAverageChange.TabIndex = 4;
            this.labelAverageChange.Text = "Average change :";
            // 
            // labelChangeMark
            // 
            this.labelChangeMark.AutoSize = true;
            this.labelChangeMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeMark.Location = new System.Drawing.Point(424, 98);
            this.labelChangeMark.Name = "labelChangeMark";
            this.labelChangeMark.Size = new System.Drawing.Size(53, 37);
            this.labelChangeMark.TabIndex = 5;
            this.labelChangeMark.Text = "00";
            // 
            // FormChangeMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(707, 166);
            this.Controls.Add(this.labelChangeMark);
            this.Controls.Add(this.labelAverageChange);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownMarkToChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 195);
            this.Name = "FormChangeMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Mark";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkToChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMarkToChange;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelAverageChange;
        private System.Windows.Forms.Label labelChangeMark;
    }
}