using Admin.Utilits;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Admin.UI
{
    public class AeroListView : ListView
    {
        private const uint WM_CHANGEUISTATE = 0x127;

        private const int UIS_SET = 1;
        private const int UISF_HIDEFOCUS = 0x1;

        private ListViewColumnSorter LvwColumnSorter { get; set; }
        public bool NoMultiCheck { get; set; } = false;
        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);
        public AeroListView()
        {
            this.LvwColumnSorter = new ListViewColumnSorter();
            this.ListViewItemSorter = LvwColumnSorter;
            HandleCreated += AeroListView_HandleCreated;
            this.DoubleBuffered = true;

        }
        /// <summary>
        /// Raises the <see cref="E:ColumnClick" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ColumnClickEventArgs"/> instance containing the event data.</param>
        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            base.OnColumnClick(e);

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == this.LvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                this.LvwColumnSorter.Order = (this.LvwColumnSorter.Order == SortOrder.Ascending)
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                this.LvwColumnSorter.SortColumn = e.Column;
                this.LvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.Sort();
        }
        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {

            if (NoMultiCheck)
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (i == ice.Index) continue;
                    Items[i].Checked = false;
                }
            }
            else
            {
                base.OnItemCheck(ice);
            }
        }
        private void AeroListView_HandleCreated(object sender, EventArgs e)
        {
            SetWindowTheme(this.Handle, "explorer", null);
        }

    }
}

