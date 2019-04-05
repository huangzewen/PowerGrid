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
    public partial class BusBar : Form
    {
        DbHelper db = new DbHelper();
        private DataGridViewPaginationAdapter adapter;

        public BusBar()
        {
            InitializeComponent();
            this.BusBardataGridView.AutoGenerateColumns = true;
            this.BusBardataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);

            this.AutoSizeColumn(this.BusBardataGridView);
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
            string sqlStr = @"SELECT b.SubStationName, a.BusBar, c.BusBarLevel FROM `BusBar` AS a, `SubStation` AS b, `BusBarLevel` AS c WHERE a.SubStationId = b.Id and a.BusBarLevelId = c.Id;";
            DbParameter[] param = new OleDbParameter[0];

            DataTable dt = db.GetDataTable(sqlStr, param);
            dt.Columns["SubStationName"].ColumnName = "变电站";
            dt.Columns["BusBar"].ColumnName = "母线";
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
            this.BusBardataGridView.DataSource = dataTable.AsDataView();                  // Display the dats in the DataGridView
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
            foreach (DataGridViewRow dataGridViewRow in this.BusBardataGridView.Rows)
            {
                dataGridViewRow.HeaderCell.Value = String.Format("{0}", dataGridViewRow.Index + 1 +
                    this.adapter.CurrentPage * this.adapter.MaximumPageSize);
            }
            this.BusBardataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void BusBar_Load(object sender, EventArgs e)
        {

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
    }
}
