namespace 影院售票系统.CinemaUI
{
    partial class HallQuery
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
            this.CBHName = new System.Windows.Forms.ComboBox();
            this.GBHSeat = new System.Windows.Forms.GroupBox();
            this.BHQuery = new System.Windows.Forms.Button();
            this.LHName = new System.Windows.Forms.Label();
            this.TBHName = new System.Windows.Forms.TextBox();
            this.TBHSeat = new System.Windows.Forms.TextBox();
            this.LHSeat = new System.Windows.Forms.Label();
            this.TBHRow = new System.Windows.Forms.TextBox();
            this.LHRow = new System.Windows.Forms.Label();
            this.BHUpdateName = new System.Windows.Forms.Button();
            this.BHDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBHName
            // 
            this.CBHName.FormattingEnabled = true;
            this.CBHName.Location = new System.Drawing.Point(157, 132);
            this.CBHName.Name = "CBHName";
            this.CBHName.Size = new System.Drawing.Size(121, 20);
            this.CBHName.TabIndex = 0;
            this.CBHName.SelectedIndexChanged += new System.EventHandler(this.CBHName_SelectedIndexChanged);
            // 
            // GBHSeat
            // 
            this.GBHSeat.Location = new System.Drawing.Point(393, 12);
            this.GBHSeat.Name = "GBHSeat";
            this.GBHSeat.Size = new System.Drawing.Size(495, 420);
            this.GBHSeat.TabIndex = 1;
            this.GBHSeat.TabStop = false;
            this.GBHSeat.Text = "影厅结构图";
            // 
            // BHQuery
            // 
            this.BHQuery.Location = new System.Drawing.Point(284, 129);
            this.BHQuery.Name = "BHQuery";
            this.BHQuery.Size = new System.Drawing.Size(75, 23);
            this.BHQuery.TabIndex = 2;
            this.BHQuery.Text = "查询";
            this.BHQuery.UseVisualStyleBackColor = true;
            this.BHQuery.Click += new System.EventHandler(this.BHQuery_Click);
            // 
            // LHName
            // 
            this.LHName.AutoSize = true;
            this.LHName.Location = new System.Drawing.Point(86, 209);
            this.LHName.Name = "LHName";
            this.LHName.Size = new System.Drawing.Size(65, 12);
            this.LHName.TabIndex = 3;
            this.LHName.Text = "影厅名称：";
            // 
            // TBHName
            // 
            this.TBHName.Location = new System.Drawing.Point(157, 208);
            this.TBHName.MaxLength = 50;
            this.TBHName.Name = "TBHName";
            this.TBHName.ReadOnly = true;
            this.TBHName.Size = new System.Drawing.Size(100, 21);
            this.TBHName.TabIndex = 4;
            // 
            // TBHSeat
            // 
            this.TBHSeat.Location = new System.Drawing.Point(157, 235);
            this.TBHSeat.Name = "TBHSeat";
            this.TBHSeat.ReadOnly = true;
            this.TBHSeat.Size = new System.Drawing.Size(100, 21);
            this.TBHSeat.TabIndex = 6;
            // 
            // LHSeat
            // 
            this.LHSeat.AutoSize = true;
            this.LHSeat.Location = new System.Drawing.Point(86, 238);
            this.LHSeat.Name = "LHSeat";
            this.LHSeat.Size = new System.Drawing.Size(65, 12);
            this.LHSeat.TabIndex = 5;
            this.LHSeat.Text = "总座位数：";
            // 
            // TBHRow
            // 
            this.TBHRow.Location = new System.Drawing.Point(157, 262);
            this.TBHRow.Name = "TBHRow";
            this.TBHRow.ReadOnly = true;
            this.TBHRow.Size = new System.Drawing.Size(100, 21);
            this.TBHRow.TabIndex = 8;
            // 
            // LHRow
            // 
            this.LHRow.AutoSize = true;
            this.LHRow.Location = new System.Drawing.Point(98, 262);
            this.LHRow.Name = "LHRow";
            this.LHRow.Size = new System.Drawing.Size(53, 12);
            this.LHRow.TabIndex = 7;
            this.LHRow.Text = "总排数：";
            // 
            // BHUpdateName
            // 
            this.BHUpdateName.Location = new System.Drawing.Point(263, 209);
            this.BHUpdateName.Name = "BHUpdateName";
            this.BHUpdateName.Size = new System.Drawing.Size(75, 23);
            this.BHUpdateName.TabIndex = 9;
            this.BHUpdateName.Text = "修改";
            this.BHUpdateName.UseVisualStyleBackColor = true;
            this.BHUpdateName.Visible = false;
            this.BHUpdateName.Click += new System.EventHandler(this.BHUpdateName_Click);
            // 
            // BHDelete
            // 
            this.BHDelete.Location = new System.Drawing.Point(284, 158);
            this.BHDelete.Name = "BHDelete";
            this.BHDelete.Size = new System.Drawing.Size(75, 23);
            this.BHDelete.TabIndex = 10;
            this.BHDelete.Text = "删除";
            this.BHDelete.UseVisualStyleBackColor = true;
            this.BHDelete.Visible = false;
            this.BHDelete.Click += new System.EventHandler(this.BHDelete_Click);
            // 
            // HallQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.BHDelete);
            this.Controls.Add(this.BHUpdateName);
            this.Controls.Add(this.TBHRow);
            this.Controls.Add(this.LHRow);
            this.Controls.Add(this.TBHSeat);
            this.Controls.Add(this.LHSeat);
            this.Controls.Add(this.TBHName);
            this.Controls.Add(this.LHName);
            this.Controls.Add(this.BHQuery);
            this.Controls.Add(this.GBHSeat);
            this.Controls.Add(this.CBHName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HallQuery";
            this.Text = "HallQuery";
            this.Load += new System.EventHandler(this.HallQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBHName;
        private System.Windows.Forms.GroupBox GBHSeat;
        private System.Windows.Forms.Button BHQuery;
        private System.Windows.Forms.Label LHName;
        private System.Windows.Forms.TextBox TBHName;
        private System.Windows.Forms.TextBox TBHSeat;
        private System.Windows.Forms.Label LHSeat;
        private System.Windows.Forms.TextBox TBHRow;
        private System.Windows.Forms.Label LHRow;
        private System.Windows.Forms.Button BHUpdateName;
        private System.Windows.Forms.Button BHDelete;
    }
}