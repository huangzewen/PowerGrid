using Microsoft.Reporting.WinForms;
using PowerGrid.DBHelper;
using PowerGrid.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerGrid.Forms
{
    public partial class BusBarLevel : Form
    {
        DbHelper db = new DbHelper();
        private DataGridViewPaginationAdapter adapter;

        public BusBarLevel()
        {
            InitializeComponent();
            this.BusBarLeveldataGridView.AutoGenerateColumns = true;
            this.BusBarLeveldataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);

            this.AutoSizeColumn(this.BusBarLeveldataGridView);
            this.adapter = new DataGridViewPaginationAdapter(this.GenerateDataTable());
            this.adapter.PageChanged += new PageChangedEventHandler(this.adapter_PageChanged);

            this.adapter.MoveFirst();
            this.maxPagesLabel.Text = "of " + adapter.TotalPages;

        }

        #region [ Generate Test Data ]
        /// <summary>
        /// Generates some data to show how the pagination works
        /// </summary>
        /// <returns>Returns a DataTable filled with data</returns>
        private DataTable GenerateDataTable()
        {
            string sqlStr = @"SELECT a.SubStationLevel, b.BusBarLevel FROM `SubStationLevel` AS a, `BusBarLevel` AS b WHERE a.Id = b.SubStationLevelId;";
            DbParameter[] param = new OleDbParameter[0];

            DataTable dt = db.GetDataTable(sqlStr, param);
            dt.Columns["SubStationLevel"].ColumnName = "变电站等级";
            dt.Columns["BusBarLevel"].ColumnName = "母线电压等级";
            return dt;
        }
        #endregion

        /// <summary>
        /// Adapter Page Changed Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adapter_PageChanged(object sender, PageChangedEventArgs e)
        {
            DataTable dataTable = this.adapter.GetPage(this.adapter.CurrentPage);   // DataTable to hold all of this page's data
            this.BusBarLeveldataGridView.DataSource = dataTable.AsDataView();                  // Display the dats in the DataGridView
            this.currentPageTextBox.Text = this.adapter.CurrentPage + 1 + "";       // Sets the current page number in the text box

            bool hasNext = this.adapter.HasNext;        // Check if there is another page after this one
            bool hasPrev = this.adapter.HasPrevious;    // Check if there is a page before this one

            // Enable/disable the buttons depending on the page number
            this.nextPageBtn.Enabled = hasNext;
            this.lastPageBtn.Enabled = hasNext;
            this.previousPageBtn.Enabled = hasPrev;
            this.firstPageBtn.Enabled = hasPrev;
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in this.BusBarLeveldataGridView.Rows)
            {
                dataGridViewRow.HeaderCell.Value = String.Format("{0}", dataGridViewRow.Index + 1 +
                    this.adapter.CurrentPage * this.adapter.MaximumPageSize);
            }
            this.BusBarLeveldataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }


        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            this.adapter.MoveNext();
        }

        private void AutoSizeColumn(DataGridView dgv)
        {
            int width = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                width += dgv.Columns[i].Width;

            }
            if (width > dgv.Size.Width)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            }
            else
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Frozen = true;

            }

        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            this.adapter.MovePrevious();
        }

        private void firstPageBtn_Click(object sender, EventArgs e)
        {
            this.adapter.MoveFirst();
        }

        private void lastPageBtn_Click(object sender, EventArgs e)
        {
            this.adapter.MoveLast();
        }

        private void BusBarLeveldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
