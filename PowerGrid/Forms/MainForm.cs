using PowerGrid.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerGrid.Forms
{
    public partial class MainForm : Form
    {
        private Index index;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Index index)
        {
            InitializeComponent();
            this.index = index;

        }

        private void UserInfoMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metaDataMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 变电站等级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SubStationLevel();
            ChangeForm(form);
        }

        private void 母线等级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new BusBarLevel();
            ChangeForm(form);
        }

        private void 母线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new BusBar();
            ChangeForm(form);
        }

        private void 线路等级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new LineLevel();
            ChangeForm(form);
        }
        
        private void 变电站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SubStation();
            ChangeForm(form);
        }

        private void 主变ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainTformer();
            ChangeForm(form);
        }

        private void 线路ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Line();
            ChangeForm(form);
        }

        private void ChangeForm (Form form)
        {
            this.mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subStationLevelPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.index.Close();
        }


    }
}
