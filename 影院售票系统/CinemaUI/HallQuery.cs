using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
    
namespace 影院售票系统.CinemaUI
{
   

    public partial class HallQuery : Form
    {
        private ArrayList allHall; //存储所有影厅信息。
        private HallBLL selectedHall; //存储当前选择影厅。
        public HallQuery()
        {
            InitializeComponent();
        }

        //影厅查询窗体载入事件。
        private void HallQuery_Load(object sender, EventArgs e)
        {
            //初始化allHall。
            ArrayList allHall = HallBLL.getAllHall();
            this.allHall = allHall;

            //初始化CBHName控件。
            for(int i = 0; i < allHall.Count; ++i)
            {
                selectedHall = (HallBLL)this.allHall[i];
                this.CBHName.Items.Add(selectedHall);
            }
            this.CBHName.SelectedIndex = -1;
            if (this.CBHName.Items.Count > 0)
            {
                this.CBHName.Text = "请选择影厅";
            }
            else
            {
                this.CBHName.Text = "无影厅记录";
            }
            
        }

        //选择电影名称改变事件。
        private void CBHName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //使selectedHall始终指向选择的影厅。
            this.selectedHall = (HallBLL)this.CBHName.SelectedItem;
            //使查询后的控件初始化到查询前的状态。
            this.BHUpdateName.Text = "修改";
            this.BHUpdateName.Visible = false;
            this.BHDelete.Visible = false;
            this.TBHName.ReadOnly = true;
        }

        //查询影厅信息事件。
        private void BHQuery_Click(object sender, EventArgs e)
        {
            if (this.CBHName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择影厅后查询。", "", MessageBoxButtons.OK);
                return;
            }
            this.TBHName.Text = selectedHall.HallName;
            this.TBHRow.Text = Convert.ToString(selectedHall.getSumRow());
            this.TBHSeat.Text = Convert.ToString(selectedHall.getSumSeat());

            //绘制影厅结构图。
            this.GBHSeat.Controls.Clear();
            int x = 40;  //x轴增量。
            int y = 21;  //y轴增量。
            double sy = (16 - selectedHall.getReallySumRow())/2.0; //初始y轴偏移。
            Label[] seat = new Label[selectedHall.getSumSeat()];
            for (int i = 0, n = 0, r = 0; i < selectedHall.getReallySumRow(); ++i)
            {
                double sx = (12 - selectedHall.getRow(i)) / 2.0;  //第i排x轴初始偏移。
                if (selectedHall.getRow(i) > 0)
                {
                    ++r;   //记录真实排数。
                }
                for (int j = 0; j < selectedHall.getRow(i); ++j, ++n)
                {
                    seat[n] = new Label();
                    seat[n].Width = 35;
                    seat[n].Height = 15;
                    seat[n].TextAlign = ContentAlignment.MiddleCenter;
                    seat[n].BackColor = Color.LightBlue;
                    seat[n].Top = Convert.ToInt32(52 + (sy + i) * y);
                    seat[n].Left = Convert.ToInt32(10 + (sx + j) * x);
                    seat[n].Text = r + "-" + (j + 1);
                    this.GBHSeat.Controls.Add(seat[n]);
                    seat[n].Show();
                }
            }

            this.BHDelete.Visible = true;
            this.BHUpdateName.Visible = true;

        }

        //删除一条影厅记录事件。
        private void BHDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(selectedHall.message(), "确认删除影厅", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selectedHall.deleteHall())
                {
                    MessageBox.Show("删除成功。", "", MessageBoxButtons.OK);
                    //界面控件复原和更新。
                    this.GBHSeat.Controls.Clear();
                    this.TBHName.Text = null;
                    this.TBHRow.Text = null;
                    this.TBHSeat.Text = null;
                    this.BHDelete.Visible = false;
                    this.BHUpdateName.Visible = false;
                    this.CBHName.Items.Remove(selectedHall);
                    this.allHall.Remove(selectedHall);
                    this.CBHName.SelectedIndex = -1;
                    if (this.CBHName.Items.Count > 0)
                    {
                        this.CBHName.Text = "请选择影厅";
                    }
                    else
                    {
                        this.CBHName.Text = "无影厅记录";
                    }
                } 
                else
                {
                    MessageBox.Show("删除失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //更新一条影厅的名称事件。
        private void BHUpdateName_Click(object sender, EventArgs e)
        {
            if (this.CBHName.SelectedIndex == -1)
            {
                return;
            }
            if (this.BHUpdateName.Text == "修改")
            {
                this.BHUpdateName.Text = "保存";
                this.TBHName.ReadOnly = false;
            }
            else
            {
                string s = "影厅名称：" + selectedHall.HallName + "\n改为：    " + this.TBHName.Text;
                if (MessageBox.Show(s, "确认更新影厅名称", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string old = selectedHall.HallName;
                    selectedHall.HallName = this.TBHName.Text;
                    if(selectedHall.updateHallName())
                    {
                        MessageBox.Show("更新成功。", "", MessageBoxButtons.OK);
                        this.CBHName.Text = selectedHall.HallName;
                    }
                    else
                    {
                        MessageBox.Show("更新失败。", "", MessageBoxButtons.OK);
                        selectedHall.HallName = old;
                    }
                }
                this.BHUpdateName.Text = "修改";
                this.TBHName.ReadOnly = true;
            }
        }

    }
}
