using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace workpath
{
    public partial class WordPadL : Form
    {
        public WordPadL()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();

        }

        private void pageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open my new File";
            of.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                rtb.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save my new File";
            sf.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
                rtb.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sf.FileName;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtb.Font;
            fd.ShowDialog();
            rtb.Font = fd.Font;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
