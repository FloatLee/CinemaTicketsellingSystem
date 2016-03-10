using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 影院售票系统.CinemaUI
{
    public partial class HallNew : Form
    {
        public HallNew()
        {
            InitializeComponent();
        }

        //录入影厅信息事件。
        private void BHNew_Click(object sender, EventArgs e)
        {
            HallBLL hall = new HallBLL();
            if (this.TBHName.Text == "")
            {
                hall.HallName = "未命名";
            }
            else
            {
                hall.HallName = this.TBHName.Text;
            }
            hall.setRow(0, Convert.ToInt32(this.TBHRow1.Text.Trim()));
            hall.setRow(1, Convert.ToInt32(this.TBHRow2.Text.Trim()));
            hall.setRow(2, Convert.ToInt32(this.TBHRow3.Text.Trim()));
            hall.setRow(3, Convert.ToInt32(this.TBHRow4.Text.Trim()));
            hall.setRow(4, Convert.ToInt32(this.TBHRow5.Text.Trim()));
            hall.setRow(5, Convert.ToInt32(this.TBHRow6.Text.Trim()));
            hall.setRow(6, Convert.ToInt32(this.TBHRow7.Text.Trim()));
            hall.setRow(7, Convert.ToInt32(this.TBHRow8.Text.Trim()));
            hall.setRow(8, Convert.ToInt32(this.TBHRow9.Text.Trim()));
            hall.setRow(9, Convert.ToInt32(this.TBHRow10.Text.Trim()));
            hall.setRow(10, Convert.ToInt32(this.TBHRow11.Text.Trim()));
            hall.setRow(11, Convert.ToInt32(this.TBHRow12.Text.Trim()));
            hall.setRow(12, Convert.ToInt32(this.TBHRow13.Text.Trim()));
            hall.setRow(13, Convert.ToInt32(this.TBHRow14.Text.Trim()));
            hall.setRow(14, Convert.ToInt32(this.TBHRow15.Text.Trim()));
            hall.setRow(15, Convert.ToInt32(this.TBHRow16.Text.Trim()));

            for(int i = 0; i < 16; ++i)
            {
                if (hall.getRow(i) > 12)
                {
                    MessageBox.Show("每排座位数不能超过12。", "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (MessageBox.Show(hall.message(), "确认录入影厅", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (hall.saveHall())
                {
                    MessageBox.Show("录入成功。", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("录入失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //第N列座位数按键事件。 控制只能输入整数且不能为空。
        private void TBHRow1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、退格和删除外的字符。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
            //判断是否为删除字符。
            if ((int)e.KeyChar == 8)
            {
                TextBox tb = (TextBox)sender;
                //不能删除最后一个字符。
                if ((tb.Text.ToString().Length) == 1)
                {
                    e.Handled = true;
                }
            }
        }

    }
}
