using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoveConsole
{
    public partial class ProcessManager : Form
    {
        public ProcessManager()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PRList.SelectedItems.Count == 0)
            {
                return;
            }
            foreach (ListViewItem item in PRList.SelectedItems)
            {
                try
                {
                    Process p = Process.GetProcessById(Convert.ToInt32(item.SubItems[2].Text));
                    string path = p.MainModule.FileName;
                    Process.Start("explorer.exe", splitpath(path));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        string splitpath(string path)
        {
            int count = 0;
            foreach (char item in path)
            {
                if (item == '\\')
                {
                    count++;
                }
            }
            string[] split1 = path.Split('\\');
            string add = string.Empty;
            for (int i = 0; i < count; i++)
            {
                if (i == count)
                {
                    break;
                }
                add += split1[i] + "\\";

            }
            return add;
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCurrentProcess();
        }
        private void selkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PRList.SelectedItems.Count == 0)
            {
                return;
            }
            foreach (ListViewItem item in PRList.SelectedItems)
            {
                Process p = Process.GetProcessById(Convert.ToInt32(item.SubItems[2].Text));
                p.Kill();

            }
            LoadCurrentProcess();
        }

        private void allkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PRList.SelectedItems.Count == 0)
            {
                return;
            }
            foreach (ListViewItem item in PRList.Items)
            {
                if (item.Text.Contains(PRList.SelectedItems[0].Text))
                {
                    Process p = Process.GetProcessById(Convert.ToInt32(item.SubItems[2].Text));
                    p.Kill();
                }
            }
            LoadCurrentProcess();
        }
        void LoadCurrentProcess()
        {
            PRList.Items.Clear();
            Process[] pr = Process.GetProcesses();
            foreach (var prr in pr)
            {
                try
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = prr.ProcessName;
                    try

                    {
                        string a = prr.StartTime.ToShortTimeString();
                        item.SubItems.Add(prr.StartTime.ToShortTimeString());
                    }
                    catch
                    {
                        item.SubItems.Add("0");
                    }
                    item.SubItems.Add(prr.Id.ToString());
                    item.SubItems.Add(prr.Threads.Count.ToString());
                    PRList.Items.Add(item);
                }
                catch { }
            }
        }
        private void ProcessManager_Load(object sender, EventArgs e)
        {
            LoadCurrentProcess();
        }
    }
}
