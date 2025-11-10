namespace Bai5
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
            label1 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            label2 = new Label();
            answer = new TextBox();
            label3 = new Label();
            sum = new Button();
            mul = new Button();
            sub = new Button();
            div = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // num1
            // 
            num1.Location = new Point(359, 80);
            num1.Name = "num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(359, 191);
            num2.Name = "num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 198);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // answer
            // 
            answer.Location = new Point(359, 372);
            answer.Name = "answer";
            answer.Size = new Size(125, 27);
            answer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 379);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Answer";
            // 
            // sum
            // 
            sum.Location = new Point(129, 283);
            sum.Name = "sum";
            sum.Size = new Size(94, 29);
            sum.TabIndex = 6;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // mul
            // 
            mul.Location = new Point(390, 283);
            mul.Name = "mul";
            mul.Size = new Size(94, 29);
            mul.TabIndex = 7;
            mul.Text = "x";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // sub
            // 
            sub.Location = new Point(260, 283);
            sub.Name = "sub";
            sub.Size = new Size(94, 29);
            sub.TabIndex = 8;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // div
            // 
            div.Location = new Point(515, 283);
            div.Name = "div";
            div.Size = new Size(94, 29);
            div.TabIndex = 9;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(div);
            Controls.Add(sub);
            Controls.Add(mul);
            Controls.Add(sum);
            Controls.Add(answer);
            Controls.Add(label3);
            Controls.Add(num2);
            Controls.Add(label2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private TextBox num2;
        private Label label2;
        private TextBox answer;
        private Label label3;
        private Button sum;
        private Button mul;
        private Button sub;
        private Button div;
    }
}
