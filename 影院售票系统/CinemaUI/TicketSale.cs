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
    public partial class TicketSale : Form
    {
        private ArrayList allMovie;  //存储所有影片数据。
        private ArrayList allHall;  //存储所有影厅数据。
        private ArrayList allPlan;  //存储所有场次数据。
        private ArrayList allTicket;  //存储所有售票数据。

        private MovieBLL selectedMovie;  //存储当前选择影片。
        private HallBLL selectedHall;  //存储当前选择影厅。
        private PlanBLL selectedPlan;  //存储当前选择场次。

        private ArrayList oldPlan = new ArrayList(); //存储过期场次。
        private ArrayList nowPlan = new ArrayList(); //存储在映场次。
        private ArrayList selectedTicket = new ArrayList(); //存储当前场次购票数据。
        private ArrayList selecetSeat = new ArrayList();  //存储选择的位置。
        private Label[] seat;  //存储座位控件。

        private double discount;  //折扣系数。

        public TicketSale()
        {
            InitializeComponent();
        }

        //窗体加载事件。
        private void TicketSale_Load(object sender, EventArgs e)
        {
            //初始化数据。
            this.allMovie = MovieBLL.getAllMovie();
            this.allHall = HallBLL.getAllHall();
            this.allPlan = PlanBLL.getAllPlan();
            this.allTicket = TicketBLL.getAllTicket();

            //场次分类。
            for (int i = 0; i < allPlan.Count; ++i)
            {
                selectedPlan = (PlanBLL)allPlan[i];
                if (compareDateTime(selectedPlan.TStart, DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString()) == 1)
                {
                    nowPlan.Add(selectedPlan);
                }
                else
                {
                    oldPlan.Add(selectedPlan);
                }
            }

            //CBSTDiscount控件初始化。
            this.CBSTDiscount.Items.Add("无折扣");
            this.CBSTDiscount.Items.Add("学生票");
            this.CBSTDiscount.SelectedIndex = 0;
            this.discount = 1.0;
            
            //初始选择售票退票功能。
            this.RBSTMain.Checked = true;
        }

        //比较日期时间字符串函数，相等返回0，第一个大返回1，第二个大返回-1。
        private int compareDateTime(string date1, string date2)
        {
            //分割日期。
            char[] temp = { '年', '月', '日', ':' };
            string[] temp1 = date1.Split(temp);
            string[] temp2 = date2.Split(temp);

            //年、月、日比较。
            for (int i = 0; i < 5; ++i)
            {
                int a = Convert.ToInt32(temp1[i].Trim()), b = Convert.ToInt32(temp2[i].Trim());
                if (a > b)
                {
                    return 1;
                }
                else if (a < b)
                {
                    return -1;
                }
            }
            return 0;
        }

        //比较日期字符串函数，相等返回0，第一个大返回1，第二个大返回-1。
        private int compareDate(string date1, string date2)
        {
            //分割日期。
            char[] temp = { '年', '月', '日',':' };
            string[] temp1 = date1.Split(temp);
            string[] temp2 = date2.Split(temp);

            //年、月、日比较。
            for (int i = 0; i < 3; ++i)
            {
                int a = Convert.ToInt32(temp1[i].Trim()), b = Convert.ToInt32(temp2[i].Trim());
                if (a > b)
                {
                    return 1;
                }
                else if (a < b)
                {
                    return -1;
                }
            }
            return 0;
        }

        //动态数组按开始时间排序。
        private bool sort(ArrayList arr)
        {
            PlanBLL temp;
            int z;
            for (int i = 0; i < arr.Count; ++i)
            {
                z = i;
                for (int j = i + 1; j < arr.Count; ++j)
                {
                    if (compareDateTime(((PlanBLL)arr[z]).TStart, ((PlanBLL)arr[j]).TStart) == 1)
                    {
                        z = j;
                    }
                }
                temp = (PlanBLL)arr[z];
                arr[z] = arr[i];
                arr[i] = temp;
            }
            return true;
        }

        //选择场次事件（树表选择变更事件）。
        private void TVSTPlan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.TVSTPlan.SelectedNode.Parent != null)
            {
                selectedPlan = (PlanBLL)this.TVSTPlan.SelectedNode.Tag;
                for (int j = 0; j < allMovie.Count; ++j)
                {
                    if (selectedPlan.MovieId == ((MovieBLL)allMovie[j]).MovieId)
                    {
                        selectedMovie = (MovieBLL)allMovie[j];
                        break;
                    }
                }
                for (int j = 0; j < allHall.Count; ++j)
                {
                    if (selectedPlan.HallId == ((HallBLL)allHall[j]).HallId)
                    {
                        selectedHall = (HallBLL)allHall[j];
                        break;
                    }
                }
                this.TBSTMName.Text = selectedMovie.MovieName;
                this.PBSTPoster.ImageLocation = selectedMovie.Poster;
                this.TBSTActor.Text = selectedMovie.Actor;
                this.TBSTDirector.Text = selectedMovie.Director;
                this.TBSTType.Text = selectedMovie.MovieType;
                this.TBSTHName.Text = selectedHall.HallName;
                this.TBSTStart.Text = selectedPlan.getShortTime().Trim();
                this.TBSTPrice.Text = Convert.ToString(selectedPlan.Price * discount);

                //更新当前场次购票数据。
                selectedTicket.Clear();
                for(int i = 0; i < allTicket.Count; ++i)
                {
                    if(((TicketBLL)allTicket[i]).PlanId == selectedPlan.PlanId)
                    {
                        selectedTicket.Add(allTicket[i]);
                    }
                }

                //绘制影厅结构图。
                this.GBSTSeat.Controls.Clear();
                int x = 40;  //x轴增量。
                int y = 21;  //y轴增量。
                double sy = (16 - selectedHall.getReallySumRow()) / 2.0; //初始y轴偏移。
                seat = new Label[selectedHall.getSumSeat()];
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
                        seat[n].Tag = n;
                        seat[n].Click += new EventHandler(Sale_Click);
                        seat[n].Width = 35;
                        seat[n].Height = 15;
                        seat[n].TextAlign = ContentAlignment.MiddleCenter;
                        seat[n].BackColor = Color.LightBlue;
                        seat[n].Top = Convert.ToInt32(52 + (sy + i) * y);
                        seat[n].Left = Convert.ToInt32(10 + (sx + j) * x);
                        seat[n].Text = r + "-" + (j + 1);
                        this.GBSTSeat.Controls.Add(seat[n]);
                        seat[n].Show();
                    }
                }
                for (int i = 0; i < selectedTicket.Count; ++i)
                {
                    seat[((TicketBLL)selectedTicket[i]).SeatNum].BackColor = Color.Red;
                }
            }
        }

        //座位点击事件。
        private void Sale_Click(object sender, EventArgs e)
        {
            //单选功能。
            if (this.RBSTSingle.Checked == true)
            {
                Label label = (Label)sender;
                if (label.BackColor == Color.LightBlue)
                {
                    TicketBLL ticket = new TicketBLL();
                    ticket.SeatNum = (int)label.Tag;
                    ticket.SaleTime = DateTime.Now.ToString();
                    ticket.Discount = this.CBSTDiscount.Text;
                    ticket.PlanId = selectedPlan.PlanId;
                    if (MessageBox.Show(ticket.message(selectedHall, selectedMovie, selectedPlan, label.Text), "确认购票", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (ticket.saveTicket())
                        {
                            MessageBox.Show("购票成功", "", MessageBoxButtons.OK);
                            label.BackColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show("购票失败","",MessageBoxButtons.OK);
                        }
                    }
                }
            }

            //退票功能。
            else if (this.RBSTExit.Checked == true)
            {
                Label label = (Label)sender;
                if (label.BackColor == Color.Red)
                {
                    for (int i = 0; i < selectedTicket.Count; ++i)
                    {
                        if (((TicketBLL)selectedTicket[i]).SeatNum == (int)label.Tag)
                        {
                            TicketBLL ticket = (TicketBLL)selectedTicket[i];
                            if (MessageBox.Show(ticket.message(selectedHall, selectedMovie, selectedPlan, label.Text), "确认退票", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (ticket.deleteTicket())
                                {
                                    MessageBox.Show("退票成功","",MessageBoxButtons.OK);
                                    label.BackColor = Color.LightBlue;
                                    selectedTicket.Remove(ticket);
                                    break;
                                }
                            }
                        }
                    }
                }
            }


            //多选功能。
            else if (this.RBSTMore.Checked == true)
            {
                Label label = (Label)sender;
                if (label.BackColor == Color.LightBlue)
                {
                    label.BackColor = Color.LightGreen;
                    selecetSeat.Add(label.Tag);
                }
                else if (label.BackColor == Color.LightGreen)
                {
                    label.BackColor = Color.LightBlue;
                    selecetSeat.Remove(label.Tag);
                }
            }
        }

        //折扣类型变更事件。
        private void CBSTDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CBSTDiscount.SelectedIndex == 0)
            {
                discount = 1.0;
            }
            else if(this.CBSTDiscount.SelectedIndex == 1)
            {
                discount = 0.8;
            }
            if (this.TBSTPrice.Text != "")
            {
                this.TBSTPrice.Text = Convert.ToString(selectedPlan.Price * discount);
            }
        }

        //选择售票退票功能。
        private void RBSTMain_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RBSTMain.Checked == true)
            {
                //开启售退票功能。
                this.GBSTSelect2.Visible = true;
                this.RBSTsale.Checked = true;
                this.TVSTPlan.Nodes.Clear();
                this.CBSTDiscount.Enabled = true;
                this.GBSTSelect3.Visible = true;

                //重置TVSTPlan控件。
                this.TVSTPlan.Nodes.Clear();
                sort(nowPlan);
                for (int i = 0; i < nowPlan.Count; )
                {
                    if (i == 0)
                    {
                        selectedPlan = (PlanBLL)nowPlan[i];
                    }
                    TreeNode tempNode = this.TVSTPlan.Nodes.Add(selectedPlan.TStart.Split(' ')[0]);
                    while (compareDate(tempNode.Text, selectedPlan.TStart) == 0 && i < nowPlan.Count)
                    {
                        for (int j = 0; j < allMovie.Count; ++j)
                        {
                            if (selectedPlan.MovieId == ((MovieBLL)allMovie[j]).MovieId)
                            {
                                selectedMovie = (MovieBLL)allMovie[j];
                                break;
                            }
                        }
                        tempNode.Nodes.Add(selectedPlan.getShortTime().Trim() + " " + selectedMovie.MovieName).Tag = selectedPlan;
                        if (i + 1 < nowPlan.Count)
                        {
                            selectedPlan = (PlanBLL)nowPlan[++i];
                        }
                        else
                        {
                            ++i;
                        }
                    }
                }

                //清空界面和变量。
                selectedPlan = null;
                selectedMovie = null;
                selectedHall = null;
                this.TBSTActor.Text = null;
                this.TBSTDirector.Text = null;
                this.TBSTHName.Text = null;
                this.TBSTMName.Text = null;
                this.TBSTPrice.Text = null;
                this.TBSTStart.Text = null;
                this.TBSTType.Text = null;
                this.PBSTPoster.ImageLocation = null;
                this.GBSTSeat.Controls.Clear();
            }
        }

        //选择历史记录功能。
        private void RBSTHis_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RBSTHis.Checked == true)
            {
                //隐藏售退票功能。
                this.GBSTSelect2.Visible = false;
                this.RBSTsale.Checked = false;
                this.RBSTExit.Checked = false;
                this.CBSTDiscount.Enabled = false;
                this.CBSTDiscount.SelectedIndex = 0;
                this.GBSTSelect3.Visible = false;
                this.RBSTSingle.Checked = false;
                this.RBSTMore.Checked = false;

                //重置TVSTPlan控件内容。
                this.TVSTPlan.Nodes.Clear();
                sort(oldPlan);  //按时间排序。
                for (int i = 0; i < oldPlan.Count; )
                {
                    if (i == 0)
                    {
                        selectedPlan = (PlanBLL)oldPlan[i];
                    }
                    TreeNode tempNode = this.TVSTPlan.Nodes.Add(selectedPlan.TStart.Split(' ')[0]);
                    while (compareDate(tempNode.Text, selectedPlan.TStart) == 0 && i < oldPlan.Count)
                    {
                        for (int j = 0; j < allMovie.Count; ++j)
                        {
                            if (selectedPlan.MovieId == ((MovieBLL)allMovie[j]).MovieId)
                            {
                                selectedMovie = (MovieBLL)allMovie[j];
                                break;
                            }
                        }
                        tempNode.Nodes.Add(selectedPlan.getShortTime().Trim() + " " + selectedMovie.MovieName).Tag = selectedPlan;
                        if (i + 1 < oldPlan.Count)
                        {
                            selectedPlan = (PlanBLL)oldPlan[++i];
                        }
                        else
                        {
                            ++i;
                        }
                    }
                }

                //清空界面和变量。
                selectedPlan = null;
                selectedMovie = null;
                selectedHall = null;
                this.TBSTActor.Text = null;
                this.TBSTDirector.Text = null;
                this.TBSTHName.Text = null;
                this.TBSTMName.Text = null;
                this.TBSTPrice.Text = null;
                this.TBSTStart.Text = null;
                this.TBSTType.Text = null;
                this.PBSTPoster.ImageLocation = null;
                this.GBSTSeat.Controls.Clear();
            }
        }

        //选择售票功能。
        private void RBSTsale_CheckedChanged(object sender, EventArgs e)
        {
            //GBSTSelect3初始化。
            this.GBSTSelect3.Visible = true;
            this.RBSTSingle.Checked = true;

            if (selectedPlan != null)
            {
                this.allTicket = TicketBLL.getAllTicket();
                //更新当前场次购票数据。
                selectedTicket.Clear();
                for (int i = 0; i < allTicket.Count; ++i)
                {
                    if (((TicketBLL)allTicket[i]).PlanId == selectedPlan.PlanId)
                    {
                        selectedTicket.Add(allTicket[i]);
                    }
                }
            }
        }

        //选择退票功能。
        private void RBSTExit_CheckedChanged(object sender, EventArgs e)
        {
            //GBSTSelect3功能隐藏。
            this.GBSTSelect3.Visible = false;
            this.RBSTSingle.Checked = false;
            this.RBSTMore.Checked = false;

            if (selectedPlan != null)
            {
                this.allTicket = TicketBLL.getAllTicket();
                //更新当前场次购票数据。
                selectedTicket.Clear();
                for (int i = 0; i < allTicket.Count; ++i)
                {
                    if (((TicketBLL)allTicket[i]).PlanId == selectedPlan.PlanId)
                    {
                        selectedTicket.Add(allTicket[i]);
                    }
                }
            }
        }

        //选择单选功能。
        private void RBSTSingle_CheckedChanged(object sender, EventArgs e)
        {
            //隐藏部分控件。
            this.BSTBuy.Visible = false;
            this.BSTAuto.Visible = false;

            //多选取消。
            for (int i = 0; i < selecetSeat.Count; ++i)
            {
                seat[(int)selecetSeat[i]].BackColor = Color.LightBlue;
            }
            selecetSeat.Clear();
        }

        //选择多选功能。
        private void RBSTMore_CheckedChanged(object sender, EventArgs e)
        {
            //启用部分控件。
            this.BSTBuy.Visible = true;
            this.BSTAuto.Visible = true;
        }

        //多选购票事件。
        private void BSTBuy_Click(object sender, EventArgs e)
        {
            if (selecetSeat.Count == 0)
            {
                MessageBox.Show("请至少选择一张座位。", "", MessageBoxButtons.OK);
                return;
            }
            ArrayList selectLabel = new ArrayList();
            TicketBLL ticket = new TicketBLL();
            ticket.SaleTime = DateTime.Now.ToString();
            ticket.Discount = this.CBSTDiscount.Text;
            ticket.PlanId = selectedPlan.PlanId;
            for (int i = 0; i < selecetSeat.Count; ++i)
            {
                selectLabel.Add(seat[(int)selecetSeat[i]].Text);
            }
            if (MessageBox.Show(ticket.message(selectedHall, selectedMovie, selectedPlan, selecetSeat, selectLabel), "确认购票", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    for (int i = 0; i < selecetSeat.Count; ++i)
                    {
                        ticket.SeatNum = ((int)selecetSeat[i]);
                        ticket.saveTicket();
                        seat[(int)selecetSeat[i]].BackColor = Color.Red;
                    }
                    selecetSeat.Clear();
                    MessageBox.Show("购票成功", "", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("购票失败", "", MessageBoxButtons.OK);
                }
            }
        }

        //反选座位事件。
        private void BSTAuto_Click(object sender, EventArgs e)
        {
            selecetSeat.Clear();
            Label label;
            for (int i = 0; i < seat.Length; ++i)
            {
                label = seat[i];
                if (label.BackColor == Color.LightGreen)
                {
                    label.BackColor = Color.LightBlue;
                }
                else if (label.BackColor == Color.LightBlue)
                {
                    label.BackColor = Color.LightGreen;
                    selecetSeat.Add(label.Tag);
                }
            }
        }

    }
}
