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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            NewFileMenu = new ToolStripMenuItem();
            openFIleMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveFileMenu = new ToolStripMenuItem();
            ExitMenu = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripNewFile = new ToolStripButton();
            toolStripSave = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cmbFont = new ToolStripComboBox();
            cmbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnNghieng = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripProgressBar1 = new ToolStripProgressBar();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFileMenu, openFIleMenu, toolStripSeparator1, SaveFileMenu, ExitMenu });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // NewFileMenu
            // 
            NewFileMenu.Image = (Image)resources.GetObject("NewFileMenu.Image");
            NewFileMenu.Name = "NewFileMenu";
            NewFileMenu.ShortcutKeys = Keys.Control | Keys.N;
            NewFileMenu.Size = new Size(285, 26);
            NewFileMenu.Text = "Tạo văn bản mới";
            NewFileMenu.Click += NewFileMenu_Click_1;
            // 
            // openFIleMenu
            // 
            openFIleMenu.Image = (Image)resources.GetObject("openFIleMenu.Image");
            openFIleMenu.Name = "openFIleMenu";
            openFIleMenu.ShortcutKeys = Keys.Control | Keys.O;
            openFIleMenu.Size = new Size(285, 26);
            openFIleMenu.Text = "Mở tập tin";
            openFIleMenu.Click += OpenFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(282, 6);
            // 
            // SaveFileMenu
            // 
            SaveFileMenu.Image = (Image)resources.GetObject("SaveFileMenu.Image");
            SaveFileMenu.Name = "SaveFileMenu";
            SaveFileMenu.ShortcutKeys = Keys.Control | Keys.S;
            SaveFileMenu.Size = new Size(285, 26);
            SaveFileMenu.Text = "Lưu nội dung văn bản";
            SaveFileMenu.Click += SaveFileMenu_Click;
            // 
            // ExitMenu
            // 
            ExitMenu.Name = "ExitMenu";
            ExitMenu.Size = new Size(285, 26);
            ExitMenu.Text = "Thoát";
            ExitMenu.Click += ExitMenu_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(92, 24);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNewFile, toolStripSave, toolStripSeparator2, cmbFont, cmbSize, btnBold, btnNghieng, btnUnderline, toolStripSeparator3, toolStripProgressBar1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewFile
            // 
            toolStripNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripNewFile.Image = (Image)resources.GetObject("toolStripNewFile.Image");
            toolStripNewFile.ImageTransparentColor = Color.Magenta;
            toolStripNewFile.Name = "toolStripNewFile";
            toolStripNewFile.Size = new Size(29, 25);
            toolStripNewFile.Text = "toolStripButton1";
            toolStripNewFile.Click += toolStripNewFile_Click;
            // 
            // toolStripSave
            // 
            toolStripSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSave.Image = (Image)resources.GetObject("toolStripSave.Image");
            toolStripSave.ImageTransparentColor = Color.Magenta;
            toolStripSave.Name = "toolStripSave";
            toolStripSave.Size = new Size(29, 25);
            toolStripSave.Text = "toolStripButton1";
            toolStripSave.Click += toolStripSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // cmbFont
            // 
            cmbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFont.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 28);
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // cmbSize
            // 
            cmbSize.Items.AddRange(new object[] { "8, 10, 12, 14, 16" });
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 28);
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.CheckOnClick = true;
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Text = "B";
            btnBold.Click += btnBold_Click;
            // 
            // btnNghieng
            // 
            btnNghieng.CheckOnClick = true;
            btnNghieng.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNghieng.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNghieng.Image = (Image)resources.GetObject("btnNghieng.Image");
            btnNghieng.ImageTransparentColor = Color.Magenta;
            btnNghieng.Name = "btnNghieng";
            btnNghieng.Size = new Size(29, 25);
            btnNghieng.Text = "I";
            btnNghieng.Click += btnNghieng_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.CheckOnClick = true;
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUnderline.DoubleClickEnabled = true;
            btnUnderline.Font = new Font("Segoe UI Light", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 25);
            btnUnderline.Text = "U";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 25);
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 394);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem NewFileMenu;
        private ToolStripMenuItem openFIleMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SaveFileMenu;
        private ToolStripMenuItem ExitMenu;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNewFile;
        private ToolStripButton toolStripSave;
        private ToolStripSeparator toolStripSeparator2;
        private RichTextBox richTextBox1;
        private ToolStripComboBox cmbFont;
        private ToolStripComboBox cmbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnNghieng;
        private ToolStripButton btnUnderline;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
