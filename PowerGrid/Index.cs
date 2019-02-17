using PowerGrid.DBHelper;
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

namespace PowerGrid
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsn.Text.Trim() == "")
                {
                    labelUsn.Text = "用户名不能为空";
                    txtUsn.Focus();
                    return;
                }
                else
                {
                    labelUsn.Text = "";
                }
                if (txtPwd.Text.Trim() == "")
                {
                    labelPwd.Text = "密码不能为空";
                    txtPwd.Focus();
                    return;
                }
                else
                {
                    labelPwd.Text = "";
                }

                string sqlStr = @"SELECT `userName`, `password` FROM `User` WHERE `userName` = @username";
                DbParameter[] param = new OleDbParameter[1];
                param[0] = new OleDbParameter("@username", OleDbType.VarChar);
                param[0].Value = txtUsn.Text;
                DbHelper db = new DbHelper();
                DataRow row = db.GetDataRow(sqlStr, param);
                if (row != null)
                {
                    if (Convert.ToString(row["password"]) == txtPwd.Text.Trim())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        labelPwd.Text = "密码错误， 请重新输入";
                        txtUsn.Text = "";
                        txtPwd.Text = "";
                        txtPwd.Focus();
                    }

                }
                else
                {
                    labelUsn.Text = "用户名不存在, 请重新输入";
                    txtUsn.Text = "";
                    txtPwd.Text = "";
                    txtUsn.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }

        }

        private void registBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
