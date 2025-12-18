namespace Bai11
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
            panelControl = new Panel();
            groupBox3 = new GroupBox();
            radioLinear = new RadioButton();
            radioTextureBrush = new RadioButton();
            radioHashBrush = new RadioButton();
            radioSolidBrush = new RadioButton();
            groupBox2 = new GroupBox();
            btnColor = new Button();
            textWidth = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioElipse = new RadioButton();
            radioRectangle = new RadioButton();
            radioLine = new RadioButton();
            panelDrawing = new Panel();
            panelControl.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Controls.Add(groupBox3);
            panelControl.Controls.Add(groupBox2);
            panelControl.Controls.Add(groupBox1);
            panelControl.Location = new Point(3, 1);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(250, 550);
            panelControl.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioLinear);
            groupBox3.Controls.Add(radioTextureBrush);
            groupBox3.Controls.Add(radioHashBrush);
            groupBox3.Controls.Add(radioSolidBrush);
            groupBox3.Location = new Point(0, 276);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 271);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Brushes";
            // 
            // radioLinear
            // 
            radioLinear.AutoSize = true;
            radioLinear.Location = new Point(13, 203);
            radioLinear.Name = "radioLinear";
            radioLinear.Size = new Size(163, 24);
            radioLinear.TabIndex = 3;
            radioLinear.TabStop = true;
            radioLinear.Text = "LinearGradientBrush";
            radioLinear.UseVisualStyleBackColor = true;
            radioLinear.CheckedChanged += radioLinear_CheckedChanged;
            // 
            // radioTextureBrush
            // 
            radioTextureBrush.AutoSize = true;
            radioTextureBrush.Location = new Point(13, 149);
            radioTextureBrush.Name = "radioTextureBrush";
            radioTextureBrush.Size = new Size(149, 24);
            radioTextureBrush.TabIndex = 2;
            radioTextureBrush.TabStop = true;
            radioTextureBrush.Text = "radioTextureBrush";
            radioTextureBrush.UseVisualStyleBackColor = true;
            radioTextureBrush.CheckedChanged += radioTextureBrush_CheckedChanged;
            // 
            // radioHashBrush
            // 
            radioHashBrush.AutoSize = true;
            radioHashBrush.Location = new Point(13, 96);
            radioHashBrush.Name = "radioHashBrush";
            radioHashBrush.Size = new Size(99, 24);
            radioHashBrush.TabIndex = 1;
            radioHashBrush.TabStop = true;
            radioHashBrush.Text = "HashBrush";
            radioHashBrush.UseVisualStyleBackColor = true;
            radioHashBrush.CheckedChanged += radioHashBrush_CheckedChanged;
            // 
            // radioSolidBrush
            // 
            radioSolidBrush.AutoSize = true;
            radioSolidBrush.Location = new Point(13, 42);
            radioSolidBrush.Name = "radioSolidBrush";
            radioSolidBrush.Size = new Size(100, 24);
            radioSolidBrush.TabIndex = 0;
            radioSolidBrush.TabStop = true;
            radioSolidBrush.Text = "SolidBrush";
            radioSolidBrush.UseVisualStyleBackColor = true;
            radioSolidBrush.CheckedChanged += radioSolidBrush_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnColor);
            groupBox2.Controls.Add(textWidth);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(0, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pen";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(58, 78);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(94, 29);
            btnColor.TabIndex = 2;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // textWidth
            // 
            textWidth.Location = new Point(78, 36);
            textWidth.Name = "textWidth";
            textWidth.Size = new Size(125, 27);
            textWidth.TabIndex = 1;
            textWidth.TextChanged += textWidth_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioElipse);
            groupBox1.Controls.Add(radioRectangle);
            groupBox1.Controls.Add(radioLine);
            groupBox1.Location = new Point(0, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shape";
            // 
            // radioElipse
            // 
            radioElipse.AutoSize = true;
            radioElipse.Location = new Point(9, 86);
            radioElipse.Name = "radioElipse";
            radioElipse.Size = new Size(69, 24);
            radioElipse.TabIndex = 2;
            radioElipse.TabStop = true;
            radioElipse.Text = "Elipse";
            radioElipse.UseVisualStyleBackColor = true;
            radioElipse.CheckedChanged += radioElipse_CheckedChanged;
            // 
            // radioRectangle
            // 
            radioRectangle.AutoSize = true;
            radioRectangle.Location = new Point(9, 56);
            radioRectangle.Name = "radioRectangle";
            radioRectangle.Size = new Size(96, 24);
            radioRectangle.TabIndex = 1;
            radioRectangle.TabStop = true;
            radioRectangle.Text = "Rectangle";
            radioRectangle.UseVisualStyleBackColor = true;
            radioRectangle.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioLine
            // 
            radioLine.AutoSize = true;
            radioLine.Location = new Point(9, 26);
            radioLine.Name = "radioLine";
            radioLine.Size = new Size(57, 24);
            radioLine.TabIndex = 0;
            radioLine.TabStop = true;
            radioLine.Text = "Line";
            radioLine.UseVisualStyleBackColor = true;
            radioLine.CheckedChanged += radioLine_CheckedChanged;
            // 
            // panelDrawing
            // 
            panelDrawing.Location = new Point(259, 1);
            panelDrawing.Name = "panelDrawing";
            panelDrawing.Size = new Size(586, 550);
            panelDrawing.TabIndex = 1;
            panelDrawing.SizeChanged += panelDrawing_SizeChanged;
            panelDrawing.Paint += panelDrawing_Paint;
            panelDrawing.MouseDown += panelDrawing_MouseDown;
            panelDrawing.MouseMove += panelDrawing_MouseMove;
            panelDrawing.MouseUp += panelDrawing_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 554);
            Controls.Add(panelDrawing);
            Controls.Add(panelControl);
            Name = "Form1";
            Text = "Form1";
            panelControl.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private GroupBox groupBox1;
        private Panel panelDrawing;
        private RadioButton radioElipse;
        private RadioButton radioRectangle;
        private RadioButton radioLine;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnColor;
        private TextBox textWidth;
        private Label label1;
        private RadioButton radioLinear;
        private RadioButton radioTextureBrush;
        private RadioButton radioHashBrush;
        private RadioButton radioSolidBrush;
    }
}
