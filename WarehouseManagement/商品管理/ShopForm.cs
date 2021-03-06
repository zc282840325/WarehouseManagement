﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.商品管理;

namespace WarehouseManagement
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }
        //跳轉到新增窗口
        private void btn_add_Click(object sender, EventArgs e)
        {
            ShopAddForm shopForm = new ShopAddForm();
            shopForm.ShowDialog();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            InitData();
        }
        //初始化數據
        private void InitData()
        {
           
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)   //如果单击“是”按钮
            {
                e.Cancel = false; //关闭窗体
                MainForm mainForm = new MainForm();
                mainForm.Visible = true;
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;                  //不执行操作
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

        }
    }
}
