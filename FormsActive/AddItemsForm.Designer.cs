namespace FormsActive
{
    partial class AddItemsForm
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
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelWarnningName = new System.Windows.Forms.Panel();
            this.panelWarnningMark = new System.Windows.Forms.Panel();
            this.panelWarnningPoints = new System.Windows.Forms.Panel();
            this.panelWarnningYear = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "&Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "&Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 40;
            this.label5.Text = "&Semester";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(293, 30);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(261, 44);
            this.textBoxCourseName.TabIndex = 1;
            this.textBoxCourseName.Enter += new System.EventHandler(this.resetColorToBlackText);
            this.textBoxCourseName.Leave += new System.EventHandler(this.textBoxCourseName_Leave);
            // 
            // textBoxMark
            // 
            this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMark.Location = new System.Drawing.Point(293, 84);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(135, 44);
            this.textBoxMark.TabIndex = 11;
            this.textBoxMark.Enter += new System.EventHandler(this.resetColorToBlackText);
            this.textBoxMark.Leave += new System.EventHandler(this.textBoxMark_Leave);
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoints.Location = new System.Drawing.Point(293, 139);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(135, 44);
            this.textBoxPoints.TabIndex = 21;
            this.textBoxPoints.Enter += new System.EventHandler(this.resetColorToBlackText);
            this.textBoxPoints.Leave += new System.EventHandler(this.textBoxPoints_Leave);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(293, 194);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(135, 44);
            this.textBoxYear.TabIndex = 31;
            this.textBoxYear.Enter += new System.EventHandler(this.resetColorToBlackText);
            this.textBoxYear.Leave += new System.EventHandler(this.textBoxYear_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(62, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 53);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(293, 251);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 41);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(383, 251);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 41);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(472, 251);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 41);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panelWarnningName
            // 
            this.panelWarnningName.BackColor = System.Drawing.Color.Transparent;
            this.panelWarnningName.ForeColor = System.Drawing.Color.Black;
            this.panelWarnningName.Location = new System.Drawing.Point(22, 31);
            this.panelWarnningName.Name = "panelWarnningName";
            this.panelWarnningName.Size = new System.Drawing.Size(15, 40);
            this.panelWarnningName.TabIndex = 26;
            // 
            // panelWarnningMark
            // 
            this.panelWarnningMark.BackColor = System.Drawing.Color.Transparent;
            this.panelWarnningMark.Location = new System.Drawing.Point(22, 86);
            this.panelWarnningMark.Name = "panelWarnningMark";
            this.panelWarnningMark.Size = new System.Drawing.Size(15, 40);
            this.panelWarnningMark.TabIndex = 27;
            // 
            // panelWarnningPoints
            // 
            this.panelWarnningPoints.BackColor = System.Drawing.Color.Transparent;
            this.panelWarnningPoints.Location = new System.Drawing.Point(22, 141);
            this.panelWarnningPoints.Name = "panelWarnningPoints";
            this.panelWarnningPoints.Size = new System.Drawing.Size(15, 40);
            this.panelWarnningPoints.TabIndex = 27;
            // 
            // panelWarnningYear
            // 
            this.panelWarnningYear.BackColor = System.Drawing.Color.Transparent;
            this.panelWarnningYear.Location = new System.Drawing.Point(22, 196);
            this.panelWarnningYear.Name = "panelWarnningYear";
            this.panelWarnningYear.Size = new System.Drawing.Size(15, 40);
            this.panelWarnningYear.TabIndex = 27;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(260, 323);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 53);
            this.buttonExit.TabIndex = 51;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 404);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelWarnningYear);
            this.Controls.Add(this.panelWarnningPoints);
            this.Controls.Add(this.panelWarnningMark);
            this.Controls.Add(this.panelWarnningName);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(525, 445);
            this.Name = "AddItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Courses";
            this.Deactivate += new System.EventHandler(this.AddItemsForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panelWarnningName;
        private System.Windows.Forms.Panel panelWarnningMark;
        private System.Windows.Forms.Panel panelWarnningPoints;
        private System.Windows.Forms.Panel panelWarnningYear;
        private System.Windows.Forms.Button buttonExit;
    }
}