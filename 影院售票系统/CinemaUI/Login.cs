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
    public partial class Login : Form
    {
        bool mov = false;//初始化
        int xpos;
        int ypos;

        private ArrayList allUser; //存储所有用户信息。
        private UserBLL user;  //存储登录的用户。

        public Login()
        {
            InitializeComponent();
        }

        //鼠标离开。
        private void Login_MouseLeave(object sender, EventArgs e)
        {
            xpos = 0; //设置初始状态
            ypos = 0;
            mov = false;
        }

        //鼠标点击。
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            xpos = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
            ypos = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
        }

        //鼠标移动。
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.Left += MousePosition.X - xpos;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - ypos;//根据鼠标的y坐标窗体的顶部，即Y坐标
                xpos = MousePosition.X;
                ypos = MousePosition.Y;
            }
        }

        //鼠标释放
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;//停止移动
        }

        //退出事件
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //登录事件。
        private void BLogin_Click(object sender, EventArgs e)
        {
            if (this.TBName.Text == "")
            {
                MessageBox.Show("请输入帐号。", "", MessageBoxButtons.OK);
                return;
            }
            int i;
            for (i = 0; i < allUser.Count; ++i)
            {
                user = (UserBLL)allUser[i];
                if (user.Name == this.TBName.Text)
                {
                    break;
                }
            }
            if (i == allUser.Count)
            {
                MessageBox.Show("帐号不存在。", "", MessageBoxButtons.OK);
                return;
            }
            if (this.TBPassport.Text != user.Passport)
            {
                MessageBox.Show("密码错误。", "", MessageBoxButtons.OK);
                return;
            }
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.receiveUser(user);
            mainMenu.Show();
        }

        //登录界面加载事件。
        private void Login_Load(object sender, EventArgs e)
        {
            //初始化
            this.allUser = UserBLL.getAllUser();
        }
        
        //密码输入控制，只能是数字或字母。
        private void TBPassport_KeyPress(object sender, KeyPressEventArgs e)
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
