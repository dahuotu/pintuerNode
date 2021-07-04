using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Web;

namespace com.DaHuotu
{
    /// <summary>
    /// 标注应用入口
    /// </summary>
    public partial class App : Form
    {
        #region 全局变量
        string appName = Properties.Settings.Default.appName;
        string appVersion = Properties.Settings.Default.appVersion;
        string appSite = Properties.Settings.Default.appSite;
        string appAbout = Properties.Settings.Default.appAbout;

        DataTable dtList = new DataTable();

        #endregion

        #region 界面事件处理

        public App()
        {
            InitializeComponent();
        }

        //界面加载
        private void App_Load(object sender, EventArgs e)
        {
            this.Text = appName + " Version " + appVersion;
            this.GetAppConfigList();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //菜单退出
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
        //软件介绍
        private void useHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(appSite);
        }

        //菜单联系作者
        private void linkaboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //联系作者
            Process.Start(appAbout);

        }

        //菜单关于我们
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }

        //设置
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting fset = new frmSetting();
            fset.ShowDialog();
        }

        /// <summary>
        /// 刷新数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnRefash_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            //添加数据库连接
            MYSQL mysql = new MYSQL();
            mysql.ShowDialog();
        }

        /// <summary>
        /// 单击节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selectedText = e.Node.Text;

            if (e.Node.Level == 0 && e.Node.Nodes.Count == 0)
            {
                string sqlcon = AppSettings.getString("DataBase", selectedText);
                //选中数据库获取所有表
                DataTable dt = DbHelperMySQL.GetTablesByDB(selectedText, sqlcon);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    e.Node.Nodes.Add(dt.Rows[i]["table_name"].ToString());
                    e.Node.Nodes[i].ImageKey = "table-c.png";
                    e.Node.Nodes[i].SelectedImageKey = "table-o.png";
                }
                e.Node.SelectedImageKey = "dbname-o.png";
                e.Node.ExpandAll();
            }
            else if (e.Node.Level == 1 && e.Node.Nodes.Count == 0)
            {
                string sqlcon = AppSettings.getString("DataBase", e.Node.Parent.Text);
                //添加复选框列
                checkBoxColumnStyle();
                //选中表获取所有字段
                DataTable dt = DbHelperMySQL.GetColumnByTable(e.Node.Parent.Text, sqlcon, selectedText);
                this.dataGridView1.DataSource = dt;
                this.dataGridViewStyle();

            }
            else
            {

            }
        }

        #endregion

        #region 自定义方法

        private void checkBoxColumnStyle()
        {
            //添加复选框列
            this.dataGridView1.Columns.Clear();
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.DataPropertyName = "chkColumn";
            chkColumn.Name = "chkColumn";
            chkColumn.HeaderText = "选择";
            chkColumn.Width = 40;
            chkColumn.ThreeState = false;
            this.dataGridView1.Columns.Add(chkColumn);
        }

        /// <summary>
        /// 设置数据表样式
        /// </summary>
        private void dataGridViewStyle()
        {
            //调整dataGridView样式
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["键类型"].Width = 80;
            this.dataGridView1.Columns["允许空"].Width = 80;
            this.dataGridView1.Columns["默认值"].Width = 80;
            this.dataGridView1.Columns["所属库"].Width = 80;
            this.dataGridView1.Columns["所属表"].Width = 80;
        }

        /// <summary>
        /// 获取所有本地存储的连接
        /// </summary>
        void GetAppConfigList()
        {
            int len = AppSettings.appSection("DataBase").Settings.Count;
            string[] list = AppSettings.appSection("DataBase").Settings.AllKeys;

            if (len > 0)
            {
                this.treeView1.Nodes.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.treeView1.Nodes.Add(list[i]);
                }
            }
        }

        #endregion


    }
}
