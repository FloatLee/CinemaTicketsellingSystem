namespace 影院售票系统.CinemaUI
{
    partial class PlanRows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBPRMovie = new System.Windows.Forms.ListBox();
            this.DTPPRStart = new System.Windows.Forms.DateTimePicker();
            this.DTPPREnd = new System.Windows.Forms.DateTimePicker();
            this.TBPRPrice = new System.Windows.Forms.TextBox();
            this.LPRStart = new System.Windows.Forms.Label();
            this.LPREnd = new System.Windows.Forms.Label();
            this.LPRPrice = new System.Windows.Forms.Label();
            this.LPRHall = new System.Windows.Forms.Label();
            this.LPRMovie = new System.Windows.Forms.Label();
            this.BPRNew = new System.Windows.Forms.Button();
            this.GBPRMovie = new System.Windows.Forms.GroupBox();
            this.RBPRNow = new System.Windows.Forms.RadioButton();
            this.RBPRFur = new System.Windows.Forms.RadioButton();
            this.RBPROld = new System.Windows.Forms.RadioButton();
            this.RBPRAll = new System.Windows.Forms.RadioButton();
            this.GBPRSelect = new System.Windows.Forms.GroupBox();
            this.RBPRHand = new System.Windows.Forms.RadioButton();
            this.RBPRAuto = new System.Windows.Forms.RadioButton();
            this.TVPRPlan = new System.Windows.Forms.TreeView();
            this.LBPRHall = new System.Windows.Forms.ListBox();
            this.PBPRPoster = new System.Windows.Forms.PictureBox();
            this.TBPRMName = new System.Windows.Forms.TextBox();
            this.LPRMName = new System.Windows.Forms.Label();
            this.TBPRActor = new System.Windows.Forms.TextBox();
            this.LPRActor = new System.Windows.Forms.Label();
            this.TBPRDirector = new System.Windows.Forms.TextBox();
            this.LPRDirector = new System.Windows.Forms.Label();
            this.TBPRType = new System.Windows.Forms.TextBox();
            this.LPRType = new System.Windows.Forms.Label();
            this.TBPRMPrice = new System.Windows.Forms.TextBox();
            this.LPRMPrice = new System.Windows.Forms.Label();
            this.TBPRMEnd = new System.Windows.Forms.TextBox();
            this.LPRMEnd = new System.Windows.Forms.Label();
            this.TBPRMStart = new System.Windows.Forms.TextBox();
            this.LPRMStart = new System.Windows.Forms.Label();
            this.TBPRHName = new System.Windows.Forms.TextBox();
            this.LPRHName = new System.Windows.Forms.Label();
            this.BPRUpdatePrice = new System.Windows.Forms.Button();
            this.BPRDelete = new System.Windows.Forms.Button();
            this.TBPRMDEnd = new System.Windows.Forms.TextBox();
            this.LPRMDEnd = new System.Windows.Forms.Label();
            this.TBPRMDStart = new System.Windows.Forms.TextBox();
            this.LPRMDStart = new System.Windows.Forms.Label();
            this.GBPRMovie.SuspendLayout();
            this.GBPRSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPRPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // LBPRMovie
            // 
            this.LBPRMovie.FormattingEnabled = true;
            this.LBPRMovie.ItemHeight = 12;
            this.LBPRMovie.Location = new System.Drawing.Point(114, 146);
            this.LBPRMovie.Name = "LBPRMovie";
            this.LBPRMovie.Size = new System.Drawing.Size(137, 88);
            this.LBPRMovie.TabIndex = 1;
            this.LBPRMovie.SelectedIndexChanged += new System.EventHandler(this.LBPRMovie_SelectedIndexChanged);
            // 
            // DTPPRStart
            // 
            this.DTPPRStart.Location = new System.Drawing.Point(114, 280);
            this.DTPPRStart.Name = "DTPPRStart";
            this.DTPPRStart.ShowUpDown = true;
            this.DTPPRStart.Size = new System.Drawing.Size(161, 21);
            this.DTPPRStart.TabIndex = 2;
            this.DTPPRStart.ValueChanged += new System.EventHandler(this.DTPPRStart_ValueChanged);
            // 
            // DTPPREnd
            // 
            this.DTPPREnd.Location = new System.Drawing.Point(114, 310);
            this.DTPPREnd.Name = "DTPPREnd";
            this.DTPPREnd.ShowUpDown = true;
            this.DTPPREnd.Size = new System.Drawing.Size(161, 21);
            this.DTPPREnd.TabIndex = 3;
            // 
            // TBPRPrice
            // 
            this.TBPRPrice.Location = new System.Drawing.Point(114, 356);
            this.TBPRPrice.MaxLength = 6;
            this.TBPRPrice.Name = "TBPRPrice";
            this.TBPRPrice.Size = new System.Drawing.Size(100, 21);
            this.TBPRPrice.TabIndex = 4;
            this.TBPRPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPRPrice_KeyPress);
            // 
            // LPRStart
            // 
            this.LPRStart.AutoSize = true;
            this.LPRStart.Location = new System.Drawing.Point(43, 289);
            this.LPRStart.Name = "LPRStart";
            this.LPRStart.Size = new System.Drawing.Size(65, 12);
            this.LPRStart.TabIndex = 5;
            this.LPRStart.Text = "开始时间：";
            // 
            // LPREnd
            // 
            this.LPREnd.AutoSize = true;
            this.LPREnd.Location = new System.Drawing.Point(43, 316);
            this.LPREnd.Name = "LPREnd";
            this.LPREnd.Size = new System.Drawing.Size(65, 12);
            this.LPREnd.TabIndex = 6;
            this.LPREnd.Text = "结束时间：";
            // 
            // LPRPrice
            // 
            this.LPRPrice.AutoSize = true;
            this.LPRPrice.Location = new System.Drawing.Point(67, 359);
            this.LPRPrice.Name = "LPRPrice";
            this.LPRPrice.Size = new System.Drawing.Size(41, 12);
            this.LPRPrice.TabIndex = 7;
            this.LPRPrice.Text = "票价：";
            // 
            // LPRHall
            // 
            this.LPRHall.AutoSize = true;
            this.LPRHall.Location = new System.Drawing.Point(55, 9);
            this.LPRHall.Name = "LPRHall";
            this.LPRHall.Size = new System.Drawing.Size(53, 12);
            this.LPRHall.TabIndex = 8;
            this.LPRHall.Text = "放映厅：";
            // 
            // LPRMovie
            // 
            this.LPRMovie.AutoSize = true;
            this.LPRMovie.Location = new System.Drawing.Point(67, 155);
            this.LPRMovie.Name = "LPRMovie";
            this.LPRMovie.Size = new System.Drawing.Size(41, 12);
            this.LPRMovie.TabIndex = 9;
            this.LPRMovie.Text = "影片：";
            // 
            // BPRNew
            // 
            this.BPRNew.Location = new System.Drawing.Point(125, 396);
            this.BPRNew.Name = "BPRNew";
            this.BPRNew.Size = new System.Drawing.Size(75, 23);
            this.BPRNew.TabIndex = 10;
            this.BPRNew.Text = "录入排片";
            this.BPRNew.UseVisualStyleBackColor = true;
            this.BPRNew.Click += new System.EventHandler(this.BPRNew_Click);
            // 
            // GBPRMovie
            // 
            this.GBPRMovie.Controls.Add(this.RBPRNow);
            this.GBPRMovie.Controls.Add(this.RBPRFur);
            this.GBPRMovie.Controls.Add(this.RBPROld);
            this.GBPRMovie.Controls.Add(this.RBPRAll);
            this.GBPRMovie.Location = new System.Drawing.Point(46, 98);
            this.GBPRMovie.Name = "GBPRMovie";
            this.GBPRMovie.Size = new System.Drawing.Size(213, 42);
            this.GBPRMovie.TabIndex = 11;
            this.GBPRMovie.TabStop = false;
            this.GBPRMovie.Text = "影片选择";
            // 
            // RBPRNow
            // 
            this.RBPRNow.AutoSize = true;
            this.RBPRNow.Location = new System.Drawing.Point(6, 20);
            this.RBPRNow.Name = "RBPRNow";
            this.RBPRNow.Size = new System.Drawing.Size(47, 16);
            this.RBPRNow.TabIndex = 4;
            this.RBPRNow.TabStop = true;
            this.RBPRNow.Text = "在映";
            this.RBPRNow.UseVisualStyleBackColor = true;
            this.RBPRNow.CheckedChanged += new System.EventHandler(this.RBPRNow_CheckedChanged);
            // 
            // RBPRFur
            // 
            this.RBPRFur.AutoSize = true;
            this.RBPRFur.Location = new System.Drawing.Point(55, 20);
            this.RBPRFur.Name = "RBPRFur";
            this.RBPRFur.Size = new System.Drawing.Size(47, 16);
            this.RBPRFur.TabIndex = 3;
            this.RBPRFur.TabStop = true;
            this.RBPRFur.Text = "未映";
            this.RBPRFur.UseVisualStyleBackColor = true;
            this.RBPRFur.CheckedChanged += new System.EventHandler(this.RBPRFur_CheckedChanged);
            // 
            // RBPROld
            // 
            this.RBPROld.AutoSize = true;
            this.RBPROld.Location = new System.Drawing.Point(108, 20);
            this.RBPROld.Name = "RBPROld";
            this.RBPROld.Size = new System.Drawing.Size(47, 16);
            this.RBPROld.TabIndex = 2;
            this.RBPROld.TabStop = true;
            this.RBPROld.Text = "下映";
            this.RBPROld.UseVisualStyleBackColor = true;
            this.RBPROld.CheckedChanged += new System.EventHandler(this.RBPROld_CheckedChanged);
            // 
            // RBPRAll
            // 
            this.RBPRAll.AutoSize = true;
            this.RBPRAll.Location = new System.Drawing.Point(161, 20);
            this.RBPRAll.Name = "RBPRAll";
            this.RBPRAll.Size = new System.Drawing.Size(47, 16);
            this.RBPRAll.TabIndex = 1;
            this.RBPRAll.TabStop = true;
            this.RBPRAll.Text = "全部";
            this.RBPRAll.UseVisualStyleBackColor = true;
            this.RBPRAll.CheckedChanged += new System.EventHandler(this.RBPRAll_CheckedChanged);
            // 
            // GBPRSelect
            // 
            this.GBPRSelect.Controls.Add(this.RBPRHand);
            this.GBPRSelect.Controls.Add(this.RBPRAuto);
            this.GBPRSelect.Location = new System.Drawing.Point(125, 240);
            this.GBPRSelect.Name = "GBPRSelect";
            this.GBPRSelect.Size = new System.Drawing.Size(118, 40);
            this.GBPRSelect.TabIndex = 12;
            this.GBPRSelect.TabStop = false;
            this.GBPRSelect.Text = "放映时间设置选择";
            // 
            // RBPRHand
            // 
            this.RBPRHand.AutoSize = true;
            this.RBPRHand.Location = new System.Drawing.Point(62, 20);
            this.RBPRHand.Name = "RBPRHand";
            this.RBPRHand.Size = new System.Drawing.Size(47, 16);
            this.RBPRHand.TabIndex = 1;
            this.RBPRHand.TabStop = true;
            this.RBPRHand.Text = "手动";
            this.RBPRHand.UseVisualStyleBackColor = true;
            this.RBPRHand.CheckedChanged += new System.EventHandler(this.RBPRHand_CheckedChanged);
            // 
            // RBPRAuto
            // 
            this.RBPRAuto.AutoSize = true;
            this.RBPRAuto.Location = new System.Drawing.Point(6, 20);
            this.RBPRAuto.Name = "RBPRAuto";
            this.RBPRAuto.Size = new System.Drawing.Size(47, 16);
            this.RBPRAuto.TabIndex = 0;
            this.RBPRAuto.TabStop = true;
            this.RBPRAuto.Text = "自动";
            this.RBPRAuto.UseVisualStyleBackColor = true;
            this.RBPRAuto.CheckedChanged += new System.EventHandler(this.RBPRAuto_CheckedChanged);
            // 
            // TVPRPlan
            // 
            this.TVPRPlan.Location = new System.Drawing.Point(337, 13);
            this.TVPRPlan.Name = "TVPRPlan";
            this.TVPRPlan.Size = new System.Drawing.Size(210, 422);
            this.TVPRPlan.TabIndex = 13;
            this.TVPRPlan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVPRPlan_AfterSelect);
            // 
            // LBPRHall
            // 
            this.LBPRHall.FormattingEnabled = true;
            this.LBPRHall.ItemHeight = 12;
            this.LBPRHall.Location = new System.Drawing.Point(114, 9);
            this.LBPRHall.Name = "LBPRHall";
            this.LBPRHall.Size = new System.Drawing.Size(137, 64);
            this.LBPRHall.TabIndex = 14;
            this.LBPRHall.SelectedIndexChanged += new System.EventHandler(this.LBPRHall_SelectedIndexChanged);
            // 
            // PBPRPoster
            // 
            this.PBPRPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBPRPoster.Location = new System.Drawing.Point(553, 45);
            this.PBPRPoster.Name = "PBPRPoster";
            this.PBPRPoster.Size = new System.Drawing.Size(140, 200);
            this.PBPRPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPRPoster.TabIndex = 45;
            this.PBPRPoster.TabStop = false;
            // 
            // TBPRMName
            // 
            this.TBPRMName.Location = new System.Drawing.Point(598, 13);
            this.TBPRMName.MaxLength = 50;
            this.TBPRMName.Name = "TBPRMName";
            this.TBPRMName.ReadOnly = true;
            this.TBPRMName.Size = new System.Drawing.Size(95, 21);
            this.TBPRMName.TabIndex = 47;
            // 
            // LPRMName
            // 
            this.LPRMName.AutoSize = true;
            this.LPRMName.Location = new System.Drawing.Point(551, 16);
            this.LPRMName.Name = "LPRMName";
            this.LPRMName.Size = new System.Drawing.Size(41, 12);
            this.LPRMName.TabIndex = 46;
            this.LPRMName.Text = "片名：";
            // 
            // TBPRActor
            // 
            this.TBPRActor.Location = new System.Drawing.Point(748, 77);
            this.TBPRActor.MaxLength = 50;
            this.TBPRActor.Name = "TBPRActor";
            this.TBPRActor.ReadOnly = true;
            this.TBPRActor.Size = new System.Drawing.Size(93, 21);
            this.TBPRActor.TabIndex = 49;
            // 
            // LPRActor
            // 
            this.LPRActor.AutoSize = true;
            this.LPRActor.Location = new System.Drawing.Point(701, 80);
            this.LPRActor.Name = "LPRActor";
            this.LPRActor.Size = new System.Drawing.Size(41, 12);
            this.LPRActor.TabIndex = 51;
            this.LPRActor.Text = "主演：";
            // 
            // TBPRDirector
            // 
            this.TBPRDirector.Location = new System.Drawing.Point(748, 50);
            this.TBPRDirector.MaxLength = 50;
            this.TBPRDirector.Name = "TBPRDirector";
            this.TBPRDirector.ReadOnly = true;
            this.TBPRDirector.Size = new System.Drawing.Size(93, 21);
            this.TBPRDirector.TabIndex = 48;
            // 
            // LPRDirector
            // 
            this.LPRDirector.AutoSize = true;
            this.LPRDirector.Location = new System.Drawing.Point(701, 53);
            this.LPRDirector.Name = "LPRDirector";
            this.LPRDirector.Size = new System.Drawing.Size(41, 12);
            this.LPRDirector.TabIndex = 50;
            this.LPRDirector.Text = "导演：";
            // 
            // TBPRType
            // 
            this.TBPRType.Location = new System.Drawing.Point(748, 105);
            this.TBPRType.MaxLength = 50;
            this.TBPRType.Name = "TBPRType";
            this.TBPRType.ReadOnly = true;
            this.TBPRType.Size = new System.Drawing.Size(93, 21);
            this.TBPRType.TabIndex = 52;
            // 
            // LPRType
            // 
            this.LPRType.AutoSize = true;
            this.LPRType.Location = new System.Drawing.Point(701, 108);
            this.LPRType.Name = "LPRType";
            this.LPRType.Size = new System.Drawing.Size(41, 12);
            this.LPRType.TabIndex = 53;
            this.LPRType.Text = "类型：";
            // 
            // TBPRMPrice
            // 
            this.TBPRMPrice.Location = new System.Drawing.Point(598, 343);
            this.TBPRMPrice.MaxLength = 50;
            this.TBPRMPrice.Name = "TBPRMPrice";
            this.TBPRMPrice.ReadOnly = true;
            this.TBPRMPrice.Size = new System.Drawing.Size(93, 21);
            this.TBPRMPrice.TabIndex = 60;
            // 
            // LPRMPrice
            // 
            this.LPRMPrice.AutoSize = true;
            this.LPRMPrice.Location = new System.Drawing.Point(551, 346);
            this.LPRMPrice.Name = "LPRMPrice";
            this.LPRMPrice.Size = new System.Drawing.Size(41, 12);
            this.LPRMPrice.TabIndex = 61;
            this.LPRMPrice.Text = "票价：";
            // 
            // TBPRMEnd
            // 
            this.TBPRMEnd.Location = new System.Drawing.Point(598, 316);
            this.TBPRMEnd.MaxLength = 50;
            this.TBPRMEnd.Name = "TBPRMEnd";
            this.TBPRMEnd.ReadOnly = true;
            this.TBPRMEnd.Size = new System.Drawing.Size(176, 21);
            this.TBPRMEnd.TabIndex = 58;
            // 
            // LPRMEnd
            // 
            this.LPRMEnd.AutoSize = true;
            this.LPRMEnd.Location = new System.Drawing.Point(551, 319);
            this.LPRMEnd.Name = "LPRMEnd";
            this.LPRMEnd.Size = new System.Drawing.Size(41, 12);
            this.LPRMEnd.TabIndex = 59;
            this.LPRMEnd.Text = "结束：";
            // 
            // TBPRMStart
            // 
            this.TBPRMStart.Location = new System.Drawing.Point(598, 288);
            this.TBPRMStart.MaxLength = 50;
            this.TBPRMStart.Name = "TBPRMStart";
            this.TBPRMStart.ReadOnly = true;
            this.TBPRMStart.Size = new System.Drawing.Size(176, 21);
            this.TBPRMStart.TabIndex = 56;
            // 
            // LPRMStart
            // 
            this.LPRMStart.AutoSize = true;
            this.LPRMStart.Location = new System.Drawing.Point(551, 291);
            this.LPRMStart.Name = "LPRMStart";
            this.LPRMStart.Size = new System.Drawing.Size(41, 12);
            this.LPRMStart.TabIndex = 57;
            this.LPRMStart.Text = "开始：";
            // 
            // TBPRHName
            // 
            this.TBPRHName.Location = new System.Drawing.Point(748, 132);
            this.TBPRHName.MaxLength = 50;
            this.TBPRHName.Name = "TBPRHName";
            this.TBPRHName.ReadOnly = true;
            this.TBPRHName.Size = new System.Drawing.Size(93, 21);
            this.TBPRHName.TabIndex = 62;
            // 
            // LPRHName
            // 
            this.LPRHName.AutoSize = true;
            this.LPRHName.Location = new System.Drawing.Point(701, 135);
            this.LPRHName.Name = "LPRHName";
            this.LPRHName.Size = new System.Drawing.Size(41, 12);
            this.LPRHName.TabIndex = 63;
            this.LPRHName.Text = "影厅：";
            // 
            // BPRUpdatePrice
            // 
            this.BPRUpdatePrice.Location = new System.Drawing.Point(699, 342);
            this.BPRUpdatePrice.Name = "BPRUpdatePrice";
            this.BPRUpdatePrice.Size = new System.Drawing.Size(75, 23);
            this.BPRUpdatePrice.TabIndex = 64;
            this.BPRUpdatePrice.Text = "修改票价";
            this.BPRUpdatePrice.UseVisualStyleBackColor = true;
            this.BPRUpdatePrice.Click += new System.EventHandler(this.BPRUpdatePrice_Click);
            // 
            // BPRDelete
            // 
            this.BPRDelete.Location = new System.Drawing.Point(616, 382);
            this.BPRDelete.Name = "BPRDelete";
            this.BPRDelete.Size = new System.Drawing.Size(75, 23);
            this.BPRDelete.TabIndex = 65;
            this.BPRDelete.Text = "删除";
            this.BPRDelete.UseVisualStyleBackColor = true;
            this.BPRDelete.Click += new System.EventHandler(this.BPRDelete_Click);
            // 
            // TBPRMDEnd
            // 
            this.TBPRMDEnd.Location = new System.Drawing.Point(772, 201);
            this.TBPRMDEnd.MaxLength = 50;
            this.TBPRMDEnd.Name = "TBPRMDEnd";
            this.TBPRMDEnd.ReadOnly = true;
            this.TBPRMDEnd.Size = new System.Drawing.Size(105, 21);
            this.TBPRMDEnd.TabIndex = 68;
            // 
            // LPRMDEnd
            // 
            this.LPRMDEnd.AutoSize = true;
            this.LPRMDEnd.Location = new System.Drawing.Point(701, 204);
            this.LPRMDEnd.Name = "LPRMDEnd";
            this.LPRMDEnd.Size = new System.Drawing.Size(65, 12);
            this.LPRMDEnd.TabIndex = 69;
            this.LPRMDEnd.Text = "下映时间：";
            // 
            // TBPRMDStart
            // 
            this.TBPRMDStart.Location = new System.Drawing.Point(772, 173);
            this.TBPRMDStart.MaxLength = 50;
            this.TBPRMDStart.Name = "TBPRMDStart";
            this.TBPRMDStart.ReadOnly = true;
            this.TBPRMDStart.Size = new System.Drawing.Size(105, 21);
            this.TBPRMDStart.TabIndex = 66;
            // 
            // LPRMDStart
            // 
            this.LPRMDStart.AutoSize = true;
            this.LPRMDStart.Location = new System.Drawing.Point(701, 176);
            this.LPRMDStart.Name = "LPRMDStart";
            this.LPRMDStart.Size = new System.Drawing.Size(65, 12);
            this.LPRMDStart.TabIndex = 67;
            this.LPRMDStart.Text = "上映时间：";
            // 
            // PlanRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.TBPRMDEnd);
            this.Controls.Add(this.LPRMDEnd);
            this.Controls.Add(this.TBPRMDStart);
            this.Controls.Add(this.LPRMDStart);
            this.Controls.Add(this.BPRDelete);
            this.Controls.Add(this.BPRUpdatePrice);
            this.Controls.Add(this.TBPRHName);
            this.Controls.Add(this.LPRHName);
            this.Controls.Add(this.TBPRMPrice);
            this.Controls.Add(this.LPRMPrice);
            this.Controls.Add(this.TBPRMEnd);
            this.Controls.Add(this.LPRMEnd);
            this.Controls.Add(this.TBPRMStart);
            this.Controls.Add(this.LPRMStart);
            this.Controls.Add(this.TBPRType);
            this.Controls.Add(this.LPRType);
            this.Controls.Add(this.TBPRActor);
            this.Controls.Add(this.LPRActor);
            this.Controls.Add(this.TBPRDirector);
            this.Controls.Add(this.LPRDirector);
            this.Controls.Add(this.TBPRMName);
            this.Controls.Add(this.LPRMName);
            this.Controls.Add(this.PBPRPoster);
            this.Controls.Add(this.LBPRHall);
            this.Controls.Add(this.TVPRPlan);
            this.Controls.Add(this.GBPRSelect);
            this.Controls.Add(this.GBPRMovie);
            this.Controls.Add(this.BPRNew);
            this.Controls.Add(this.LPRMovie);
            this.Controls.Add(this.LPRHall);
            this.Controls.Add(this.LPRPrice);
            this.Controls.Add(this.LPREnd);
            this.Controls.Add(this.LPRStart);
            this.Controls.Add(this.TBPRPrice);
            this.Controls.Add(this.DTPPREnd);
            this.Controls.Add(this.DTPPRStart);
            this.Controls.Add(this.LBPRMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanRows";
            this.Text = "PlanRowcs";
            this.Load += new System.EventHandler(this.PlanRows_Load);
            this.GBPRMovie.ResumeLayout(false);
            this.GBPRMovie.PerformLayout();
            this.GBPRSelect.ResumeLayout(false);
            this.GBPRSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPRPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBPRMovie;
        private System.Windows.Forms.DateTimePicker DTPPRStart;
        private System.Windows.Forms.DateTimePicker DTPPREnd;
        private System.Windows.Forms.TextBox TBPRPrice;
        private System.Windows.Forms.Label LPRStart;
        private System.Windows.Forms.Label LPREnd;
        private System.Windows.Forms.Label LPRPrice;
        private System.Windows.Forms.Label LPRHall;
        private System.Windows.Forms.Label LPRMovie;
        private System.Windows.Forms.Button BPRNew;
        private System.Windows.Forms.GroupBox GBPRMovie;
        private System.Windows.Forms.GroupBox GBPRSelect;
        private System.Windows.Forms.RadioButton RBPRHand;
        private System.Windows.Forms.RadioButton RBPRAuto;
        private System.Windows.Forms.RadioButton RBPRNow;
        private System.Windows.Forms.RadioButton RBPRFur;
        private System.Windows.Forms.RadioButton RBPROld;
        private System.Windows.Forms.RadioButton RBPRAll;
        private System.Windows.Forms.TreeView TVPRPlan;
        private System.Windows.Forms.ListBox LBPRHall;
        private System.Windows.Forms.PictureBox PBPRPoster;
        private System.Windows.Forms.TextBox TBPRMName;
        private System.Windows.Forms.Label LPRMName;
        private System.Windows.Forms.TextBox TBPRActor;
        private System.Windows.Forms.Label LPRActor;
        private System.Windows.Forms.TextBox TBPRDirector;
        private System.Windows.Forms.Label LPRDirector;
        private System.Windows.Forms.TextBox TBPRType;
        private System.Windows.Forms.Label LPRType;
        private System.Windows.Forms.TextBox TBPRMPrice;
        private System.Windows.Forms.Label LPRMPrice;
        private System.Windows.Forms.TextBox TBPRMEnd;
        private System.Windows.Forms.Label LPRMEnd;
        private System.Windows.Forms.TextBox TBPRMStart;
        private System.Windows.Forms.Label LPRMStart;
        private System.Windows.Forms.TextBox TBPRHName;
        private System.Windows.Forms.Label LPRHName;
        private System.Windows.Forms.Button BPRUpdatePrice;
        private System.Windows.Forms.Button BPRDelete;
        private System.Windows.Forms.TextBox TBPRMDEnd;
        private System.Windows.Forms.Label LPRMDEnd;
        private System.Windows.Forms.TextBox TBPRMDStart;
        private System.Windows.Forms.Label LPRMDStart;
    }
}