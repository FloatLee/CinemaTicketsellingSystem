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
    public partial class PlanRows : Form
    {
        private ArrayList allHall; //存储所有影厅信息。
        private HallBLL selectedHall; //存储当前选择影厅。

        private ArrayList oldMovie = new ArrayList(); //存储下映影片信息。
        private ArrayList nowMovie = new ArrayList(); //存储在映影片信息。
        private ArrayList furMovie = new ArrayList(); //存储未映影片信息。
        private ArrayList allMovie; //存储所有影片信息。
        private ArrayList nowType;  //当前查询模式。
        private MovieBLL selectedMovie; //存储当前选择影片。

        private ArrayList allPlan;  //存储所有场次信息。
        private PlanBLL selectedPlan; //存储当前选择的场次。

        public PlanRows()
        {
            InitializeComponent();
        }

        //窗体载入事件。
        private void PlanRows_Load(object sender, EventArgs e)
        {
            //初始化allHall。
            ArrayList allHall = HallBLL.getAllHall();
            this.allHall = allHall;

            //初始化CLBPRHall控件。
            for (int i = 0; i < allHall.Count; ++i)
            {
                selectedHall = (HallBLL)allHall[i];
                this.LBPRHall.Items.Add(selectedHall);
            }
            this.LBPRHall.SelectedIndex = -1;
            selectedHall = null;
            if (this.LBPRHall.Items.Count <= 0)
            {
                this.LBPRHall.Text = "无影厅记录。";
            }

            //查询所有影片。
            ArrayList allMovie = MovieBLL.getAllMovie();
            this.allMovie = allMovie;

            //按放映日期将影片分类。
            string nowTime = DateTime.Now.ToLongDateString().ToString();
            for (int i = 0; i < allMovie.Count; ++i)
            {
                selectedMovie = (MovieBLL)this.allMovie[i];
                if (compareDate(selectedMovie.Start, nowTime) == 1)
                {
                    furMovie.Add(selectedMovie);
                }
                else if (compareDate(selectedMovie.End, nowTime) == -1)
                {
                    oldMovie.Add(selectedMovie);
                }
                else
                {
                    nowMovie.Add(selectedMovie);
                }
            }

            //初始选择查询所有影片。
            this.RBPRNow.Checked = true;

            //初始化DTPPRStart和DTPPREnd控件。
            this.DTPPREnd.CustomFormat = this.DTPPRStart.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.DTPPREnd.Format =  this.DTPPRStart.Format = DateTimePickerFormat.Custom;

            //初始化DTPPR控件。
            this.RBPRAuto.Checked = true;

            //读取所有场次信息。
            ArrayList all = PlanBLL.getAllPlan();
            this.allPlan = all;

            //TVPRPlan控件初始化。
            this.TVPRPlan.Nodes.Clear();
            ArrayList tempArr = new ArrayList();
            for (int i = 0; i < allMovie.Count; ++i)
            {
                //第一层节点为所有影片。
                TreeNode temp = this.TVPRPlan.Nodes.Add(allMovie[i].ToString());
                temp.Tag = (MovieBLL)allMovie[i];
                //将每一场次装载到对应影片的节点下。
                tempArr.Clear();
                for (int j = 0; j < allPlan.Count; ++j)
                {
                    selectedPlan = (PlanBLL)allPlan[j];
                    if (selectedPlan.MovieId == ((MovieBLL)allMovie[i]).MovieId)
                    {
                        tempArr.Add(selectedPlan);
                    }
                }
                sort(tempArr);
                for (int j = 0; j < tempArr.Count; ++j)
                {
                    selectedPlan = (PlanBLL)tempArr[j];
                    temp.Nodes.Add(selectedPlan.getTime()).Tag = selectedPlan;
                }
            }
            selectedPlan = null;
        }

        //播放时段自动设置。
        private void RBPRAuto_CheckedChanged(object sender, EventArgs e)
        {
            //当为真时触发。
            if (this.RBPRAuto.Checked == true)
            {
                this.DTPPREnd.Enabled = false;
            }
        }

        //播放时段手动设置。
        private void RBPRHand_CheckedChanged(object sender, EventArgs e)
        {
            //当为真时触发。
            if (this.RBPRHand.Checked == true)
            {
                this.DTPPREnd.Enabled = true;
            }
        }

        //选择显示在映电影。
        private void RBPRNow_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBPRNow.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = nowMovie;

                //更新并初始化LBPRMovie。
                this.LBPRMovie.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.LBPRMovie.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.LBPRMovie.SelectedIndex = -1;
            }
        }

        //选择显示未映电影。
        private void RBPRFur_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBPRFur.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = furMovie;

                //更新并初始化LBPRMovie。
                this.LBPRMovie.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.LBPRMovie.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.LBPRMovie.SelectedIndex = -1;
            }
        }

        //选择显示全部电影。
        private void RBPRAll_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBPRAll.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = allMovie;

                //更新并初始化LBPRMovie。
                this.LBPRMovie.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.LBPRMovie.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.LBPRMovie.SelectedIndex = -1;
            }
        }

        //选择显示下映电影。
        private void RBPROld_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBPROld.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = oldMovie;

                //更新并初始化LBPRMovie。
                this.LBPRMovie.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.LBPRMovie.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.LBPRMovie.SelectedIndex = -1;
            }
        }

        //比较日期字符串函数，相等返回0，第一个大返回1，第二个大返回-1。
        private int compareDate(string date1, string date2)
        {
            //分割日期。
            char[] temp = { '年', '月', '日' };
            string[] temp1 = date1.Split(temp);
            string[] temp2 = date2.Split(temp);

            //年、月、日比较。
            for (int i = 0; i < 3; ++i)
            {
                int a = Convert.ToInt32(temp1[i]), b = Convert.ToInt32(temp2[i]);
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

        //比较日期时间字符串函数，相等返回0，第一个大返回1，第二个大返回-1。
        private int compareDateTime(string date1, string date2)
        {
            //分割日期。
            char[] temp = { '年', '月', '日' , ':'};
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

        //选择影片变更事件。
        private void LBPRMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMovie = (MovieBLL)this.LBPRMovie.SelectedItem;

            //DTPPREnd随影片时长变更。
            if (this.RBPRAuto.Checked == true && selectedMovie != null)
            {
                this.DTPPREnd.Value = this.DTPPRStart.Value.AddMinutes(Convert.ToInt32(selectedMovie.Time));
            }
        }

        //录入排片事件。
        private void BPRNew_Click(object sender, EventArgs e)
        {
            //收集场次信息。
            PlanBLL plan = new PlanBLL();
            if (selectedHall == null)
            {
                MessageBox.Show("请选择影厅。", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                plan.HallId = selectedHall.HallId;
            }
            if (selectedMovie == null)
            {
                MessageBox.Show("请选择影片。", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                plan.MovieId = selectedMovie.MovieId;
            }
            if ((this.DTPPREnd.Value - this.DTPPRStart.Value).Days >= 0)
            {
                plan.TStart = this.DTPPRStart.Text;
                plan.TEnd = this.DTPPREnd.Text;
            }
            else
            {
                MessageBox.Show("结束时间不能小于开始时间。", "", MessageBoxButtons.OK);
                return;
            }
            if (this.TBPRPrice.Text == "")
            {
                plan.Price = 0;
            }
            else
            {
                plan.Price = Convert.ToDouble(this.TBPRPrice.Text);
            }

            //判断是否排片冲突。
            for (int i = 0; i < allPlan.Count; ++i )
            {
                //找和新场次相同影厅的场次。
                if (plan.HallId == ((PlanBLL)allPlan[i]).HallId)
                {
                    //时段冲突检测。
                    if (!(compareDateTime(plan.TEnd, ((PlanBLL)allPlan[i]).TStart) == -1 || compareDateTime(plan.TStart, ((PlanBLL)allPlan[i]).TEnd) == 1))
                    {
                        MovieBLL tempMovie = null;
                        HallBLL tempHall = null;
                        PlanBLL tempPlan = (PlanBLL)allPlan[i];
                        //寻找冲突场次的影厅和影片信息。
                        for (int j = 0; j < allMovie.Count; ++j)
                        {
                            if (tempPlan.MovieId == ((MovieBLL)allMovie[j]).MovieId)
                            {
                                tempMovie = (MovieBLL)allMovie[j];
                                break;
                            }
                        }
                        for (int j = 0; j < allHall.Count; ++j)
                        {
                            if (tempPlan.HallId == ((HallBLL)allHall[j]).HallId)
                            {
                                tempHall = (HallBLL)allHall[j];
                                break;
                            }
                        }
                        MessageBox.Show("和以下场次排片冲突：\n" + tempPlan.message(tempHall, tempMovie), "排片冲突", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            //输出新增影片信息并确认是否录入。
            if (MessageBox.Show(plan.message(selectedHall, selectedMovie), "确认录入影片", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (plan.savePlan())
                {
                    MessageBox.Show("录入成功。", "", MessageBoxButtons.OK);
                    //读取所有场次信息。
                    ArrayList all = PlanBLL.getAllPlan();
                    this.allPlan = all;
                    //TVPRPlan控件初始化。
                    this.TVPRPlan.Nodes.Clear();
                    ArrayList tempArr = new ArrayList();
                    for (int i = 0; i < allMovie.Count; ++i)
                    {
                        //第一层节点为所有影片。
                        TreeNode temp = this.TVPRPlan.Nodes.Add(allMovie[i].ToString());
                        temp.Tag = (MovieBLL)allMovie[i];
                        //将每一场次装载到对应影片的节点下。
                        tempArr.Clear();
                        for (int j = 0; j < allPlan.Count; ++j)
                        {
                            selectedPlan = (PlanBLL)allPlan[j];
                            if (selectedPlan.MovieId == ((MovieBLL)allMovie[i]).MovieId)
                            {
                                tempArr.Add(selectedPlan);
                            }
                        }
                        sort(tempArr);
                        for (int j = 0; j < tempArr.Count; ++j)
                        {
                            selectedPlan = (PlanBLL)tempArr[j];
                            temp.Nodes.Add(selectedPlan.getTime()).Tag = selectedPlan;
                        }
                    }
                    selectedPlan = null;
                }
                else
                {
                    MessageBox.Show("录入失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //选择影厅变更事件。
        private void LBPRHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHall = (HallBLL)this.LBPRHall.SelectedItem;
        }

        //票价输入控制只能为浮点数。
        private void TBPRPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、退格或者删除。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == 46)
            {
                //浮点数第一个字符不能为小数点
                if (this.TBPRPrice.TextLength == 0)
                {
                    e.Handled = true;
                    return;
                }
                //浮点数不能有两个小数点
                else
                {
                    double f;
                    if (!double.TryParse(this.TBPRPrice.Text + e.KeyChar.ToString(), out f))
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        //节点选择变更事件(查询场次信息)。
        private void TVPRPlan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.TVPRPlan.SelectedNode.Parent != null)
            {
                MovieBLL movie = (MovieBLL)this.TVPRPlan.SelectedNode.Parent.Tag;
                this.TBPRMName.Text = movie.MovieName;
                this.PBPRPoster.ImageLocation = movie.Poster;
                this.TBPRActor.Text = movie.Actor;
                this.TBPRDirector.Text = movie.Director;
                this.TBPRType.Text = movie.MovieType;
                selectedPlan = (PlanBLL)this.TVPRPlan.SelectedNode.Tag;
                this.TBPRMStart.Text = selectedPlan.TStart;
                this.TBPRMEnd.Text = selectedPlan.TEnd;
                this.TBPRMPrice.Text = Convert.ToString(selectedPlan.Price);
                this.TBPRMDStart.Text = movie.Start;
                this.TBPRMDEnd.Text = movie.End;
                for (int i = 0; i < allHall.Count; ++i)
                {
                    if (((HallBLL)allHall[i]).HallId == selectedPlan.HallId)
                    {
                        this.TBPRHName.Text = ((HallBLL)allHall[i]).HallName;
                        break;
                    }
                }
            }
            else
            {
                selectedPlan = null;
                MovieBLL movie = (MovieBLL)this.TVPRPlan.SelectedNode.Tag;
                this.TBPRMName.Text = movie.MovieName;
                this.PBPRPoster.ImageLocation = movie.Poster;
                this.TBPRActor.Text = movie.Actor;
                this.TBPRDirector.Text = movie.Director;
                this.TBPRType.Text = movie.MovieType;
                this.TBPRMDStart.Text = movie.Start;
                this.TBPRMDEnd.Text = movie.End;
                this.TBPRMStart.Text = "";
                this.TBPRMEnd.Text = "";
                this.TBPRMPrice.Text = "";
                this.TBPRHName.Text = "";
            }
        }

        //开始时间数值变更事件。
        private void DTPPRStart_ValueChanged(object sender, EventArgs e)
        {
            //DTPPREnd随影片时长变更。
            if (this.RBPRAuto.Checked == true && selectedMovie != null)
            {
                this.DTPPREnd.Value = this.DTPPRStart.Value.AddMinutes(Convert.ToInt32(selectedMovie.Time));
            }
        }

        //删除选择场次。
        private void BPRDelete_Click(object sender, EventArgs e)
        {
            if (this.TVPRPlan.SelectedNode == null || this.TVPRPlan.SelectedNode.Parent == null)
            {
                return;
            }
            //搜索场次相关的影片和影厅。
            MovieBLL tempMovie = null;
            HallBLL tempHall = null;
            for (int j = 0; j < allMovie.Count; ++j)
            {
                if (selectedPlan.MovieId == ((MovieBLL)allMovie[j]).MovieId)
                {
                    tempMovie = (MovieBLL)allMovie[j];
                    break;
                }
            }
            for (int j = 0; j < allHall.Count; ++j)
            {
                if (selectedPlan.HallId == ((HallBLL)allHall[j]).HallId)
                {
                    tempHall = (HallBLL)allHall[j];
                    break;
                }
            }
            if (MessageBox.Show(selectedPlan.message(tempHall,tempMovie), "确认删除场次", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selectedPlan.deletePlan())
                {
                    MessageBox.Show("删除成功。", "", MessageBoxButtons.OK);
                    //界面控件复原和更新。
                    this.TBPRMName.Text = null;
                    this.PBPRPoster.ImageLocation = null;
                    this.TBPRActor.Text = null;
                    this.TBPRDirector.Text = null;
                    this.TBPRType.Text = null;
                    this.TBPRMStart.Text = null;
                    this.TBPRMEnd.Text = null;
                    this.TBPRMPrice.Text = null;
                    this.TBPRHName.Text = null;
                    ArrayList all = PlanBLL.getAllPlan();
                    this.allPlan = all;
                    this.TVPRPlan.Nodes.Clear();
                    for (int i = 0; i < allMovie.Count; ++i)
                    {
                        //第一层节点为所有影片。
                        TreeNode temp = this.TVPRPlan.Nodes.Add(allMovie[i].ToString());
                        temp.Tag = (MovieBLL)allMovie[i];
                        //将每一场次装载到对应影片的节点下。
                        for (int j = 0; j < allPlan.Count; ++j)
                        {
                            selectedPlan = (PlanBLL)allPlan[j];
                            if (selectedPlan.MovieId == ((MovieBLL)allMovie[i]).MovieId)
                            {
                                temp.Nodes.Add(selectedPlan.getTime()).Tag = selectedPlan;
                            }
                        }
                    }
                    selectedPlan = null;
                }
                else
                {
                    MessageBox.Show("删除失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //修改选择场次的票价。
        private void BPRUpdatePrice_Click(object sender, EventArgs e)
        {
            if (this.TVPRPlan.SelectedNode == null || this.TVPRPlan.SelectedNode.Parent == null)
            {
                return;
            }
            if (this.BPRUpdatePrice.Text == "修改票价")
            {
                this.BPRUpdatePrice.Text = "保存";
                this.TBPRMPrice.ReadOnly = false;
            }
            else
            {
                string s = "原票价：" + this.selectedPlan.Price + "\n改为：   " + this.TBPRMPrice.Text;
                if (MessageBox.Show(s, "确认更新票价", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    double old = this.selectedPlan.Price;
                    this.selectedPlan.Price = Convert.ToDouble(this.TBPRMPrice.Text);
                    if (selectedPlan.updatePrice())
                    {
                        MessageBox.Show("更新成功。", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("更新失败。", "", MessageBoxButtons.OK);
                        this.selectedPlan.Price = old;
                    }
                }
                this.TBPRMPrice.ReadOnly = true;
                this.BPRUpdatePrice.Text = "修改票价";
            }
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
    }
}
