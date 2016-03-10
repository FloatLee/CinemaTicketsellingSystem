namespace 影院售票系统.CinemaUI
{
    partial class MovieQuery
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
            this.GBMQSelect = new System.Windows.Forms.GroupBox();
            this.RBMQFurture = new System.Windows.Forms.RadioButton();
            this.RBMQNow = new System.Windows.Forms.RadioButton();
            this.RBMQOld = new System.Windows.Forms.RadioButton();
            this.RBMQAll = new System.Windows.Forms.RadioButton();
            this.CBMQuery = new System.Windows.Forms.ComboBox();
            this.BMQUpdate = new System.Windows.Forms.Button();
            this.GBMQResult = new System.Windows.Forms.GroupBox();
            this.LMMinute = new System.Windows.Forms.Label();
            this.GBMType = new System.Windows.Forms.GroupBox();
            this.CBMAction = new System.Windows.Forms.CheckBox();
            this.CBMHorror = new System.Windows.Forms.CheckBox();
            this.CBMMusic = new System.Windows.Forms.CheckBox();
            this.CBMDrama = new System.Windows.Forms.CheckBox();
            this.CBMFarmily = new System.Windows.Forms.CheckBox();
            this.CBMCrime = new System.Windows.Forms.CheckBox();
            this.CBMDocumentary = new System.Windows.Forms.CheckBox();
            this.CBMMMystery = new System.Windows.Forms.CheckBox();
            this.CBMWar = new System.Windows.Forms.CheckBox();
            this.CBMWestern = new System.Windows.Forms.CheckBox();
            this.CBMRomance = new System.Windows.Forms.CheckBox();
            this.CBMSciFi = new System.Windows.Forms.CheckBox();
            this.CBMThriller = new System.Windows.Forms.CheckBox();
            this.CBMComedy = new System.Windows.Forms.CheckBox();
            this.CBMAdventure = new System.Windows.Forms.CheckBox();
            this.CBMFantasy = new System.Windows.Forms.CheckBox();
            this.BMPoster = new System.Windows.Forms.Button();
            this.PBMPoster = new System.Windows.Forms.PictureBox();
            this.LMPoster = new System.Windows.Forms.Label();
            this.TBMTime = new System.Windows.Forms.TextBox();
            this.LMTime = new System.Windows.Forms.Label();
            this.TBMIntrod = new System.Windows.Forms.TextBox();
            this.LMIntrod = new System.Windows.Forms.Label();
            this.DTPMEnd = new System.Windows.Forms.DateTimePicker();
            this.LMEnd = new System.Windows.Forms.Label();
            this.DTPMStart = new System.Windows.Forms.DateTimePicker();
            this.LMStart = new System.Windows.Forms.Label();
            this.TBMNum = new System.Windows.Forms.TextBox();
            this.LMNum = new System.Windows.Forms.Label();
            this.TBMActor = new System.Windows.Forms.TextBox();
            this.LMActor = new System.Windows.Forms.Label();
            this.TBMDirector = new System.Windows.Forms.TextBox();
            this.LMDirector = new System.Windows.Forms.Label();
            this.TBMProducer = new System.Windows.Forms.TextBox();
            this.LMProducer = new System.Windows.Forms.Label();
            this.TBMName = new System.Windows.Forms.TextBox();
            this.LMName = new System.Windows.Forms.Label();
            this.BMQDelete = new System.Windows.Forms.Button();
            this.GBMQSelect.SuspendLayout();
            this.GBMQResult.SuspendLayout();
            this.GBMType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // GBMQSelect
            // 
            this.GBMQSelect.Controls.Add(this.RBMQFurture);
            this.GBMQSelect.Controls.Add(this.RBMQNow);
            this.GBMQSelect.Controls.Add(this.RBMQOld);
            this.GBMQSelect.Controls.Add(this.RBMQAll);
            this.GBMQSelect.Location = new System.Drawing.Point(507, 12);
            this.GBMQSelect.Name = "GBMQSelect";
            this.GBMQSelect.Size = new System.Drawing.Size(348, 54);
            this.GBMQSelect.TabIndex = 0;
            this.GBMQSelect.TabStop = false;
            this.GBMQSelect.Text = "查询选择";
            // 
            // RBMQFurture
            // 
            this.RBMQFurture.AutoSize = true;
            this.RBMQFurture.Location = new System.Drawing.Point(254, 20);
            this.RBMQFurture.Name = "RBMQFurture";
            this.RBMQFurture.Size = new System.Drawing.Size(83, 16);
            this.RBMQFurture.TabIndex = 3;
            this.RBMQFurture.TabStop = true;
            this.RBMQFurture.Text = "未上映影片";
            this.RBMQFurture.UseVisualStyleBackColor = true;
            this.RBMQFurture.CheckedChanged += new System.EventHandler(this.RBMQFurture_CheckedChanged);
            // 
            // RBMQNow
            // 
            this.RBMQNow.AutoSize = true;
            this.RBMQNow.Location = new System.Drawing.Point(177, 19);
            this.RBMQNow.Name = "RBMQNow";
            this.RBMQNow.Size = new System.Drawing.Size(71, 16);
            this.RBMQNow.TabIndex = 2;
            this.RBMQNow.TabStop = true;
            this.RBMQNow.Text = "上映影片";
            this.RBMQNow.UseVisualStyleBackColor = true;
            this.RBMQNow.CheckedChanged += new System.EventHandler(this.RBMQNow_CheckedChanged);
            // 
            // RBMQOld
            // 
            this.RBMQOld.AutoSize = true;
            this.RBMQOld.Location = new System.Drawing.Point(88, 20);
            this.RBMQOld.Name = "RBMQOld";
            this.RBMQOld.Size = new System.Drawing.Size(83, 16);
            this.RBMQOld.TabIndex = 1;
            this.RBMQOld.TabStop = true;
            this.RBMQOld.Text = "已下映影片";
            this.RBMQOld.UseVisualStyleBackColor = true;
            this.RBMQOld.CheckedChanged += new System.EventHandler(this.RBMQOld_CheckedChanged);
            // 
            // RBMQAll
            // 
            this.RBMQAll.AutoSize = true;
            this.RBMQAll.Location = new System.Drawing.Point(11, 21);
            this.RBMQAll.Name = "RBMQAll";
            this.RBMQAll.Size = new System.Drawing.Size(71, 16);
            this.RBMQAll.TabIndex = 0;
            this.RBMQAll.TabStop = true;
            this.RBMQAll.Text = "全部影片";
            this.RBMQAll.UseVisualStyleBackColor = true;
            this.RBMQAll.CheckedChanged += new System.EventHandler(this.RBMQAll_CheckedChanged);
            // 
            // CBMQuery
            // 
            this.CBMQuery.FormattingEnabled = true;
            this.CBMQuery.Location = new System.Drawing.Point(12, 28);
            this.CBMQuery.Name = "CBMQuery";
            this.CBMQuery.Size = new System.Drawing.Size(248, 20);
            this.CBMQuery.TabIndex = 1;
            this.CBMQuery.SelectedIndexChanged += new System.EventHandler(this.CBMQuery_SelectedIndexChanged);
            // 
            // BMQUpdate
            // 
            this.BMQUpdate.Location = new System.Drawing.Point(280, 28);
            this.BMQUpdate.Name = "BMQUpdate";
            this.BMQUpdate.Size = new System.Drawing.Size(75, 23);
            this.BMQUpdate.TabIndex = 2;
            this.BMQUpdate.Text = "修改";
            this.BMQUpdate.UseVisualStyleBackColor = true;
            this.BMQUpdate.Click += new System.EventHandler(this.BMQUpdate_Click);
            // 
            // GBMQResult
            // 
            this.GBMQResult.Controls.Add(this.LMMinute);
            this.GBMQResult.Controls.Add(this.GBMType);
            this.GBMQResult.Controls.Add(this.BMPoster);
            this.GBMQResult.Controls.Add(this.PBMPoster);
            this.GBMQResult.Controls.Add(this.LMPoster);
            this.GBMQResult.Controls.Add(this.TBMTime);
            this.GBMQResult.Controls.Add(this.LMTime);
            this.GBMQResult.Controls.Add(this.TBMIntrod);
            this.GBMQResult.Controls.Add(this.LMIntrod);
            this.GBMQResult.Controls.Add(this.DTPMEnd);
            this.GBMQResult.Controls.Add(this.LMEnd);
            this.GBMQResult.Controls.Add(this.DTPMStart);
            this.GBMQResult.Controls.Add(this.LMStart);
            this.GBMQResult.Controls.Add(this.TBMNum);
            this.GBMQResult.Controls.Add(this.LMNum);
            this.GBMQResult.Controls.Add(this.TBMActor);
            this.GBMQResult.Controls.Add(this.LMActor);
            this.GBMQResult.Controls.Add(this.TBMDirector);
            this.GBMQResult.Controls.Add(this.LMDirector);
            this.GBMQResult.Controls.Add(this.TBMProducer);
            this.GBMQResult.Controls.Add(this.LMProducer);
            this.GBMQResult.Controls.Add(this.TBMName);
            this.GBMQResult.Controls.Add(this.LMName);
            this.GBMQResult.Enabled = false;
            this.GBMQResult.Location = new System.Drawing.Point(13, 55);
            this.GBMQResult.Name = "GBMQResult";
            this.GBMQResult.Size = new System.Drawing.Size(875, 383);
            this.GBMQResult.TabIndex = 3;
            this.GBMQResult.TabStop = false;
            this.GBMQResult.Text = "查询结果";
            // 
            // LMMinute
            // 
            this.LMMinute.AutoSize = true;
            this.LMMinute.Location = new System.Drawing.Point(345, 287);
            this.LMMinute.Name = "LMMinute";
            this.LMMinute.Size = new System.Drawing.Size(29, 12);
            this.LMMinute.TabIndex = 45;
            this.LMMinute.Text = "分钟";
            // 
            // GBMType
            // 
            this.GBMType.Controls.Add(this.CBMAction);
            this.GBMType.Controls.Add(this.CBMHorror);
            this.GBMType.Controls.Add(this.CBMMusic);
            this.GBMType.Controls.Add(this.CBMDrama);
            this.GBMType.Controls.Add(this.CBMFarmily);
            this.GBMType.Controls.Add(this.CBMCrime);
            this.GBMType.Controls.Add(this.CBMDocumentary);
            this.GBMType.Controls.Add(this.CBMMMystery);
            this.GBMType.Controls.Add(this.CBMWar);
            this.GBMType.Controls.Add(this.CBMWestern);
            this.GBMType.Controls.Add(this.CBMRomance);
            this.GBMType.Controls.Add(this.CBMSciFi);
            this.GBMType.Controls.Add(this.CBMThriller);
            this.GBMType.Controls.Add(this.CBMComedy);
            this.GBMType.Controls.Add(this.CBMAdventure);
            this.GBMType.Controls.Add(this.CBMFantasy);
            this.GBMType.Location = new System.Drawing.Point(105, 60);
            this.GBMType.Name = "GBMType";
            this.GBMType.Size = new System.Drawing.Size(269, 110);
            this.GBMType.TabIndex = 25;
            this.GBMType.TabStop = false;
            this.GBMType.Text = "类型：";
            // 
            // CBMAction
            // 
            this.CBMAction.AutoSize = true;
            this.CBMAction.Location = new System.Drawing.Point(194, 63);
            this.CBMAction.Name = "CBMAction";
            this.CBMAction.Size = new System.Drawing.Size(48, 16);
            this.CBMAction.TabIndex = 11;
            this.CBMAction.Text = "动作";
            this.CBMAction.UseVisualStyleBackColor = true;
            // 
            // CBMHorror
            // 
            this.CBMHorror.AutoSize = true;
            this.CBMHorror.Location = new System.Drawing.Point(140, 63);
            this.CBMHorror.Name = "CBMHorror";
            this.CBMHorror.Size = new System.Drawing.Size(48, 16);
            this.CBMHorror.TabIndex = 10;
            this.CBMHorror.Text = "恐怖";
            this.CBMHorror.UseVisualStyleBackColor = true;
            // 
            // CBMMusic
            // 
            this.CBMMusic.AutoSize = true;
            this.CBMMusic.Location = new System.Drawing.Point(86, 85);
            this.CBMMusic.Name = "CBMMusic";
            this.CBMMusic.Size = new System.Drawing.Size(48, 16);
            this.CBMMusic.TabIndex = 13;
            this.CBMMusic.Text = "音乐";
            this.CBMMusic.UseVisualStyleBackColor = true;
            // 
            // CBMDrama
            // 
            this.CBMDrama.AutoSize = true;
            this.CBMDrama.Location = new System.Drawing.Point(86, 63);
            this.CBMDrama.Name = "CBMDrama";
            this.CBMDrama.Size = new System.Drawing.Size(48, 16);
            this.CBMDrama.TabIndex = 9;
            this.CBMDrama.Text = "剧情";
            this.CBMDrama.UseVisualStyleBackColor = true;
            // 
            // CBMFarmily
            // 
            this.CBMFarmily.AutoSize = true;
            this.CBMFarmily.Location = new System.Drawing.Point(140, 85);
            this.CBMFarmily.Name = "CBMFarmily";
            this.CBMFarmily.Size = new System.Drawing.Size(48, 16);
            this.CBMFarmily.TabIndex = 14;
            this.CBMFarmily.Text = "家庭";
            this.CBMFarmily.UseVisualStyleBackColor = true;
            // 
            // CBMCrime
            // 
            this.CBMCrime.AutoSize = true;
            this.CBMCrime.Location = new System.Drawing.Point(194, 85);
            this.CBMCrime.Name = "CBMCrime";
            this.CBMCrime.Size = new System.Drawing.Size(48, 16);
            this.CBMCrime.TabIndex = 15;
            this.CBMCrime.Text = "犯罪";
            this.CBMCrime.UseVisualStyleBackColor = true;
            // 
            // CBMDocumentary
            // 
            this.CBMDocumentary.AutoSize = true;
            this.CBMDocumentary.Location = new System.Drawing.Point(86, 42);
            this.CBMDocumentary.Name = "CBMDocumentary";
            this.CBMDocumentary.Size = new System.Drawing.Size(48, 16);
            this.CBMDocumentary.TabIndex = 5;
            this.CBMDocumentary.Text = "记录";
            this.CBMDocumentary.UseVisualStyleBackColor = true;
            // 
            // CBMMMystery
            // 
            this.CBMMMystery.AutoSize = true;
            this.CBMMMystery.Location = new System.Drawing.Point(194, 20);
            this.CBMMMystery.Name = "CBMMMystery";
            this.CBMMMystery.Size = new System.Drawing.Size(48, 16);
            this.CBMMMystery.TabIndex = 3;
            this.CBMMMystery.Text = "悬念";
            this.CBMMMystery.UseVisualStyleBackColor = true;
            // 
            // CBMWar
            // 
            this.CBMWar.AutoSize = true;
            this.CBMWar.Location = new System.Drawing.Point(140, 42);
            this.CBMWar.Name = "CBMWar";
            this.CBMWar.Size = new System.Drawing.Size(48, 16);
            this.CBMWar.TabIndex = 6;
            this.CBMWar.Text = "战争";
            this.CBMWar.UseVisualStyleBackColor = true;
            // 
            // CBMWestern
            // 
            this.CBMWestern.AutoSize = true;
            this.CBMWestern.Location = new System.Drawing.Point(194, 42);
            this.CBMWestern.Name = "CBMWestern";
            this.CBMWestern.Size = new System.Drawing.Size(48, 16);
            this.CBMWestern.TabIndex = 7;
            this.CBMWestern.Text = "西部";
            this.CBMWestern.UseVisualStyleBackColor = true;
            // 
            // CBMRomance
            // 
            this.CBMRomance.AutoSize = true;
            this.CBMRomance.Location = new System.Drawing.Point(32, 64);
            this.CBMRomance.Name = "CBMRomance";
            this.CBMRomance.Size = new System.Drawing.Size(48, 16);
            this.CBMRomance.TabIndex = 8;
            this.CBMRomance.Text = "爱情";
            this.CBMRomance.UseVisualStyleBackColor = true;
            // 
            // CBMSciFi
            // 
            this.CBMSciFi.AutoSize = true;
            this.CBMSciFi.Location = new System.Drawing.Point(32, 86);
            this.CBMSciFi.Name = "CBMSciFi";
            this.CBMSciFi.Size = new System.Drawing.Size(48, 16);
            this.CBMSciFi.TabIndex = 12;
            this.CBMSciFi.Text = "科幻";
            this.CBMSciFi.UseVisualStyleBackColor = true;
            // 
            // CBMThriller
            // 
            this.CBMThriller.AutoSize = true;
            this.CBMThriller.Location = new System.Drawing.Point(32, 42);
            this.CBMThriller.Name = "CBMThriller";
            this.CBMThriller.Size = new System.Drawing.Size(48, 16);
            this.CBMThriller.TabIndex = 4;
            this.CBMThriller.Text = "惊悚";
            this.CBMThriller.UseVisualStyleBackColor = true;
            // 
            // CBMComedy
            // 
            this.CBMComedy.AutoSize = true;
            this.CBMComedy.Location = new System.Drawing.Point(32, 20);
            this.CBMComedy.Name = "CBMComedy";
            this.CBMComedy.Size = new System.Drawing.Size(48, 16);
            this.CBMComedy.TabIndex = 0;
            this.CBMComedy.Text = "喜剧";
            this.CBMComedy.UseVisualStyleBackColor = true;
            // 
            // CBMAdventure
            // 
            this.CBMAdventure.AutoSize = true;
            this.CBMAdventure.Location = new System.Drawing.Point(86, 20);
            this.CBMAdventure.Name = "CBMAdventure";
            this.CBMAdventure.Size = new System.Drawing.Size(48, 16);
            this.CBMAdventure.TabIndex = 1;
            this.CBMAdventure.Text = "冒险";
            this.CBMAdventure.UseVisualStyleBackColor = true;
            // 
            // CBMFantasy
            // 
            this.CBMFantasy.AutoSize = true;
            this.CBMFantasy.Location = new System.Drawing.Point(140, 20);
            this.CBMFantasy.Name = "CBMFantasy";
            this.CBMFantasy.Size = new System.Drawing.Size(48, 16);
            this.CBMFantasy.TabIndex = 2;
            this.CBMFantasy.Text = "幻想";
            this.CBMFantasy.UseVisualStyleBackColor = true;
            // 
            // BMPoster
            // 
            this.BMPoster.Location = new System.Drawing.Point(653, 30);
            this.BMPoster.Name = "BMPoster";
            this.BMPoster.Size = new System.Drawing.Size(75, 23);
            this.BMPoster.TabIndex = 37;
            this.BMPoster.Text = "选择图片";
            this.BMPoster.UseVisualStyleBackColor = true;
            this.BMPoster.Visible = false;
            this.BMPoster.Click += new System.EventHandler(this.BMPoster_Click);
            // 
            // PBMPoster
            // 
            this.PBMPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBMPoster.Location = new System.Drawing.Point(506, 33);
            this.PBMPoster.Name = "PBMPoster";
            this.PBMPoster.Size = new System.Drawing.Size(140, 200);
            this.PBMPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMPoster.TabIndex = 44;
            this.PBMPoster.TabStop = false;
            // 
            // LMPoster
            // 
            this.LMPoster.AutoSize = true;
            this.LMPoster.Location = new System.Drawing.Point(459, 33);
            this.LMPoster.Name = "LMPoster";
            this.LMPoster.Size = new System.Drawing.Size(41, 12);
            this.LMPoster.TabIndex = 43;
            this.LMPoster.Text = "海报：";
            // 
            // TBMTime
            // 
            this.TBMTime.Location = new System.Drawing.Point(174, 284);
            this.TBMTime.Name = "TBMTime";
            this.TBMTime.Size = new System.Drawing.Size(165, 21);
            this.TBMTime.TabIndex = 32;
            this.TBMTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMTime_KeyPress);
            // 
            // LMTime
            // 
            this.LMTime.AutoSize = true;
            this.LMTime.Location = new System.Drawing.Point(127, 287);
            this.LMTime.Name = "LMTime";
            this.LMTime.Size = new System.Drawing.Size(41, 12);
            this.LMTime.TabIndex = 42;
            this.LMTime.Text = "时长：";
            // 
            // TBMIntrod
            // 
            this.TBMIntrod.Location = new System.Drawing.Point(497, 289);
            this.TBMIntrod.MaxLength = 200;
            this.TBMIntrod.Multiline = true;
            this.TBMIntrod.Name = "TBMIntrod";
            this.TBMIntrod.Size = new System.Drawing.Size(280, 70);
            this.TBMIntrod.TabIndex = 38;
            // 
            // LMIntrod
            // 
            this.LMIntrod.AutoSize = true;
            this.LMIntrod.Location = new System.Drawing.Point(426, 292);
            this.LMIntrod.Name = "LMIntrod";
            this.LMIntrod.Size = new System.Drawing.Size(65, 12);
            this.LMIntrod.TabIndex = 41;
            this.LMIntrod.Text = "电影简介：";
            // 
            // DTPMEnd
            // 
            this.DTPMEnd.Location = new System.Drawing.Point(174, 338);
            this.DTPMEnd.Name = "DTPMEnd";
            this.DTPMEnd.Size = new System.Drawing.Size(200, 21);
            this.DTPMEnd.TabIndex = 35;
            // 
            // LMEnd
            // 
            this.LMEnd.AutoSize = true;
            this.LMEnd.Location = new System.Drawing.Point(103, 344);
            this.LMEnd.Name = "LMEnd";
            this.LMEnd.Size = new System.Drawing.Size(65, 12);
            this.LMEnd.TabIndex = 40;
            this.LMEnd.Text = "结束日期：";
            // 
            // DTPMStart
            // 
            this.DTPMStart.Location = new System.Drawing.Point(174, 311);
            this.DTPMStart.Name = "DTPMStart";
            this.DTPMStart.Size = new System.Drawing.Size(200, 21);
            this.DTPMStart.TabIndex = 34;
            // 
            // LMStart
            // 
            this.LMStart.AutoSize = true;
            this.LMStart.Location = new System.Drawing.Point(103, 317);
            this.LMStart.Name = "LMStart";
            this.LMStart.Size = new System.Drawing.Size(65, 12);
            this.LMStart.TabIndex = 39;
            this.LMStart.Text = "上映日期：";
            // 
            // TBMNum
            // 
            this.TBMNum.Location = new System.Drawing.Point(174, 257);
            this.TBMNum.MaxLength = 18;
            this.TBMNum.Name = "TBMNum";
            this.TBMNum.Size = new System.Drawing.Size(200, 21);
            this.TBMNum.TabIndex = 30;
            this.TBMNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMNum_KeyPress);
            // 
            // LMNum
            // 
            this.LMNum.AutoSize = true;
            this.LMNum.Location = new System.Drawing.Point(79, 260);
            this.LMNum.Name = "LMNum";
            this.LMNum.Size = new System.Drawing.Size(89, 12);
            this.LMNum.TabIndex = 36;
            this.LMNum.Text = "播放许可证号：";
            // 
            // TBMActor
            // 
            this.TBMActor.Location = new System.Drawing.Point(174, 230);
            this.TBMActor.MaxLength = 50;
            this.TBMActor.Name = "TBMActor";
            this.TBMActor.Size = new System.Drawing.Size(200, 21);
            this.TBMActor.TabIndex = 29;
            // 
            // LMActor
            // 
            this.LMActor.AutoSize = true;
            this.LMActor.Location = new System.Drawing.Point(127, 233);
            this.LMActor.Name = "LMActor";
            this.LMActor.Size = new System.Drawing.Size(41, 12);
            this.LMActor.TabIndex = 33;
            this.LMActor.Text = "主演：";
            // 
            // TBMDirector
            // 
            this.TBMDirector.Location = new System.Drawing.Point(174, 203);
            this.TBMDirector.MaxLength = 50;
            this.TBMDirector.Name = "TBMDirector";
            this.TBMDirector.Size = new System.Drawing.Size(200, 21);
            this.TBMDirector.TabIndex = 27;
            // 
            // LMDirector
            // 
            this.LMDirector.AutoSize = true;
            this.LMDirector.Location = new System.Drawing.Point(127, 206);
            this.LMDirector.Name = "LMDirector";
            this.LMDirector.Size = new System.Drawing.Size(41, 12);
            this.LMDirector.TabIndex = 31;
            this.LMDirector.Text = "导演：";
            // 
            // TBMProducer
            // 
            this.TBMProducer.Location = new System.Drawing.Point(174, 176);
            this.TBMProducer.MaxLength = 50;
            this.TBMProducer.Name = "TBMProducer";
            this.TBMProducer.Size = new System.Drawing.Size(200, 21);
            this.TBMProducer.TabIndex = 26;
            // 
            // LMProducer
            // 
            this.LMProducer.AutoSize = true;
            this.LMProducer.Location = new System.Drawing.Point(115, 179);
            this.LMProducer.Name = "LMProducer";
            this.LMProducer.Size = new System.Drawing.Size(53, 12);
            this.LMProducer.TabIndex = 28;
            this.LMProducer.Text = "出品方：";
            // 
            // TBMName
            // 
            this.TBMName.Location = new System.Drawing.Point(174, 33);
            this.TBMName.MaxLength = 50;
            this.TBMName.Name = "TBMName";
            this.TBMName.Size = new System.Drawing.Size(200, 21);
            this.TBMName.TabIndex = 24;
            // 
            // LMName
            // 
            this.LMName.AutoSize = true;
            this.LMName.Location = new System.Drawing.Point(103, 36);
            this.LMName.Name = "LMName";
            this.LMName.Size = new System.Drawing.Size(65, 12);
            this.LMName.TabIndex = 23;
            this.LMName.Text = "电影名称：";
            // 
            // BMQDelete
            // 
            this.BMQDelete.Location = new System.Drawing.Point(361, 28);
            this.BMQDelete.Name = "BMQDelete";
            this.BMQDelete.Size = new System.Drawing.Size(75, 23);
            this.BMQDelete.TabIndex = 4;
            this.BMQDelete.Text = "删除";
            this.BMQDelete.UseVisualStyleBackColor = true;
            this.BMQDelete.Click += new System.EventHandler(this.BMQDelete_Click);
            // 
            // MovieQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.BMQDelete);
            this.Controls.Add(this.GBMQResult);
            this.Controls.Add(this.BMQUpdate);
            this.Controls.Add(this.CBMQuery);
            this.Controls.Add(this.GBMQSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieQuery";
            this.Text = "MovieQuery";
            this.Load += new System.EventHandler(this.MovieQuery_Load);
            this.GBMQSelect.ResumeLayout(false);
            this.GBMQSelect.PerformLayout();
            this.GBMQResult.ResumeLayout(false);
            this.GBMQResult.PerformLayout();
            this.GBMType.ResumeLayout(false);
            this.GBMType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMQSelect;
        private System.Windows.Forms.RadioButton RBMQFurture;
        private System.Windows.Forms.RadioButton RBMQNow;
        private System.Windows.Forms.RadioButton RBMQOld;
        private System.Windows.Forms.RadioButton RBMQAll;
        private System.Windows.Forms.ComboBox CBMQuery;
        private System.Windows.Forms.Button BMQUpdate;
        private System.Windows.Forms.GroupBox GBMQResult;
        private System.Windows.Forms.Label LMMinute;
        private System.Windows.Forms.GroupBox GBMType;
        private System.Windows.Forms.CheckBox CBMAction;
        private System.Windows.Forms.CheckBox CBMHorror;
        private System.Windows.Forms.CheckBox CBMMusic;
        private System.Windows.Forms.CheckBox CBMDrama;
        private System.Windows.Forms.CheckBox CBMFarmily;
        private System.Windows.Forms.CheckBox CBMCrime;
        private System.Windows.Forms.CheckBox CBMDocumentary;
        private System.Windows.Forms.CheckBox CBMMMystery;
        private System.Windows.Forms.CheckBox CBMWar;
        private System.Windows.Forms.CheckBox CBMWestern;
        private System.Windows.Forms.CheckBox CBMRomance;
        private System.Windows.Forms.CheckBox CBMSciFi;
        private System.Windows.Forms.CheckBox CBMThriller;
        private System.Windows.Forms.CheckBox CBMComedy;
        private System.Windows.Forms.CheckBox CBMAdventure;
        private System.Windows.Forms.CheckBox CBMFantasy;
        private System.Windows.Forms.Button BMPoster;
        private System.Windows.Forms.PictureBox PBMPoster;
        private System.Windows.Forms.Label LMPoster;
        private System.Windows.Forms.TextBox TBMTime;
        private System.Windows.Forms.Label LMTime;
        private System.Windows.Forms.TextBox TBMIntrod;
        private System.Windows.Forms.Label LMIntrod;
        private System.Windows.Forms.DateTimePicker DTPMEnd;
        private System.Windows.Forms.Label LMEnd;
        private System.Windows.Forms.DateTimePicker DTPMStart;
        private System.Windows.Forms.Label LMStart;
        private System.Windows.Forms.TextBox TBMNum;
        private System.Windows.Forms.Label LMNum;
        private System.Windows.Forms.TextBox TBMActor;
        private System.Windows.Forms.Label LMActor;
        private System.Windows.Forms.TextBox TBMDirector;
        private System.Windows.Forms.Label LMDirector;
        private System.Windows.Forms.TextBox TBMProducer;
        private System.Windows.Forms.Label LMProducer;
        private System.Windows.Forms.TextBox TBMName;
        private System.Windows.Forms.Label LMName;
        private System.Windows.Forms.Button BMQDelete;

    }
}