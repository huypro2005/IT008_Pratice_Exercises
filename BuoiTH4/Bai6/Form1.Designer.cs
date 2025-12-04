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
            components = new System.ComponentModel.Container();
            progress = new ProgressBar();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            selectDistBtn = new Button();
            selectSourceBtn = new Button();
            copyBtn = new Button();
            distBox = new TextBox();
            label2 = new Label();
            sourceBox = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            labelProgress = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progress.Location = new Point(55, 44);
            progress.Name = "progress";
            progress.Size = new Size(552, 29);
            progress.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(progress);
            groupBox1.Location = new Point(79, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 101);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tiến Trình Sao Chép";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(selectDistBtn);
            groupBox2.Controls.Add(selectSourceBtn);
            groupBox2.Controls.Add(copyBtn);
            groupBox2.Controls.Add(distBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(sourceBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(79, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sao Chép Tập Tin";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // selectDistBtn
            // 
            selectDistBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectDistBtn.Location = new Point(592, 115);
            selectDistBtn.Name = "selectDistBtn";
            selectDistBtn.Size = new Size(37, 24);
            selectDistBtn.TabIndex = 6;
            selectDistBtn.Text = "...";
            selectDistBtn.UseVisualStyleBackColor = true;
            selectDistBtn.Click += selectDistBtn_Click;
            // 
            // selectSourceBtn
            // 
            selectSourceBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectSourceBtn.Location = new Point(592, 41);
            selectSourceBtn.Name = "selectSourceBtn";
            selectSourceBtn.Size = new Size(37, 24);
            selectSourceBtn.TabIndex = 5;
            selectSourceBtn.Text = "...";
            selectSourceBtn.UseVisualStyleBackColor = true;
            selectSourceBtn.Click += selectSourceBtn_Click;
            // 
            // copyBtn
            // 
            copyBtn.Location = new Point(272, 180);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(94, 29);
            copyBtn.TabIndex = 4;
            copyBtn.Text = "Sao Chép";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // distBox
            // 
            distBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            distBox.Location = new Point(246, 115);
            distBox.Name = "distBox";
            distBox.ReadOnly = true;
            distBox.Size = new Size(340, 27);
            distBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 122);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 2;
            label2.Text = "Đường dẫn thư mục đích";
            // 
            // sourceBox
            // 
            sourceBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sourceBox.Location = new Point(246, 40);
            sourceBox.Name = "sourceBox";
            sourceBox.ReadOnly = true;
            sourceBox.Size = new Size(340, 27);
            sourceBox.TabIndex = 1;
            sourceBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // labelProgress
            // 
            labelProgress.Dock = DockStyle.Bottom;
            labelProgress.Location = new Point(0, 420);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(800, 30);
            labelProgress.TabIndex = 3;
            labelProgress.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelProgress);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progress;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox sourceBox;
        private Label label1;
        private ToolTip toolTip1;
        private TextBox distBox;
        private Label label2;
        private Button selectDistBtn;
        private Button selectSourceBtn;
        private Button copyBtn;
        private Label labelProgress;
    }
}
