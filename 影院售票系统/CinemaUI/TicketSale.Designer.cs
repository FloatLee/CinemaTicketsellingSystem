namespace 影院售票系统.CinemaUI
{
    partial class TicketSale
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
            this.TVSTPlan = new System.Windows.Forms.TreeView();
            this.GBSTSeat = new System.Windows.Forms.GroupBox();
            this.GBSTSelect1 = new System.Windows.Forms.GroupBox();
            this.RBSTHis = new System.Windows.Forms.RadioButton();
            this.RBSTMain = new System.Windows.Forms.RadioButton();
            this.GBSTSelect2 = new System.Windows.Forms.GroupBox();
            this.RBSTExit = new System.Windows.Forms.RadioButton();
            this.RBSTsale = new System.Windows.Forms.RadioButton();
            this.TBSTMName = new System.Windows.Forms.TextBox();
            this.LSTMName = new System.Windows.Forms.Label();
            this.TBSTHName = new System.Windows.Forms.TextBox();
            this.LSTHName = new System.Windows.Forms.Label();
            this.TBSTType = new System.Windows.Forms.TextBox();
            this.LSTType = new System.Windows.Forms.Label();
            this.TBSTActor = new System.Windows.Forms.TextBox();
            this.LSTActor = new System.Windows.Forms.Label();
            this.TBSTDirector = new System.Windows.Forms.TextBox();
            this.LSTDirector = new System.Windows.Forms.Label();
            this.TBSTPrice = new System.Windows.Forms.TextBox();
            this.LSTPrice = new System.Windows.Forms.Label();
            this.TBSTStart = new System.Windows.Forms.TextBox();
            this.LSTStart = new System.Windows.Forms.Label();
            this.CBSTDiscount = new System.Windows.Forms.ComboBox();
            this.BSTAuto = new System.Windows.Forms.Button();
            this.BSTBuy = new System.Windows.Forms.Button();
            this.GBSTSelect3 = new System.Windows.Forms.GroupBox();
            this.RBSTMore = new System.Windows.Forms.RadioButton();
            this.RBSTSingle = new System.Windows.Forms.RadioButton();
            this.PBSTPoster = new System.Windows.Forms.PictureBox();
            this.GBSTSelect1.SuspendLayout();
            this.GBSTSelect2.SuspendLayout();
            this.GBSTSelect3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSTPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // TVSTPlan
            // 
            this.TVSTPlan.Location = new System.Drawing.Point(12, 56);
            this.TVSTPlan.Name = "TVSTPlan";
            this.TVSTPlan.Size = new System.Drawing.Size(155, 238);
            this.TVSTPlan.TabIndex = 0;
            this.TVSTPlan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVSTPlan_AfterSelect);
            // 
            // GBSTSeat
            // 
            this.GBSTSeat.Location = new System.Drawing.Point(393, 12);
            this.GBSTSeat.Name = "GBSTSeat";
            this.GBSTSeat.Size = new System.Drawing.Size(495, 420);
            this.GBSTSeat.TabIndex = 2;
            this.GBSTSeat.TabStop = false;
            this.GBSTSeat.Text = "影厅结构图";
            // 
            // GBSTSelect1
            // 
            this.GBSTSelect1.Controls.Add(this.RBSTHis);
            this.GBSTSelect1.Controls.Add(this.RBSTMain);
            this.GBSTSelect1.Location = new System.Drawing.Point(12, 12);
            this.GBSTSelect1.Name = "GBSTSelect1";
            this.GBSTSelect1.Size = new System.Drawing.Size(159, 38);
            this.GBSTSelect1.TabIndex = 3;
            this.GBSTSelect1.TabStop = false;
            this.GBSTSelect1.Text = "功能选择";
            // 
            // RBSTHis
            // 
            this.RBSTHis.AutoSize = true;
            this.RBSTHis.Location = new System.Drawing.Point(82, 16);
            this.RBSTHis.Name = "RBSTHis";
            this.RBSTHis.Size = new System.Drawing.Size(71, 16);
            this.RBSTHis.TabIndex = 4;
            this.RBSTHis.TabStop = true;
            this.RBSTHis.Text = "历史记录";
            this.RBSTHis.UseVisualStyleBackColor = true;
            this.RBSTHis.CheckedChanged += new System.EventHandler(this.RBSTHis_CheckedChanged);
            // 
            // RBSTMain
            // 
            this.RBSTMain.AutoSize = true;
            this.RBSTMain.Location = new System.Drawing.Point(7, 16);
            this.RBSTMain.Name = "RBSTMain";
            this.RBSTMain.Size = new System.Drawing.Size(71, 16);
            this.RBSTMain.TabIndex = 0;
            this.RBSTMain.TabStop = true;
            this.RBSTMain.Text = "售票卖票";
            this.RBSTMain.UseVisualStyleBackColor = true;
            this.RBSTMain.CheckedChanged += new System.EventHandler(this.RBSTMain_CheckedChanged);
            // 
            // GBSTSelect2
            // 
            this.GBSTSelect2.Controls.Add(this.RBSTExit);
            this.GBSTSelect2.Controls.Add(this.RBSTsale);
            this.GBSTSelect2.Location = new System.Drawing.Point(177, 12);
            this.GBSTSelect2.Name = "GBSTSelect2";
            this.GBSTSelect2.Size = new System.Drawing.Size(111, 38);
            this.GBSTSelect2.TabIndex = 5;
            this.GBSTSelect2.TabStop = false;
            this.GBSTSelect2.Text = "售退票";
            // 
            // RBSTExit
            // 
            this.RBSTExit.AutoSize = true;
            this.RBSTExit.Location = new System.Drawing.Point(60, 16);
            this.RBSTExit.Name = "RBSTExit";
            this.RBSTExit.Size = new System.Drawing.Size(47, 16);
            this.RBSTExit.TabIndex = 4;
            this.RBSTExit.TabStop = true;
            this.RBSTExit.Text = "退票";
            this.RBSTExit.UseVisualStyleBackColor = true;
            this.RBSTExit.CheckedChanged += new System.EventHandler(this.RBSTExit_CheckedChanged);
            // 
            // RBSTsale
            // 
            this.RBSTsale.AutoSize = true;
            this.RBSTsale.Location = new System.Drawing.Point(7, 16);
            this.RBSTsale.Name = "RBSTsale";
            this.RBSTsale.Size = new System.Drawing.Size(47, 16);
            this.RBSTsale.TabIndex = 0;
            this.RBSTsale.TabStop = true;
            this.RBSTsale.Text = "售票";
            this.RBSTsale.UseVisualStyleBackColor = true;
            this.RBSTsale.CheckedChanged += new System.EventHandler(this.RBSTsale_CheckedChanged);
            // 
            // TBSTMName
            // 
            this.TBSTMName.Location = new System.Drawing.Point(228, 94);
            this.TBSTMName.MaxLength = 50;
            this.TBSTMName.Name = "TBSTMName";
            this.TBSTMName.ReadOnly = true;
            this.TBSTMName.Size = new System.Drawing.Size(157, 21);
            this.TBSTMName.TabIndex = 49;
            // 
            // LSTMName
            // 
            this.LSTMName.AutoSize = true;
            this.LSTMName.Location = new System.Drawing.Point(181, 97);
            this.LSTMName.Name = "LSTMName";
            this.LSTMName.Size = new System.Drawing.Size(41, 12);
            this.LSTMName.TabIndex = 48;
            this.LSTMName.Text = "片名：";
            // 
            // TBSTHName
            // 
            this.TBSTHName.Location = new System.Drawing.Point(59, 327);
            this.TBSTHName.MaxLength = 50;
            this.TBSTHName.Name = "TBSTHName";
            this.TBSTHName.ReadOnly = true;
            this.TBSTHName.Size = new System.Drawing.Size(112, 21);
            this.TBSTHName.TabIndex = 70;
            // 
            // LSTHName
            // 
            this.LSTHName.AutoSize = true;
            this.LSTHName.BackColor = System.Drawing.SystemColors.Control;
            this.LSTHName.Location = new System.Drawing.Point(12, 330);
            this.LSTHName.Name = "LSTHName";
            this.LSTHName.Size = new System.Drawing.Size(41, 12);
            this.LSTHName.TabIndex = 71;
            this.LSTHName.Text = "影厅：";
            // 
            // TBSTType
            // 
            this.TBSTType.Location = new System.Drawing.Point(237, 381);
            this.TBSTType.MaxLength = 50;
            this.TBSTType.Name = "TBSTType";
            this.TBSTType.ReadOnly = true;
            this.TBSTType.Size = new System.Drawing.Size(110, 21);
            this.TBSTType.TabIndex = 68;
            // 
            // LSTType
            // 
            this.LSTType.AutoSize = true;
            this.LSTType.Location = new System.Drawing.Point(190, 384);
            this.LSTType.Name = "LSTType";
            this.LSTType.Size = new System.Drawing.Size(41, 12);
            this.LSTType.TabIndex = 69;
            this.LSTType.Text = "类型：";
            // 
            // TBSTActor
            // 
            this.TBSTActor.Location = new System.Drawing.Point(237, 354);
            this.TBSTActor.MaxLength = 50;
            this.TBSTActor.Name = "TBSTActor";
            this.TBSTActor.ReadOnly = true;
            this.TBSTActor.Size = new System.Drawing.Size(110, 21);
            this.TBSTActor.TabIndex = 65;
            // 
            // LSTActor
            // 
            this.LSTActor.AutoSize = true;
            this.LSTActor.Location = new System.Drawing.Point(190, 357);
            this.LSTActor.Name = "LSTActor";
            this.LSTActor.Size = new System.Drawing.Size(41, 12);
            this.LSTActor.TabIndex = 67;
            this.LSTActor.Text = "主演：";
            // 
            // TBSTDirector
            // 
            this.TBSTDirector.Location = new System.Drawing.Point(237, 327);
            this.TBSTDirector.MaxLength = 50;
            this.TBSTDirector.Name = "TBSTDirector";
            this.TBSTDirector.ReadOnly = true;
            this.TBSTDirector.Size = new System.Drawing.Size(110, 21);
            this.TBSTDirector.TabIndex = 64;
            // 
            // LSTDirector
            // 
            this.LSTDirector.AutoSize = true;
            this.LSTDirector.Location = new System.Drawing.Point(190, 330);
            this.LSTDirector.Name = "LSTDirector";
            this.LSTDirector.Size = new System.Drawing.Size(41, 12);
            this.LSTDirector.TabIndex = 66;
            this.LSTDirector.Text = "导演：";
            // 
            // TBSTPrice
            // 
            this.TBSTPrice.Location = new System.Drawing.Point(59, 381);
            this.TBSTPrice.MaxLength = 50;
            this.TBSTPrice.Name = "TBSTPrice";
            this.TBSTPrice.ReadOnly = true;
            this.TBSTPrice.Size = new System.Drawing.Size(50, 21);
            this.TBSTPrice.TabIndex = 76;
            // 
            // LSTPrice
            // 
            this.LSTPrice.AutoSize = true;
            this.LSTPrice.Location = new System.Drawing.Point(12, 384);
            this.LSTPrice.Name = "LSTPrice";
            this.LSTPrice.Size = new System.Drawing.Size(41, 12);
            this.LSTPrice.TabIndex = 77;
            this.LSTPrice.Text = "票价：";
            // 
            // TBSTStart
            // 
            this.TBSTStart.Location = new System.Drawing.Point(59, 354);
            this.TBSTStart.MaxLength = 50;
            this.TBSTStart.Name = "TBSTStart";
            this.TBSTStart.ReadOnly = true;
            this.TBSTStart.Size = new System.Drawing.Size(112, 21);
            this.TBSTStart.TabIndex = 72;
            // 
            // LSTStart
            // 
            this.LSTStart.AutoSize = true;
            this.LSTStart.Location = new System.Drawing.Point(12, 357);
            this.LSTStart.Name = "LSTStart";
            this.LSTStart.Size = new System.Drawing.Size(41, 12);
            this.LSTStart.TabIndex = 73;
            this.LSTStart.Text = "时段：";
            // 
            // CBSTDiscount
            // 
            this.CBSTDiscount.FormattingEnabled = true;
            this.CBSTDiscount.Location = new System.Drawing.Point(107, 381);
            this.CBSTDiscount.Name = "CBSTDiscount";
            this.CBSTDiscount.Size = new System.Drawing.Size(64, 20);
            this.CBSTDiscount.TabIndex = 78;
            this.CBSTDiscount.SelectedIndexChanged += new System.EventHandler(this.CBSTDiscount_SelectedIndexChanged);
            // 
            // BSTAuto
            // 
            this.BSTAuto.Location = new System.Drawing.Point(340, 64);
            this.BSTAuto.Name = "BSTAuto";
            this.BSTAuto.Size = new System.Drawing.Size(45, 23);
            this.BSTAuto.TabIndex = 81;
            this.BSTAuto.Text = "反选";
            this.BSTAuto.UseVisualStyleBackColor = true;
            this.BSTAuto.Click += new System.EventHandler(this.BSTAuto_Click);
            // 
            // BSTBuy
            // 
            this.BSTBuy.Location = new System.Drawing.Point(294, 64);
            this.BSTBuy.Name = "BSTBuy";
            this.BSTBuy.Size = new System.Drawing.Size(42, 23);
            this.BSTBuy.TabIndex = 82;
            this.BSTBuy.Text = "购票";
            this.BSTBuy.UseVisualStyleBackColor = true;
            this.BSTBuy.Click += new System.EventHandler(this.BSTBuy_Click);
            // 
            // GBSTSelect3
            // 
            this.GBSTSelect3.Controls.Add(this.RBSTMore);
            this.GBSTSelect3.Controls.Add(this.RBSTSingle);
            this.GBSTSelect3.Location = new System.Drawing.Point(177, 51);
            this.GBSTSelect3.Name = "GBSTSelect3";
            this.GBSTSelect3.Size = new System.Drawing.Size(111, 38);
            this.GBSTSelect3.TabIndex = 83;
            this.GBSTSelect3.TabStop = false;
            this.GBSTSelect3.Text = "模式";
            // 
            // RBSTMore
            // 
            this.RBSTMore.AutoSize = true;
            this.RBSTMore.Location = new System.Drawing.Point(60, 16);
            this.RBSTMore.Name = "RBSTMore";
            this.RBSTMore.Size = new System.Drawing.Size(47, 16);
            this.RBSTMore.TabIndex = 4;
            this.RBSTMore.TabStop = true;
            this.RBSTMore.Text = "多选";
            this.RBSTMore.UseVisualStyleBackColor = true;
            this.RBSTMore.CheckedChanged += new System.EventHandler(this.RBSTMore_CheckedChanged);
            // 
            // RBSTSingle
            // 
            this.RBSTSingle.AutoSize = true;
            this.RBSTSingle.Location = new System.Drawing.Point(7, 16);
            this.RBSTSingle.Name = "RBSTSingle";
            this.RBSTSingle.Size = new System.Drawing.Size(47, 16);
            this.RBSTSingle.TabIndex = 0;
            this.RBSTSingle.TabStop = true;
            this.RBSTSingle.Text = "单选";
            this.RBSTSingle.UseVisualStyleBackColor = true;
            this.RBSTSingle.CheckedChanged += new System.EventHandler(this.RBSTSingle_CheckedChanged);
            // 
            // PBSTPoster
            // 
            this.PBSTPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBSTPoster.Location = new System.Drawing.Point(207, 121);
            this.PBSTPoster.Name = "PBSTPoster";
            this.PBSTPoster.Size = new System.Drawing.Size(140, 200);
            this.PBSTPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSTPoster.TabIndex = 46;
            this.PBSTPoster.TabStop = false;
            // 
            // TicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.GBSTSelect3);
            this.Controls.Add(this.BSTBuy);
            this.Controls.Add(this.BSTAuto);
            this.Controls.Add(this.CBSTDiscount);
            this.Controls.Add(this.TBSTPrice);
            this.Controls.Add(this.LSTPrice);
            this.Controls.Add(this.TBSTStart);
            this.Controls.Add(this.LSTStart);
            this.Controls.Add(this.TBSTHName);
            this.Controls.Add(this.LSTHName);
            this.Controls.Add(this.TBSTType);
            this.Controls.Add(this.LSTType);
            this.Controls.Add(this.TBSTActor);
            this.Controls.Add(this.LSTActor);
            this.Controls.Add(this.TBSTDirector);
            this.Controls.Add(this.LSTDirector);
            this.Controls.Add(this.TBSTMName);
            this.Controls.Add(this.LSTMName);
            this.Controls.Add(this.PBSTPoster);
            this.Controls.Add(this.GBSTSelect2);
            this.Controls.Add(this.GBSTSelect1);
            this.Controls.Add(this.GBSTSeat);
            this.Controls.Add(this.TVSTPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketSale";
            this.Text = "TicketSale";
            this.Load += new System.EventHandler(this.TicketSale_Load);
            this.GBSTSelect1.ResumeLayout(false);
            this.GBSTSelect1.PerformLayout();
            this.GBSTSelect2.ResumeLayout(false);
            this.GBSTSelect2.PerformLayout();
            this.GBSTSelect3.ResumeLayout(false);
            this.GBSTSelect3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSTPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TVSTPlan;
        private System.Windows.Forms.GroupBox GBSTSeat;
        private System.Windows.Forms.GroupBox GBSTSelect1;
        private System.Windows.Forms.RadioButton RBSTHis;
        private System.Windows.Forms.RadioButton RBSTMain;
        private System.Windows.Forms.GroupBox GBSTSelect2;
        private System.Windows.Forms.RadioButton RBSTExit;
        private System.Windows.Forms.RadioButton RBSTsale;
        private System.Windows.Forms.PictureBox PBSTPoster;
        private System.Windows.Forms.TextBox TBSTMName;
        private System.Windows.Forms.Label LSTMName;
        private System.Windows.Forms.TextBox TBSTHName;
        private System.Windows.Forms.Label LSTHName;
        private System.Windows.Forms.TextBox TBSTType;
        private System.Windows.Forms.Label LSTType;
        private System.Windows.Forms.TextBox TBSTActor;
        private System.Windows.Forms.Label LSTActor;
        private System.Windows.Forms.TextBox TBSTDirector;
        private System.Windows.Forms.Label LSTDirector;
        private System.Windows.Forms.TextBox TBSTPrice;
        private System.Windows.Forms.Label LSTPrice;
        private System.Windows.Forms.TextBox TBSTStart;
        private System.Windows.Forms.Label LSTStart;
        private System.Windows.Forms.ComboBox CBSTDiscount;
        private System.Windows.Forms.Button BSTAuto;
        private System.Windows.Forms.Button BSTBuy;
        private System.Windows.Forms.GroupBox GBSTSelect3;
        private System.Windows.Forms.RadioButton RBSTMore;
        private System.Windows.Forms.RadioButton RBSTSingle;
    }
}