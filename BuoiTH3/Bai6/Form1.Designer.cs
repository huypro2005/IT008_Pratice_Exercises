using System.Drawing.Drawing2D;

namespace Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            textBox = new TextBox();
            button1 = new Button();
            btnC = new Button();
            btnBackS = new Button();
            btnCE = new Button();
            btnNum9 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            BtnMC = new Button();
            btnNum6 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnMulti = new Button();
            btnMod = new Button();
            btnMR = new Button();
            btnNum3 = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnSub = new Button();
            btnDividedBy1 = new Button();
            btnMS = new Button();
            btnPoint = new Button();
            btnNum0 = new Button();
            BtnSwitch = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btnMPlus = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(440, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 24);
            fileToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // textBox
            // 
            textBox.Location = new Point(49, 84);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(342, 27);
            textBox.TabIndex = 1;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(49, 171);
            button1.Name = "button1";
            button1.Size = new Size(52, 47);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(303, 171);
            btnC.Name = "btnC";
            btnC.Size = new Size(88, 47);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnBackS
            // 
            btnBackS.Location = new Point(107, 171);
            btnBackS.Name = "btnBackS";
            btnBackS.Size = new Size(91, 47);
            btnBackS.TabIndex = 6;
            btnBackS.Text = "Backspace";
            btnBackS.UseVisualStyleBackColor = true;
            btnBackS.Click += btnBackS_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(204, 171);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(93, 47);
            btnCE.TabIndex = 7;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(223, 224);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(52, 47);
            btnNum9.TabIndex = 13;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(107, 224);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(52, 47);
            btnNum7.TabIndex = 12;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(165, 224);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(52, 47);
            btnNum8.TabIndex = 11;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(281, 224);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(52, 47);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(339, 224);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(52, 47);
            btnSqrt.TabIndex = 9;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // BtnMC
            // 
            BtnMC.Location = new Point(49, 224);
            BtnMC.Name = "BtnMC";
            BtnMC.Size = new Size(52, 47);
            BtnMC.TabIndex = 8;
            BtnMC.Text = "MC";
            BtnMC.UseVisualStyleBackColor = true;
            BtnMC.Click += BtnMC_Click;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(223, 277);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(52, 47);
            btnNum6.TabIndex = 19;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(107, 277);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(52, 47);
            btnNum4.TabIndex = 18;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(165, 277);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(52, 47);
            btnNum5.TabIndex = 17;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(281, 277);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(52, 47);
            btnMulti.TabIndex = 16;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(339, 277);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(52, 47);
            btnMod.TabIndex = 15;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(49, 277);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(52, 47);
            btnMR.TabIndex = 14;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(223, 330);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(52, 47);
            btnNum3.TabIndex = 25;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(107, 330);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(52, 47);
            btnNum1.TabIndex = 24;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(165, 330);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(52, 47);
            btnNum2.TabIndex = 23;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(281, 330);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(52, 47);
            btnSub.TabIndex = 22;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDividedBy1
            // 
            btnDividedBy1.Location = new Point(339, 330);
            btnDividedBy1.Name = "btnDividedBy1";
            btnDividedBy1.Size = new Size(52, 47);
            btnDividedBy1.TabIndex = 21;
            btnDividedBy1.Text = "1/x";
            btnDividedBy1.UseVisualStyleBackColor = true;
            btnDividedBy1.Click += btnDividedBy1_Click;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(49, 330);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(52, 47);
            btnMS.TabIndex = 20;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(223, 383);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(52, 47);
            btnPoint.TabIndex = 31;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(107, 383);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(52, 47);
            btnNum0.TabIndex = 30;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // BtnSwitch
            // 
            BtnSwitch.Location = new Point(165, 383);
            BtnSwitch.Name = "BtnSwitch";
            BtnSwitch.Size = new Size(52, 47);
            BtnSwitch.TabIndex = 29;
            BtnSwitch.Text = "+/-";
            BtnSwitch.UseVisualStyleBackColor = true;
            BtnSwitch.Click += BtnSwitch_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(281, 383);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(52, 47);
            btnPlus.TabIndex = 28;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(339, 383);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(52, 47);
            btnEqual.TabIndex = 27;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.Location = new Point(49, 383);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(52, 47);
            btnMPlus.TabIndex = 26;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = true;
            btnMPlus.Click += btnMPlus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(440, 466);
            Controls.Add(btnPoint);
            Controls.Add(btnNum0);
            Controls.Add(BtnSwitch);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(btnMPlus);
            Controls.Add(btnNum3);
            Controls.Add(btnNum1);
            Controls.Add(btnNum2);
            Controls.Add(btnSub);
            Controls.Add(btnDividedBy1);
            Controls.Add(btnMS);
            Controls.Add(btnNum6);
            Controls.Add(btnNum4);
            Controls.Add(btnNum5);
            Controls.Add(btnMulti);
            Controls.Add(btnMod);
            Controls.Add(btnMR);
            Controls.Add(btnNum9);
            Controls.Add(btnNum7);
            Controls.Add(btnNum8);
            Controls.Add(btnDivide);
            Controls.Add(btnSqrt);
            Controls.Add(BtnMC);
            Controls.Add(btnCE);
            Controls.Add(btnBackS);
            Controls.Add(btnC);
            Controls.Add(button1);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            Cursor = Cursors.SizeNESW;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSwitch_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox textBox1;
        private Button button1;
        private Button btnC;
        private Button btnBackS;
        private Button btnCE;
        private Button BtnMC;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnMR;
        private Button btnNum3;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnMS;
        private Button btnNum0;
        private Button btnMPlus;
        private TextBox textBox;
        private Button btnNum9;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnNum6;
        private Button btnMulti;
        private Button btnMod;
        private Button btnSub;
        private Button btnDividedBy1;
        private Button btnPoint;
        private Button BtnSwitch;
        private Button btnPlus;
        private Button btnEqual;
        private double temp = 0;
        private int previous = 0;
        /*
         * 0: plus
         * 1: sub
         * 2: multi
         * 3: divide
         * 4: mod
         */
    }
}
