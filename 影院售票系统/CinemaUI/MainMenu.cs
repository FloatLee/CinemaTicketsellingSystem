using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 影院售票系统.CinemaUI;

namespace 影院售票系统
{
    public partial class MainMenu : Form
    {

        bool mov = false;//初始化
        int xpos;
        int ypos;

        private UserBLL user;  //存储用户信息。

        public MainMenu()
        {
            InitializeComponent();
        }

        //影厅查询。
        private void QueryHall_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：影厅查询";
            HallQuery hallQuery = new HallQuery();
            hallQuery.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(hallQuery);
            hallQuery.Show();
        }

        //影厅录入。
        private void NewHall_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：影厅录入";
            HallNew hallNew = new HallNew();
            hallNew.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(hallNew);
            hallNew.Show();
        }

        //退出系统。
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出系统。", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //影片查询。
        private void QueryMovie_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：影片查询";
            MovieQuery movieQuery = new MovieQuery();
            movieQuery.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(movieQuery);
            movieQuery.Show();
        }

        //影片录入。
        private void NewMovie_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：影片录入";
            MovieNew movieNew = new MovieNew();
            movieNew.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(movieNew);
            movieNew.Show();
        }

        //排片管理。
        private void Row_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：排片管理";
            PlanRows planRows = new PlanRows();
            planRows.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(planRows);
            planRows.Show();
        }

        //标题鼠标点击事件。
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            xpos = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
            ypos = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
        }

        //鼠标移动事件。
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.Left += MousePosition.X - xpos;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - ypos;//根据鼠标的y坐标窗体的顶部，即Y坐标
                xpos = MousePosition.X;
                ypos = MousePosition.Y;
            }
        }

        //鼠标释放事件。
        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;//停止移动
        }

        //鼠标离开事件。
        private void Title_MouseLeave(object sender, EventArgs e)
        {
            xpos = 0; //设置初始状态
            ypos = 0;
            mov = false;
        }

        //售票管理。
        private void Ticket_Click(object sender, EventArgs e)
        {
            this.BoardLevel.Text = "当前选择模块：售票管理";
            TicketSale ticketSale = new TicketSale();
            ticketSale.TopLevel = false;
            this.Windows.Controls.Clear();
            this.Windows.Controls.Add(ticketSale);
            ticketSale.Show();
        }

        //接受用户信息。
        public void receiveUser(UserBLL user)
        {
            this.user = user;
        }

        //窗体加载事件。
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Information.Text = "\n\n\n\n\n\n\n\n\n\n 当前身份：";
            if (this.user.Position == 1)
            {
                this.Information.Text += "\n\n   管理员";
            }
        }

    }
}
