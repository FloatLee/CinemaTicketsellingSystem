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
    public partial class MovieNew : Form
    {
        public MovieNew()
        {
            InitializeComponent();
        }

        //影片录入事件。
        private void BMNew_Click(object sender, EventArgs e)
        {
            //新建影片对象存储新增影片信息。
            MovieBLL movie = new MovieBLL();
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
            if((this.DTPMEnd.Value - this.DTPMStart.Value).Days < 0)
            {
                MessageBox.Show("结束日期不能小于放映日期。","",MessageBoxButtons.OK);
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
            //遍历容器获得所勾选的类型。
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

            //输出新增影片信息并确认是否录入。
            if (MessageBox.Show(movie.message(), "确认录入影片", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (movie.saveMovie())
                {
                    MessageBox.Show("录入成功。", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("录入失败。", "", MessageBoxButtons.OK);
                }
            }
        }

        //选择图片事件。  
        private void BMPoster_Click(object sender, EventArgs e)
        {
            //打开文件选择对话框。
            OpenFileDialog openpic = new OpenFileDialog();

            //限制选择文件的类型。
            openpic.Filter = "jpg文件(*.jpg)|*.jpg|bmp 文件(*.bmp)|*.bmp|ico文件(*.ico)|*.ico|jpeg文件(*.jpeg)|*.jpeg";
            openpic.Title = "打开图片";
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                //将选择的图片放入PictureBox。
                this.PBMPoster.ImageLocation = openpic.FileName;
            }
        }

        //影片时长输入限制。
        private void TBMTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、退格和删除外的字符。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        //播放许可证号输入限制。
        private void TBMNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断键入的字符是否是数字、字母、退格和删除外的字符。
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 46 && (int)e.KeyChar != 8 && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {
                e.Handled = true;
                return;
            }
        }


    }
}
