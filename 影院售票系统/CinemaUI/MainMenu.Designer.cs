namespace 影院售票系统
{
    partial class MainMenu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Windows = new System.Windows.Forms.Panel();
            this.BoardLevel = new System.Windows.Forms.Label();
            this.BoardRight = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Hall = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryHall = new System.Windows.Forms.ToolStripMenuItem();
            this.NewHall = new System.Windows.Forms.ToolStripMenuItem();
            this.Movie = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.Row = new System.Windows.Forms.ToolStripMenuItem();
            this.Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Windows
            // 
            this.Windows.BackgroundImage = global::影院售票系统.Properties.Resources.PicWindow;
            this.Windows.Location = new System.Drawing.Point(74, 53);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(900, 450);
            this.Windows.TabIndex = 2;
            this.Windows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Windows.MouseLeave += new System.EventHandler(this.Title_MouseLeave);
            this.Windows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Windows.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // BoardLevel
            // 
            this.BoardLevel.BackColor = System.Drawing.Color.Silver;
            this.BoardLevel.Image = global::影院售票系统.Properties.Resources.PicLevel;
            this.BoardLevel.Location = new System.Drawing.Point(-2, 500);
            this.BoardLevel.Name = "BoardLevel";
            this.BoardLevel.Size = new System.Drawing.Size(992, 29);
            this.BoardLevel.TabIndex = 5;
            // 
            // BoardRight
            // 
            this.BoardRight.BackColor = System.Drawing.Color.Silver;
            this.BoardRight.Image = global::影院售票系统.Properties.Resources.PicRight;
            this.BoardRight.Location = new System.Drawing.Point(974, 0);
            this.BoardRight.Name = "BoardRight";
            this.BoardRight.Size = new System.Drawing.Size(16, 506);
            this.BoardRight.TabIndex = 4;
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Silver;
            this.Information.Image = global::影院售票系统.Properties.Resources.PicInformation;
            this.Information.Location = new System.Drawing.Point(0, 109);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(74, 397);
            this.Information.TabIndex = 3;
            this.Information.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Information.MouseLeave += new System.EventHandler(this.Title_MouseLeave);
            this.Information.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Information.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Silver;
            this.Title.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Image = global::影院售票系统.Properties.Resources.PicTitle;
            this.Title.Location = new System.Drawing.Point(70, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(904, 53);
            this.Title.TabIndex = 1;
            this.Title.Text = "影 院 售 票 系 统";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseLeave += new System.EventHandler(this.Title_MouseLeave);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // Menu
            // 
            this.Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Menu.BackColor = System.Drawing.Color.Silver;
            this.Menu.BackgroundImage = global::影院售票系统.Properties.Resources.PicMenu;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hall,
            this.Movie,
            this.Row,
            this.Ticket,
            this.Exit});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.Menu.Location = new System.Drawing.Point(0, 1);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(74, 109);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Menu.MouseLeave += new System.EventHandler(this.Title_MouseLeave);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // Hall
            // 
            this.Hall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryHall,
            this.NewHall});
            this.Hall.Name = "Hall";
            this.Hall.Size = new System.Drawing.Size(68, 21);
            this.Hall.Text = "影厅管理";
            // 
            // QueryHall
            // 
            this.QueryHall.Name = "QueryHall";
            this.QueryHall.Size = new System.Drawing.Size(124, 22);
            this.QueryHall.Text = "影厅查询";
            this.QueryHall.Click += new System.EventHandler(this.QueryHall_Click);
            // 
            // NewHall
            // 
            this.NewHall.Name = "NewHall";
            this.NewHall.Size = new System.Drawing.Size(124, 22);
            this.NewHall.Text = "影厅录入";
            this.NewHall.Click += new System.EventHandler(this.NewHall_Click);
            // 
            // Movie
            // 
            this.Movie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryMovie,
            this.NewMovie});
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(68, 21);
            this.Movie.Text = "影片管理";
            // 
            // QueryMovie
            // 
            this.QueryMovie.Name = "QueryMovie";
            this.QueryMovie.Size = new System.Drawing.Size(124, 22);
            this.QueryMovie.Text = "影片查询";
            this.QueryMovie.Click += new System.EventHandler(this.QueryMovie_Click);
            // 
            // NewMovie
            // 
            this.NewMovie.Name = "NewMovie";
            this.NewMovie.Size = new System.Drawing.Size(124, 22);
            this.NewMovie.Text = "影片录入";
            this.NewMovie.Click += new System.EventHandler(this.NewMovie_Click);
            // 
            // Row
            // 
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(68, 21);
            this.Row.Text = "排片管理";
            this.Row.Click += new System.EventHandler(this.Row_Click);
            // 
            // Ticket
            // 
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(68, 21);
            this.Ticket.Text = "售票管理";
            this.Ticket.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 21);
            this.Exit.Text = "退出系统";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(989, 527);
            this.Controls.Add(this.BoardLevel);
            this.Controls.Add(this.BoardRight);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Windows);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Hall;
        private System.Windows.Forms.ToolStripMenuItem Movie;
        private System.Windows.Forms.ToolStripMenuItem Row;
        private System.Windows.Forms.ToolStripMenuItem Ticket;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem QueryHall;
        private System.Windows.Forms.ToolStripMenuItem NewHall;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Windows;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.ToolStripMenuItem QueryMovie;
        private System.Windows.Forms.ToolStripMenuItem NewMovie;
        private System.Windows.Forms.Label BoardRight;
        private System.Windows.Forms.Label BoardLevel;
    }
}

