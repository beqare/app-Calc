namespace Rechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            num1 = new Button();
            num3 = new Button();
            num2 = new Button();
            num5 = new Button();
            num6 = new Button();
            num4 = new Button();
            num8 = new Button();
            num9 = new Button();
            num7 = new Button();
            minus = new Button();
            multiply = new Button();
            plus = new Button();
            clear = new Button();
            result = new Button();
            divide = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 0;
            // 
            // num1
            // 
            num1.Location = new Point(12, 193);
            num1.Name = "num1";
            num1.Size = new Size(113, 70);
            num1.TabIndex = 8;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num3
            // 
            num3.Location = new Point(259, 193);
            num3.Name = "num3";
            num3.Size = new Size(113, 70);
            num3.TabIndex = 9;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            // 
            // num2
            // 
            num2.Location = new Point(136, 193);
            num2.Name = "num2";
            num2.Size = new Size(113, 70);
            num2.TabIndex = 10;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            // 
            // num5
            // 
            num5.Location = new Point(136, 117);
            num5.Name = "num5";
            num5.Size = new Size(113, 70);
            num5.TabIndex = 13;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            // 
            // num6
            // 
            num6.Location = new Point(259, 117);
            num6.Name = "num6";
            num6.Size = new Size(113, 70);
            num6.TabIndex = 12;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            // 
            // num4
            // 
            num4.Location = new Point(12, 117);
            num4.Name = "num4";
            num4.Size = new Size(113, 70);
            num4.TabIndex = 11;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            // 
            // num8
            // 
            num8.Location = new Point(136, 41);
            num8.Name = "num8";
            num8.Size = new Size(113, 70);
            num8.TabIndex = 16;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            // 
            // num9
            // 
            num9.Location = new Point(259, 41);
            num9.Name = "num9";
            num9.Size = new Size(113, 70);
            num9.TabIndex = 15;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            // 
            // num7
            // 
            num7.Location = new Point(12, 41);
            num7.Name = "num7";
            num7.Size = new Size(113, 70);
            num7.TabIndex = 14;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Location = new Point(136, 269);
            minus.Name = "minus";
            minus.Size = new Size(113, 70);
            minus.TabIndex = 19;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Location = new Point(259, 269);
            multiply.Name = "multiply";
            multiply.Size = new Size(113, 70);
            multiply.TabIndex = 18;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            plus.Location = new Point(12, 269);
            plus.Name = "plus";
            plus.Size = new Size(113, 70);
            plus.TabIndex = 17;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            clear.Location = new Point(136, 345);
            clear.Name = "clear";
            clear.Size = new Size(113, 70);
            clear.TabIndex = 22;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.Location = new Point(259, 345);
            result.Name = "result";
            result.Size = new Size(113, 70);
            result.TabIndex = 21;
            result.Text = "=";
            result.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(12, 345);
            divide.Name = "divide";
            divide.Size = new Size(113, 70);
            divide.TabIndex = 20;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(384, 429);
            Controls.Add(clear);
            Controls.Add(result);
            Controls.Add(divide);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(plus);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(num7);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num4);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rechner";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button num1;
        private Button num3;
        private Button num2;
        private Button num5;
        private Button num6;
        private Button num4;
        private Button num8;
        private Button num9;
        private Button num7;
        private Button minus;
        private Button multiply;
        private Button plus;
        private Button clear;
        private Button result;
        private Button divide;
    }
}
