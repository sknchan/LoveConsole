using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoveConsole
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void topmostonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topmostoffToolStripMenuItem.Text = "[OFF]";
            topmostonToolStripMenuItem.Text = "[ON] ✔";
            this.TopMost = true;
        }

        private void topmostoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topmostoffToolStripMenuItem.Text = "[OFF] ✔";
            topmostonToolStripMenuItem.Text = "[ON]";
            this.TopMost = false;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
           
        }
        private void processManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManager pr = new ProcessManager();
            pr.Show();
        }
    }
}
