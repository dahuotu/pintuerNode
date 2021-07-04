using System;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

namespace com.DaHuotu
{
    public partial class MYSQL : Form
    {
        public MYSQL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MYSQL_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭连接窗体
            this.Close();
        }
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckForm("connect");
        }
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            CheckForm("test");
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MYSQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        #region 常用函数

        /// <summary>
        /// 验证表单
        /// </summary>
        void CheckForm(string btnType)
        {
            if (string.IsNullOrEmpty(txtIP.Text))
            {
                MessageBox.Show("请填写连接地址", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("请填写端口号", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtConnectName.Text))
            {
                MessageBox.Show("请填写数据库", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("请填写用户名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (btnType == "test")
                {
                    //测试
                    TestConnect();
                }
                else
                {
                    //连接
                    GoConnect();
                }
            }
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        void TestConnect()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.AppendFormat("Server={0};Database={1}; User ID={2};Password={3};port={4};CharSet=utf8;pooling=true;", txtIP.Text.Trim(), txtConnectName.Text.Trim(), txtName.Text.Trim(), txtPassword.Text.Trim(), txtPort.Text.Trim());
            DbHelperMySQL mySql = new DbHelperMySQL();
            string stateMsg = mySql.TestConnect(sSql.ToString());
            if (string.IsNullOrEmpty(stateMsg))
            {
                MessageBox.Show("连接成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("连接失败，请检查您的连接信息。错误信息：[" + stateMsg + "]", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 连接
        /// </summary>
        void GoConnect()
        {
            StringBuilder sSql = new StringBuilder();
            sSql.AppendFormat("Server={0};Database={1}; User ID={2};Password={3};port={4};CharSet=utf8;pooling=true;", txtIP.Text.Trim(), txtConnectName.Text.Trim(), txtName.Text.Trim(), txtPassword.Text.Trim(), txtPort.Text.Trim());
            DbHelperMySQL mySql = new DbHelperMySQL();
            string stateMsg = mySql.TestConnect(sSql.ToString());
            if (string.IsNullOrEmpty(stateMsg))
            {
                AppSettings.setString("DataBase", txtConnectName.Text.Trim(), sSql.ToString());
                //关闭连接窗体
                this.Close();
            }
            else
            {
                MessageBox.Show("连接失败，请检查您的连接信息。错误信息：[" + stateMsg + "]", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


    }
}
