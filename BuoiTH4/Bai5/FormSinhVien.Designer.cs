namespace Bai5
{
    partial class FormSinhVien
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
            label1 = new Label();
            txtMaso = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxDepartment = new ComboBox();
            AvgScore = new NumericUpDown();
            btnAddNew = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)AvgScore).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 87);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            label1.Click += label1_Click;
            // 
            // txtMaso
            // 
            txtMaso.Location = new Point(352, 84);
            txtMaso.Name = "txtMaso";
            txtMaso.Size = new Size(275, 27);
            txtMaso.TabIndex = 1;
            txtMaso.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(352, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 154);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 218);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 287);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Điểm TB";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(352, 215);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(361, 28);
            comboBoxDepartment.TabIndex = 8;
            // 
            // AvgScore
            // 
            AvgScore.DecimalPlaces = 2;
            AvgScore.Location = new Point(352, 285);
            AvgScore.Name = "AvgScore";
            AvgScore.Size = new Size(150, 27);
            AvgScore.TabIndex = 9;
            AvgScore.Value = new decimal(new int[] { 75, 0, 0, 65536 });
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Lime;
            btnAddNew.Location = new Point(619, 379);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 10;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(476, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAddNew);
            Controls.Add(AvgScore);
            Controls.Add(comboBoxDepartment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtMaso);
            Controls.Add(label1);
            Name = "FormSinhVien";
            Text = "FormSinhVien";
            Load += FormSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)AvgScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaso;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDepartment;
        private NumericUpDown AvgScore;
        private Button btnAddNew;
        private Button btnExit;
    }
}