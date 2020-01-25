namespace Back2Basics3
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commodore64HicolorModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commodore64HiresModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.nintendoEntertainmentSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.nECPC8801ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betterTileFittingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pboOriginal = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pboResized = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pboIndexed = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pboTiled = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pboBordered = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboOriginal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboResized)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIndexed)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboTiled)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboBordered)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(904, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commodore64HicolorModeToolStripMenuItem,
            this.commodore64HiresModeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.nintendoEntertainmentSystemToolStripMenuItem,
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.nECPC8801ToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "&Process";
            // 
            // commodore64HicolorModeToolStripMenuItem
            // 
            this.commodore64HicolorModeToolStripMenuItem.Name = "commodore64HicolorModeToolStripMenuItem";
            this.commodore64HicolorModeToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.commodore64HicolorModeToolStripMenuItem.Text = "Commodore 64 (Hi-color mode)";
            this.commodore64HicolorModeToolStripMenuItem.Click += new System.EventHandler(this.commodore64HicolorModeToolStripMenuItem_Click);
            // 
            // commodore64HiresModeToolStripMenuItem
            // 
            this.commodore64HiresModeToolStripMenuItem.Name = "commodore64HiresModeToolStripMenuItem";
            this.commodore64HiresModeToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.commodore64HiresModeToolStripMenuItem.Text = "Commodore 64 (Hi-res mode)";
            this.commodore64HiresModeToolStripMenuItem.Click += new System.EventHandler(this.commodore64HiresModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 6);
            // 
            // nintendoEntertainmentSystemToolStripMenuItem
            // 
            this.nintendoEntertainmentSystemToolStripMenuItem.Name = "nintendoEntertainmentSystemToolStripMenuItem";
            this.nintendoEntertainmentSystemToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.nintendoEntertainmentSystemToolStripMenuItem.Text = "Nintendo Entertainment System";
            this.nintendoEntertainmentSystemToolStripMenuItem.Click += new System.EventHandler(this.nintendoEntertainmentSystemToolStripMenuItem_Click);
            // 
            // nintendoEntertainmentSystemMMC5ToolStripMenuItem
            // 
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem.Name = "nintendoEntertainmentSystemMMC5ToolStripMenuItem";
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem.Text = "Nintendo Entertainment System (MMC5)";
            this.nintendoEntertainmentSystemMMC5ToolStripMenuItem.Click += new System.EventHandler(this.nintendoEntertainmentSystemMMC5ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(287, 6);
            // 
            // nECPC8801ToolStripMenuItem
            // 
            this.nECPC8801ToolStripMenuItem.Name = "nECPC8801ToolStripMenuItem";
            this.nECPC8801ToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.nECPC8801ToolStripMenuItem.Text = "NEC PC-8801";
            this.nECPC8801ToolStripMenuItem.Click += new System.EventHandler(this.nECPC8801ToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betterTileFittingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // betterTileFittingToolStripMenuItem
            // 
            this.betterTileFittingToolStripMenuItem.Checked = true;
            this.betterTileFittingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.betterTileFittingToolStripMenuItem.Name = "betterTileFittingToolStripMenuItem";
            this.betterTileFittingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.betterTileFittingToolStripMenuItem.Text = "Better tile fitting";
            this.betterTileFittingToolStripMenuItem.Click += new System.EventHandler(this.betterTileFittingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstProgress,
            this.tstStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstProgress
            // 
            this.tstProgress.Name = "tstProgress";
            this.tstProgress.Size = new System.Drawing.Size(300, 16);
            // 
            // tstStatus
            // 
            this.tstStatus.Name = "tstStatus";
            this.tstStatus.Size = new System.Drawing.Size(121, 17);
            this.tstStatus.Text = "Please load an image.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 486);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pboOriginal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Original";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pboOriginal
            // 
            this.pboOriginal.Location = new System.Drawing.Point(3, 3);
            this.pboOriginal.Name = "pboOriginal";
            this.pboOriginal.Size = new System.Drawing.Size(866, 454);
            this.pboOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboOriginal.TabIndex = 0;
            this.pboOriginal.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pboResized);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resized";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pboResized
            // 
            this.pboResized.Location = new System.Drawing.Point(3, 3);
            this.pboResized.Name = "pboResized";
            this.pboResized.Size = new System.Drawing.Size(866, 454);
            this.pboResized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboResized.TabIndex = 0;
            this.pboResized.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pboIndexed);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(872, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color reduced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pboIndexed
            // 
            this.pboIndexed.Location = new System.Drawing.Point(3, 3);
            this.pboIndexed.Name = "pboIndexed";
            this.pboIndexed.Size = new System.Drawing.Size(866, 454);
            this.pboIndexed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboIndexed.TabIndex = 0;
            this.pboIndexed.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pboTiled);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(872, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tile-fitted";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pboTiled
            // 
            this.pboTiled.Location = new System.Drawing.Point(3, 3);
            this.pboTiled.Name = "pboTiled";
            this.pboTiled.Size = new System.Drawing.Size(866, 454);
            this.pboTiled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboTiled.TabIndex = 0;
            this.pboTiled.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pboBordered);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(872, 460);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Bordered";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pboBordered
            // 
            this.pboBordered.Location = new System.Drawing.Point(3, 3);
            this.pboBordered.Name = "pboBordered";
            this.pboBordered.Size = new System.Drawing.Size(866, 454);
            this.pboBordered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboBordered.TabIndex = 0;
            this.pboBordered.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(872, 460);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Image info";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Back2Basics3 v1.0";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboOriginal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboResized)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboIndexed)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboTiled)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboBordered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tstProgress;
        private System.Windows.Forms.ToolStripStatusLabel tstStatus;
        private System.Windows.Forms.ToolStripMenuItem commodore64HicolorModeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pboOriginal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pboResized;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pboIndexed;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pboTiled;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pboBordered;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripMenuItem commodore64HiresModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nintendoEntertainmentSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nintendoEntertainmentSystemMMC5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem nECPC8801ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betterTileFittingToolStripMenuItem;
    }
}