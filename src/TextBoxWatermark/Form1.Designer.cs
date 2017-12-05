namespace TextBoxWatermark
{
    partial class Form1
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
            this.exTextBox3 = new TextBoxWatermark.ExTextBox();
            this.exTextBox4 = new TextBoxWatermark.ExTextBox();
            this.exTextBox2 = new TextBoxWatermark.ExTextBox();
            this.exTextBox1 = new TextBoxWatermark.ExTextBox();
            this.SuspendLayout();
            // 
            // exTextBox3
            // 
            this.exTextBox3.Hint = "Some Other Hint";
            this.exTextBox3.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exTextBox3.Location = new System.Drawing.Point(12, 76);
            this.exTextBox3.Name = "exTextBox3";
            this.exTextBox3.Size = new System.Drawing.Size(265, 26);
            this.exTextBox3.TabIndex = 0;
            // 
            // exTextBox4
            // 
            this.exTextBox4.Hint = "Some Other Hint";
            this.exTextBox4.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exTextBox4.Location = new System.Drawing.Point(12, 44);
            this.exTextBox4.Name = "exTextBox4";
            this.exTextBox4.Size = new System.Drawing.Size(265, 26);
            this.exTextBox4.TabIndex = 0;
            // 
            // exTextBox2
            // 
            this.exTextBox2.Hint = "Some Hint";
            this.exTextBox2.Location = new System.Drawing.Point(12, 12);
            this.exTextBox2.Name = "exTextBox2";
            this.exTextBox2.Size = new System.Drawing.Size(265, 26);
            this.exTextBox2.TabIndex = 0;
            // 
            // exTextBox1
            // 
            this.exTextBox1.Hint = "Another Hint";
            this.exTextBox1.Location = new System.Drawing.Point(12, 108);
            this.exTextBox1.Multiline = true;
            this.exTextBox1.Name = "exTextBox1";
            this.exTextBox1.Size = new System.Drawing.Size(265, 74);
            this.exTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 194);
            this.Controls.Add(this.exTextBox3);
            this.Controls.Add(this.exTextBox4);
            this.Controls.Add(this.exTextBox2);
            this.Controls.Add(this.exTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExTextBox exTextBox1;
        private ExTextBox exTextBox2;
        private ExTextBox exTextBox4;
        private ExTextBox exTextBox3;
    }
}

