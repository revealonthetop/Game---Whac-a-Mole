namespace 두더쥐게임_winform1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_groundRat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.난이도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쉬움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보통ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.어려움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 414);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "점수 :";
            // 
            // btn_groundRat
            // 
            this.btn_groundRat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_groundRat.BackgroundImage")));
            this.btn_groundRat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_groundRat.Location = new System.Drawing.Point(220, 70);
            this.btn_groundRat.Name = "btn_groundRat";
            this.btn_groundRat.Size = new System.Drawing.Size(50, 50);
            this.btn_groundRat.TabIndex = 2;
            this.btn_groundRat.UseVisualStyleBackColor = true;
            this.btn_groundRat.Click += new System.EventHandler(this.btn_groundRat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(316, 440);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "시간: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("궁서", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(92, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "성공했습니다";
            this.label2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.난이도ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.끝내기ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "메뉴";
            // 
            // 난이도ToolStripMenuItem
            // 
            this.난이도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.쉬움ToolStripMenuItem,
            this.보통ToolStripMenuItem,
            this.어려움ToolStripMenuItem});
            this.난이도ToolStripMenuItem.Name = "난이도ToolStripMenuItem";
            this.난이도ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.난이도ToolStripMenuItem.Text = "난이도 설정";
            // 
            // 쉬움ToolStripMenuItem
            // 
            this.쉬움ToolStripMenuItem.Name = "쉬움ToolStripMenuItem";
            this.쉬움ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.쉬움ToolStripMenuItem.Text = "쉬움";
            this.쉬움ToolStripMenuItem.Click += new System.EventHandler(this.쉬움ToolStripMenuItem_Click);
            // 
            // 보통ToolStripMenuItem
            // 
            this.보통ToolStripMenuItem.Name = "보통ToolStripMenuItem";
            this.보통ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.보통ToolStripMenuItem.Text = "보통";
            this.보통ToolStripMenuItem.Click += new System.EventHandler(this.보통ToolStripMenuItem_Click);
            // 
            // 어려움ToolStripMenuItem
            // 
            this.어려움ToolStripMenuItem.Name = "어려움ToolStripMenuItem";
            this.어려움ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.어려움ToolStripMenuItem.Text = "어려움";
            this.어려움ToolStripMenuItem.Click += new System.EventHandler(this.어려움ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "---";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(195, 273);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "다시하기";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(294, 273);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "종료";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btn_groundRat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "두더쥐게임";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_groundRat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 난이도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쉬움ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보통ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 어려움ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_close;
    }
}

