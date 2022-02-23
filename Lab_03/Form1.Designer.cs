
namespace Lab_03
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Division = new System.Windows.Forms.Button();
            this.button_Pow = new System.Windows.Forms.Button();
            this.button_Log = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_1x = new System.Windows.Forms.Button();
            this.button_n = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(59, 120);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(47, 38);
            this.button_Plus.TabIndex = 0;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(59, 164);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(47, 38);
            this.button_Minus.TabIndex = 2;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(1, 20);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(107, 20);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 22);
            this.textBox_b.TabIndex = 5;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(59, 92);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 22);
            this.textBox_result.TabIndex = 6;
            // 
            // button_Multiply
            // 
            this.button_Multiply.Location = new System.Drawing.Point(59, 252);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(47, 38);
            this.button_Multiply.TabIndex = 7;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Division
            // 
            this.button_Division.Location = new System.Drawing.Point(59, 208);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(47, 38);
            this.button_Division.TabIndex = 8;
            this.button_Division.Text = "/";
            this.button_Division.UseVisualStyleBackColor = true;
            this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
            // 
            // button_Pow
            // 
            this.button_Pow.Location = new System.Drawing.Point(112, 120);
            this.button_Pow.Name = "button_Pow";
            this.button_Pow.Size = new System.Drawing.Size(47, 38);
            this.button_Pow.TabIndex = 9;
            this.button_Pow.Text = "x^y";
            this.button_Pow.UseVisualStyleBackColor = true;
            this.button_Pow.Click += new System.EventHandler(this.button_Pow_Click);
            // 
            // button_Log
            // 
            this.button_Log.Location = new System.Drawing.Point(112, 164);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(47, 38);
            this.button_Log.TabIndex = 10;
            this.button_Log.Text = "Log";
            this.button_Log.UseVisualStyleBackColor = true;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.Location = new System.Drawing.Point(112, 208);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(47, 38);
            this.button_Sqrt.TabIndex = 11;
            this.button_Sqrt.Text = "Sqrt";
            this.button_Sqrt.UseVisualStyleBackColor = true;
            this.button_Sqrt.Click += new System.EventHandler(this.button_Sqrt_Click);
            // 
            // button_1x
            // 
            this.button_1x.Location = new System.Drawing.Point(112, 252);
            this.button_1x.Name = "button_1x";
            this.button_1x.Size = new System.Drawing.Size(47, 38);
            this.button_1x.TabIndex = 12;
            this.button_1x.Text = "1/x";
            this.button_1x.UseVisualStyleBackColor = true;
            this.button_1x.Click += new System.EventHandler(this.button_1x_Click);
            // 
            // button_n
            // 
            this.button_n.Location = new System.Drawing.Point(165, 120);
            this.button_n.Name = "button_n";
            this.button_n.Size = new System.Drawing.Size(47, 38);
            this.button_n.TabIndex = 13;
            this.button_n.Text = "n!";
            this.button_n.UseVisualStyleBackColor = true;
            this.button_n.Click += new System.EventHandler(this.button_n_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 305);
            this.Controls.Add(this.button_n);
            this.Controls.Add(this.button_1x);
            this.Controls.Add(this.button_Sqrt);
            this.Controls.Add(this.button_Log);
            this.Controls.Add(this.button_Pow);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Plus);
            this.Name = "Form1";
            this.Text = "Calculator v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Division;
        private System.Windows.Forms.Button button_Pow;
        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_1x;
        private System.Windows.Forms.Button button_n;
    }
}

