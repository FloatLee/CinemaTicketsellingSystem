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
    public partial class MovieQuery : Form
    {
        private ArrayList oldMovie = new ArrayList(); //存储下架影片信息。
        private ArrayList nowMovie = new ArrayList(); //存储在映影片信息。
        private ArrayList furMovie = new ArrayList(); //存储将要上映影片信息。
        private ArrayList allMovie; //存储所有影片信息。
        private ArrayList nowType;  //当前查询模式。
        private MovieBLL selectedMovie; //存储当前选择影片。
        public MovieQuery()
        {
            InitializeComponent();
        }

        //影片查询窗体载入。
        private void MovieQuery_Load(object sender, EventArgs e)
        {
            //查询所有影片。
            allMovie = MovieBLL.getAllMovie();

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
            this.RBMQAll.Checked = true;
        }

        //选择影片发生变化事件（查询事件）。
        private void CBMQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            //改变选择的影片。
            selectedMovie = (MovieBLL)this.CBMQuery.SelectedItem;

            //初始化类型选择
            foreach (Control ctl in this.GBMType.Controls)
            {
                CheckBox cb = (CheckBox)ctl;
                cb.Checked = false;
            }

            //将选择的影片信息输出。
            this.TBMName.Text = selectedMovie.MovieName;
            this.TBMProducer.Text = selectedMovie.MovieName;
            this.TBMActor.Text = selectedMovie.Actor;
            this.TBMTime.Text = selectedMovie.Time;
            this.TBMIntrod.Text = selectedMovie.Introd;
            this.DTPMStart.Text = selectedMovie.Start;
            this.DTPMEnd.Text = selectedMovie.End;
            this.TBMDirector.Text = selectedMovie.Director;
            this.TBMNum.Text = selectedMovie.Num;
            this.PBMPoster.ImageLocation = selectedMovie.Poster;
            foreach (Control ctl in this.GBMType.Controls)
            {
                CheckBox cb = (CheckBox)ctl;
                if (selectedMovie.MovieType.Contains(cb.Text))
                {
                    cb.Checked = true;
                }
            }

            //如果在修改过程中更改影片操作处理
            this.BMQUpdate.Text = "修改";
            this.GBMQResult.Enabled = false;
        }

        //删除选中影片信息。
        private void BMQDelete_Click(object sender, EventArgs e)
        {
            //如果未选择影片时的错误处理。
            if (this.CBMQuery.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择影片。", "", MessageBoxButtons.OK);
                return;
            }

            //删除影片确认。
            if (MessageBox.Show(selectedMovie.message(), "确认删除影片", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selectedMovie.deleteMovie())
                {
                    MessageBox.Show("删除成功。", "", MessageBoxButtons.OK);

                    //移除内存中的已删除影片。
                    nowType.Remove(selectedMovie);

                    //触发CheckChanced事件来刷新并初始化ComboBox。
                    foreach (Control ctl in this.GBMQSelect.Controls)
                    {
                        RadioButton cb = (RadioButton)ctl;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;
                            cb.Checked = true;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("删除失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //选择全部影片查询。
        private void RBMQAll_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBMQAll.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = allMovie;

                //更新并初始化ComboBox。
                this.CBMQuery.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.CBMQuery.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.CBMQuery.SelectedIndex = -1;
                if (this.CBMQuery.Items.Count > 0)
                {
                    this.CBMQuery.Text = "请选择影片";
                }
                else
                {
                    this.CBMQuery.Text = "无影片记录";
                }

                //清空已查询内容。
                this.TBMName.Text = null;
                this.TBMProducer.Text = null;
                this.TBMActor.Text = null;
                this.TBMTime.Text = null;
                this.TBMIntrod.Text = null;
                this.DTPMStart.Text = null;
                this.DTPMEnd.Text = null;
                this.TBMDirector.Text = null;
                this.TBMNum.Text = null;
                this.PBMPoster.ImageLocation = null;
                foreach (Control ctl in this.GBMType.Controls)
                {
                    CheckBox cb = (CheckBox)ctl;
                    cb.Checked = false;
                }

                //如果在修改过程中更改影片操作处理
                this.BMQUpdate.Text = "修改";
                this.GBMQResult.Enabled = false;
            }
        }

        //选择下架影片查询。
        private void RBMQOld_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBMQOld.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = oldMovie;

                //更新并初始化ComboBox。
                this.CBMQuery.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.CBMQuery.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.CBMQuery.SelectedIndex = -1;
                if (this.CBMQuery.Items.Count > 0)
                {
                    this.CBMQuery.Text = "请选择影片";
                }
                else
                {
                    this.CBMQuery.Text = "无影片记录";
                }

                //清空已查询内容。
                this.TBMName.Text = null;
                this.TBMProducer.Text = null;
                this.TBMActor.Text = null;
                this.TBMTime.Text = null;
                this.TBMIntrod.Text = null;
                this.DTPMStart.Text = null;
                this.DTPMEnd.Text = null;
                this.TBMDirector.Text = null;
                this.TBMNum.Text = null;
                this.PBMPoster.ImageLocation = null;
                foreach (Control ctl in this.GBMType.Controls)
                {
                    CheckBox cb = (CheckBox)ctl;
                    cb.Checked = false;
                }

                //如果在修改过程中更改影片操作处理
                this.BMQUpdate.Text = "修改";
                this.GBMQResult.Enabled = false;
            }
        }

        //选择将上映影片查询。
        private void RBMQFurture_CheckedChanged(object sender, EventArgs e)
        {
            //当勾选时发生，取消勾选无响应。
            if (RBMQFurture.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = furMovie;

                //更新并初始化ComboBox。
                this.CBMQuery.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.CBMQuery.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.CBMQuery.SelectedIndex = -1;
                if (this.CBMQuery.Items.Count > 0)
                {
                    this.CBMQuery.Text = "请选择影片";
                }
                else
                {
                    this.CBMQuery.Text = "无影片记录";
                }

                //清空已查询内容。
                this.TBMName.Text = null;
                this.TBMProducer.Text = null;
                this.TBMActor.Text = null;
                this.TBMTime.Text = null;
                this.TBMIntrod.Text = null;
                this.DTPMStart.Text = null;
                this.DTPMEnd.Text = null;
                this.TBMDirector.Text = null;
                this.TBMNum.Text = null;
                this.PBMPoster.ImageLocation = null;
                foreach (Control ctl in this.GBMType.Controls)
                {
                    CheckBox cb = (CheckBox)ctl;
                    cb.Checked = false;
                }

                //如果在修改过程中更改影片操作处理
                this.BMQUpdate.Text = "修改";
                this.GBMQResult.Enabled = false;
            }
        }

        //选择上映影片查询。
        private void RBMQNow_CheckedChanged(object sender, EventArgs e)
        {
            ////当勾选时发生，取消勾选无响应。
            if (RBMQNow.Checked == true)
            {
                //改变当前查询影片数组。
                nowType = nowMovie;

                //更新并初始化ComboBox。
                this.CBMQuery.Items.Clear();
                for (int i = 0; i < nowType.Count; ++i)
                {
                    selectedMovie = (MovieBLL)this.nowType[i];
                    this.CBMQuery.Items.Add(selectedMovie);
                }
                this.selectedMovie = null;
                this.CBMQuery.SelectedIndex = -1;
                if (this.CBMQuery.Items.Count > 0)
                {
                    this.CBMQuery.Text = "请选择影片";
                }
                else
                {
                    this.CBMQuery.Text = "无影片记录";
                }

                //清空已查询内容。
                this.TBMName.Text = null;
                this.TBMProducer.Text = null;
                this.TBMActor.Text = null;
                this.TBMTime.Text = null;
                this.TBMIntrod.Text = null;
                this.DTPMStart.Text = null;
                this.DTPMEnd.Text = null;
                this.TBMDirector.Text = null;
                this.TBMNum.Text = null;
                this.PBMPoster.ImageLocation = null;
                foreach (Control ctl in this.GBMType.Controls)
                {
                    CheckBox cb = (CheckBox)ctl;
                    cb.Checked = false;
                }

                //如果在修改过程中更改影片操作处理
                this.BMQUpdate.Text = "修改";
                this.GBMQResult.Enabled = false;
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
                else if(a < b)
                {
                    return -1;
                }
            }
            return 0;
        }

        //修改选中影片信息。
        private void BMQUpdate_Click(object sender, EventArgs e)
        {
            //如果未选择影片时的错误处理。
            if (this.CBMQuery.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择影片。", "", MessageBoxButtons.OK);
                return;
            }

            //第一次点击，影片内容将可以修改。
            if (this.BMQUpdate.Text == "修改")
            {
                this.BMQUpdate.Text = "保存";
                this.BMPoster.Visible = true;
                this.GBMQResult.Enabled = true;
            }

            //第二次点击，保存修改后的内容。
            else
            {
                //新建一个影片对象存储修改后的影片信息。
                MovieBLL movie = new MovieBLL();
                movie.MovieId = selectedMovie.MovieId;
                if (this.TBMName.Text == "")
                {
                    movie.MovieName = "未命名";
                }
                else
                {
                    movie.MovieName = this.TBMName.Text;
                }
                if (this.TBMProducer.Text == "")
                {
                    movie.Producer = "无出品方";
                }
                else
                {
                    movie.Producer = this.TBMProducer.Text;
                }
                if (this.TBMDirector.Text == "")
                {
                    movie.Director = "无导演";
                }
                else
                {
                    movie.Director = this.TBMDirector.Text;
                }
                if (this.TBMActor.Text == "")
                {
                    movie.Actor = "无演员";
                }
                else
                {
                    movie.Actor = this.TBMActor.Text;
                }
                if (this.TBMNum.Text == "")
                {
                    movie.Num = "0";
                }
                else
                {
                    movie.Num = this.TBMNum.Text;
                }
                if (this.TBMIntrod.Text == "")
                {
                    movie.Introd = "无简介";
                }
                else
                {
                    movie.Introd = this.TBMIntrod.Text;
                }
                if (this.TBMTime.Text == "")
                {
                    movie.Time = "0";
                }
                else if (Convert.ToInt32(this.TBMTime.Text) > 300)
                {
                    MessageBox.Show("影片时长不能超过300分钟（5小时）。", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    movie.Time = this.TBMTime.Text;
                }
                if ((this.DTPMEnd.Value - this.DTPMStart.Value).Days < 0)
                {
                    MessageBox.Show("结束日期不能小于放映日期。", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    movie.Start = this.DTPMStart.Text;
                    movie.End = this.DTPMEnd.Text;
                }
                if (this.PBMPoster.Image == null)
                {
                    movie.Poster = "无图片路径";
                }
                else
                {
                    movie.Poster = this.PBMPoster.ImageLocation;
                }
                bool flag = false;
                movie.MovieType = "";
                foreach (Control ctl in this.GBMType.Controls)
                {
                    CheckBox cb = (CheckBox)ctl;
                    if (cb.Checked == true)
                    {
                        if (flag)
                        {
                            movie.MovieType += "," + cb.Text;
                        }
                        else
                        {
                            movie.MovieType += cb.Text;
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    movie.MovieType = "无";
                }

                //输出修改后的影片信息并确认。
                if (MessageBox.Show("更新后的影片信息：\n" + movie.message(), "确认更新影片信息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (movie.updateMovie())
                    {
                        MessageBox.Show("更新成功。", "", MessageBoxButtons.OK);

                        //判断当前是不是查询全部影片。
                        if (this.RBMQAll.Checked == true)
                        {
                            flag = true;
                        }
                        else
                        {
                            allMovie.Remove(selectedMovie);
                            allMovie.Add(movie);
                            flag = false;
                        }

                        //修改内存中的影片信息。
                        nowType.Remove(selectedMovie);
                        selectedMovie = movie;

                        //将修改后的影片重新归类。
                        string nowTime = DateTime.Now.ToLongDateString().ToString();
                        if (compareDate(selectedMovie.Start, nowTime) == 1)
                        {
                            furMovie.Add(selectedMovie);
                            if (!flag)
                            {
                                this.RBMQFurture.Checked = true;
                            }
                        }
                        else if (compareDate(selectedMovie.End, nowTime) == -1)
                        {
                            oldMovie.Add(selectedMovie);
                            if (!flag)
                            {
                                this.RBMQOld.Checked = true;
                            }
                        }
                        else
                        {
                            nowMovie.Add(selectedMovie);
                            if (!flag)
                            {
                                this.RBMQNow.Checked = true;
                            }
                        }

                        //更新并初始化ComboBox。
                        this.CBMQuery.Items.Clear();
                        for (int i = 0; i < nowType.Count; ++i)
                        {
                            selectedMovie = (MovieBLL)this.nowType[i];
                            this.CBMQuery.Items.Add(selectedMovie);
                        }
                        this.selectedMovie = null;
                        this.CBMQuery.SelectedIndex = -1;
                        if (this.CBMQuery.Items.Count > 0)
                        {
                            this.CBMQuery.Text = "请选择影片";
                        }
                        else
                        {
                            this.CBMQuery.Text = "无影片记录";
                        }

                        //界面恢复成修改后的状态。
                        selectedMovie = movie;
                        if (!flag)
                        {
                            this.CBMQuery.SelectedIndex = this.CBMQuery.Items.IndexOf(selectedMovie);
                            this.CBMQuery.Text = selectedMovie.MovieName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("更新失败。", "", MessageBoxButtons.OK);
                    }
                }

                //其余控件恢复成修改后状态。
                this.BMPoster.Visible = false;
                this.BMQUpdate.Text = "修改";
                this.GBMQResult.Enabled = false;
            }
        }

        //更新图片事件。
        private void BMPoster_Click(object sender, EventArgs e)
        {
            //打开文件选择对话框。
            OpenFileDialog openpic = new OpenFileDialog();

            //选择文件类型设置。
            openpic.Filter = "bmp 文件jpg文件(*.jpg)|*.jpg|(*.bmp)|*.bmp|ico文件(*.ico)|*.ico|jpeg文件(*.jpeg)|*.jpeg";
            openpic.Title = "打开图片";
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                //将选择的图片放入PictureBox。
                this.PBMPoster.ImageLocation = openpic.FileName;
            }
        }

        //播放许可证输入控制。
        private void TBMNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、字母、退格和删除外的字符。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8 && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
                return;
            }
        }

        //影片时长控制。
        private void TBMTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、退格和删除外的字符。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

    }
}
