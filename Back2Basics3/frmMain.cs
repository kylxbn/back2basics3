using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Back2Basics3.Classes;

namespace Back2Basics3
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
            if (!String.IsNullOrWhiteSpace(dlgOpen.FileName))
            {
                pboOriginal.Image = Bitmap.FromFile(dlgOpen.FileName);
            }
            tstStatus.Text = "Ready.";
        }

        private void commodore64HicolorModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processToolStripMenuItem.Enabled = false;
            C64 comp = new C64();
            bgw.RunWorkerAsync(comp);
        }

        private void commodore64HiresModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processToolStripMenuItem.Enabled = false;
            C64HiRes comp = new C64HiRes();
            bgw.RunWorkerAsync(comp);
        }

        private void nintendoEntertainmentSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processToolStripMenuItem.Enabled = false;
            NES comp = new NES();
            bgw.RunWorkerAsync(comp);
        }

        private void nintendoEntertainmentSystemMMC5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processToolStripMenuItem.Enabled = false;
            NES_MMC5 comp = new NES_MMC5();
            bgw.RunWorkerAsync(comp);
        }

        private void nECPC8801ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processToolStripMenuItem.Enabled = false;
            NEC_PC comp = new NEC_PC();
            bgw.RunWorkerAsync(comp);
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Computer comp = e.Argument as Computer;

            pboResized.Image = comp.Resize((Bitmap)pboOriginal.Image);
            pboIndexed.Image = comp.ReduceColor(new AccuBitmap((Bitmap)pboResized.Image), worker).ToBitmap();
            if (betterTileFittingToolStripMenuItem.Checked)
                pboTiled.Image = comp.ReduceTileset((Bitmap)pboIndexed.Image, worker);
            else
                pboTiled.Image = comp.ReduceTilesetSimple((Bitmap)pboIndexed.Image, worker);
            pboBordered.Image = comp.Border((Bitmap)pboTiled.Image);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tstProgress.Value = e.ProgressPercentage;
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            processToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (pboOriginal.Image != null)
                    {
                        dlgSave.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(dlgSave.FileName))
                        {
                            pboOriginal.Image.Save(dlgSave.FileName);
                            tstStatus.Text = "Saved.";
                        }
                    }
                    break;
                case 1:
                    if (pboResized.Image != null)
                    {
                        dlgSave.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(dlgSave.FileName))
                        {
                            pboResized.Image.Save(dlgSave.FileName);
                            tstStatus.Text = "Saved.";
                        }
                    }
                    break;
                case 2:
                    if (pboIndexed.Image != null)
                    {
                        dlgSave.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(dlgSave.FileName))
                        {
                            pboIndexed.Image.Save(dlgSave.FileName);
                            tstStatus.Text = "Saved.";
                        }
                    }
                    break;
                case 3:
                    if (pboTiled.Image != null)
                    {
                        dlgSave.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(dlgSave.FileName))
                        {
                            pboTiled.Image.Save(dlgSave.FileName);
                            tstStatus.Text = "Saved.";
                        }
                    }
                    break;
                case 4:
                    if (pboBordered.Image != null)
                    {
                        dlgSave.ShowDialog();
                        if (!String.IsNullOrWhiteSpace(dlgSave.FileName))
                        {
                            pboBordered.Image.Save(dlgSave.FileName);
                            tstStatus.Text = "Saved.";
                        }
                    }
                    break;
            }
        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new AboutBox1();
            a.ShowDialog();
        }

        private void betterTileFittingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            betterTileFittingToolStripMenuItem.Checked = !betterTileFittingToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
