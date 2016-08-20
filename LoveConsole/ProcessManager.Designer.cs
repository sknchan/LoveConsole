namespace LoveConsole
{
    partial class ProcessManager
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
            this.components = new System.ComponentModel.Container();
            this.ProcessManagerContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRList = new Admin.UI.AeroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessManagerContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessManagerContext
            // 
            this.ProcessManagerContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.killToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.ProcessManagerContext.Name = "ProcessManagerContext";
            this.ProcessManagerContext.Size = new System.Drawing.Size(153, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selkillToolStripMenuItem,
            this.allkillToolStripMenuItem});
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.killToolStripMenuItem.Text = "Kill";
            // 
            // selkillToolStripMenuItem
            // 
            this.selkillToolStripMenuItem.Name = "selkillToolStripMenuItem";
            this.selkillToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.selkillToolStripMenuItem.Text = "작업끝내기";
            this.selkillToolStripMenuItem.Click += new System.EventHandler(this.selkillToolStripMenuItem_Click);
            // 
            // allkillToolStripMenuItem
            // 
            this.allkillToolStripMenuItem.Name = "allkillToolStripMenuItem";
            this.allkillToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.allkillToolStripMenuItem.Text = "프로세스 트리 끝내기";
            this.allkillToolStripMenuItem.Click += new System.EventHandler(this.allkillToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // PRList
            // 
            this.PRList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.PRList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PRList.Location = new System.Drawing.Point(0, 0);
            this.PRList.Name = "PRList";
            this.PRList.NoMultiCheck = false;
            this.PRList.Size = new System.Drawing.Size(551, 383);
            this.PRList.TabIndex = 1;
            this.PRList.UseCompatibleStateImageBehavior = false;
            this.PRList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProcessName";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StartTime";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PID";
            this.columnHeader3.Width = 101;
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 383);
            this.Controls.Add(this.PRList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessManager";
            this.Load += new System.EventHandler(this.ProcessManager_Load);
            this.ProcessManagerContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ProcessManagerContext;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Admin.UI.AeroListView PRList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}