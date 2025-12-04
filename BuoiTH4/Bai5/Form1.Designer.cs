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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripBtnAddMem = new ToolStripButton();
            toolStripAddMem = new ToolStripLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripLabelFindMem = new ToolStripLabel();
            toolStripTxtFIndMem = new ToolStripTextBox();
            dgvDanhSach = new DataGridView();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddNewToolStripMenuItem, ExitToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(159, 26);
            AddNewToolStripMenuItem.Text = "Thêm mới";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(159, 26);
            ExitToolStripMenuItem.Text = "Thoát";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnAddMem, toolStripAddMem, toolStripProgressBar1, toolStripLabelFindMem, toolStripTxtFIndMem });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 57);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAddMem
            // 
            toolStripBtnAddMem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnAddMem.Image = (Image)resources.GetObject("toolStripBtnAddMem.Image");
            toolStripBtnAddMem.ImageTransparentColor = Color.Magenta;
            toolStripBtnAddMem.Name = "toolStripBtnAddMem";
            toolStripBtnAddMem.Size = new Size(54, 54);
            toolStripBtnAddMem.Text = "toolStripButton1";
            toolStripBtnAddMem.Click += toolStripBtnAddMem_Click;
            // 
            // toolStripAddMem
            // 
            toolStripAddMem.Name = "toolStripAddMem";
            toolStripAddMem.Size = new Size(76, 54);
            toolStripAddMem.Text = "Thêm Mới";
            toolStripAddMem.Click += toolStripAddMem_Click;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 54);
            // 
            // toolStripLabelFindMem
            // 
            toolStripLabelFindMem.Name = "toolStripLabelFindMem";
            toolStripLabelFindMem.Size = new Size(136, 54);
            toolStripLabelFindMem.Text = "Tìm Kiếm Theo Tên";
            // 
            // toolStripTxtFIndMem
            // 
            toolStripTxtFIndMem.Name = "toolStripTxtFIndMem";
            toolStripTxtFIndMem.Size = new Size(150, 57);
            toolStripTxtFIndMem.Click += toolStripTxtFIndMem_Click;
            toolStripTxtFIndMem.TextChanged += toolStripTxtFIndMem_TextChanged;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(0, 85);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.Size = new Size(800, 365);
            dgvDanhSach.TabIndex = 2;
            dgvDanhSach.CellContentClick += dgvDanhSach_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDanhSach);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnAddMem;
        private ToolStripLabel toolStripAddMem;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripLabel toolStripLabelFindMem;
        private ToolStripTextBox toolStripTxtFIndMem;
        private DataGridView dgvDanhSach;
    }
}
