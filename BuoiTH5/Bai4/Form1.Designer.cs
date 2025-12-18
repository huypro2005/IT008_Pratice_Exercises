namespace Bai4
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
            fontBox = new ComboBox();
            sizeBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            colorBtn = new Button();
            checkBold = new CheckBox();
            checkU = new CheckBox();
            checkI = new CheckBox();
            radioLeft = new RadioButton();
            radioRight = new RadioButton();
            radioCenter = new RadioButton();
            groupBox1 = new GroupBox();
            textShow = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // fontBox
            // 
            fontBox.FormattingEnabled = true;
            fontBox.Location = new Point(146, 66);
            fontBox.Name = "fontBox";
            fontBox.Size = new Size(151, 28);
            fontBox.TabIndex = 1;
            // 
            // sizeBox
            // 
            sizeBox.FormattingEnabled = true;
            sizeBox.Location = new Point(606, 66);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(151, 28);
            sizeBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 69);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 127);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Color";
            // 
            // colorBtn
            // 
            colorBtn.BackColor = Color.Red;
            colorBtn.Location = new Point(606, 123);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(28, 24);
            colorBtn.TabIndex = 5;
            colorBtn.UseVisualStyleBackColor = false;
            colorBtn.Click += button1_Click;
            // 
            // checkBold
            // 
            checkBold.AutoSize = true;
            checkBold.Location = new Point(62, 124);
            checkBold.Name = "checkBold";
            checkBold.Size = new Size(40, 24);
            checkBold.TabIndex = 6;
            checkBold.Text = "B";
            checkBold.UseVisualStyleBackColor = true;
            checkBold.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkU
            // 
            checkU.AutoSize = true;
            checkU.Location = new Point(194, 123);
            checkU.Name = "checkU";
            checkU.Size = new Size(41, 24);
            checkU.TabIndex = 7;
            checkU.Text = "U";
            checkU.UseVisualStyleBackColor = true;
            // 
            // checkI
            // 
            checkI.AutoSize = true;
            checkI.Location = new Point(127, 124);
            checkI.Name = "checkI";
            checkI.Size = new Size(35, 24);
            checkI.TabIndex = 8;
            checkI.Text = "I";
            checkI.UseVisualStyleBackColor = true;
            // 
            // radioLeft
            // 
            radioLeft.AutoSize = true;
            radioLeft.Location = new Point(30, 26);
            radioLeft.Name = "radioLeft";
            radioLeft.Size = new Size(55, 24);
            radioLeft.TabIndex = 10;
            radioLeft.TabStop = true;
            radioLeft.Text = "Left";
            radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            radioRight.AutoSize = true;
            radioRight.Location = new Point(30, 111);
            radioRight.Name = "radioRight";
            radioRight.Size = new Size(65, 24);
            radioRight.TabIndex = 11;
            radioRight.TabStop = true;
            radioRight.Text = "Right";
            radioRight.UseVisualStyleBackColor = true;
            radioRight.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioCenter
            // 
            radioCenter.AutoSize = true;
            radioCenter.Location = new Point(30, 70);
            radioCenter.Name = "radioCenter";
            radioCenter.Size = new Size(73, 24);
            radioCenter.TabIndex = 12;
            radioCenter.TabStop = true;
            radioCenter.Text = "Center";
            radioCenter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioLeft);
            groupBox1.Controls.Add(radioRight);
            groupBox1.Controls.Add(radioCenter);
            groupBox1.Location = new Point(62, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 160);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align Text";
            // 
            // textShow
            // 
            textShow.Location = new Point(514, 285);
            textShow.Name = "textShow";
            textShow.Size = new Size(200, 80);
            textShow.TabIndex = 15;
            textShow.Text = "Hello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textShow);
            Controls.Add(groupBox1);
            Controls.Add(checkI);
            Controls.Add(checkU);
            Controls.Add(checkBold);
            Controls.Add(colorBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sizeBox);
            Controls.Add(fontBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox fontBox;
        private ComboBox sizeBox;
        private Label label2;
        private Label label3;
        private Button colorBtn;
        private CheckBox checkBold;
        private CheckBox checkU;
        private CheckBox checkI;
        private RadioButton radioLeft;
        private RadioButton radioRight;
        private RadioButton radioCenter;
        private GroupBox groupBox1;
        private Label textShow;
    }
}
