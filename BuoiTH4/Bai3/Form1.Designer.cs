namespace Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            labelStatus = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            WINPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WINPlayer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(832, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(224, 26);
            fileToolStripMenuItem1.Text = "Open";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelStatus, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 508);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(832, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(151, 20);
            labelStatus.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // WINPlayer
            // 
            WINPlayer.Dock = DockStyle.Fill;
            WINPlayer.Enabled = true;
            WINPlayer.Location = new Point(0, 28);
            WINPlayer.Name = "WINPlayer";
            WINPlayer.OcxState = (AxHost.State)resources.GetObject("WINPlayer.OcxState");
            WINPlayer.Size = new Size(832, 480);
            WINPlayer.TabIndex = 3;
            WINPlayer.Enter += WINPlayer_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 534);
            Controls.Add(WINPlayer);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WINPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelStatus;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer WINPlayer;
    }
}
