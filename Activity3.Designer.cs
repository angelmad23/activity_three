namespace WindowsFormsApplication1
{
    partial class otherTextbox
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Survey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Japan";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Survey
            // 
            this.Survey.AutoSize = true;
            this.Survey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey.Location = new System.Drawing.Point(122, 52);
            this.Survey.Name = "Survey";
            this.Survey.Size = new System.Drawing.Size(85, 25);
            this.Survey.TabIndex = 1;
            this.Survey.Text = "Survey";
            this.Survey.Click += new System.EventHandler(this.Survey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "What county would you like to visit?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(306, 183);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Paris";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(306, 243);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "U.S.A";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(127, 243);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Dubai";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.Location = new System.Drawing.Point(109, 294);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(209, 20);
            this.othersLabel.TabIndex = 6;
            this.othersLabel.Text = "IF others please Specify.";
            this.othersLabel.Visible = false;
            this.othersLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // othersTextBox
            // 
            this.othersTextBox.Location = new System.Drawing.Point(113, 326);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(205, 20);
            this.othersTextBox.TabIndex = 7;
            this.othersTextBox.Visible = false;
            this.othersTextBox.TextChanged += new System.EventHandler(this.othersTextBox_TextChanged);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(306, 366);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 23);
            this.Select.TabIndex = 8;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(418, 243);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Others";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // otherTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.othersTextBox);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Survey);
            this.Controls.Add(this.checkBox1);
            this.Name = "otherTextbox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.otherTextbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Survey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

