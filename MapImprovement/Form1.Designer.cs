namespace MapImprovement
{
    partial class CanvasForm
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
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빨강ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파랑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.노랑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.펜굵기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.얇은선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기본선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵은선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방참가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.참가하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연결끊기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색상ToolStripMenuItem,
            this.펜굵기ToolStripMenuItem,
            this.방만들기ToolStripMenuItem,
            this.방참가ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(153, 136);
            this.contextMenu1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu1_ItemClicked);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빨강ToolStripMenuItem,
            this.파랑ToolStripMenuItem,
            this.노랑ToolStripMenuItem,
            this.주황ToolStripMenuItem,
            this.초록ToolStripMenuItem});
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.색상ToolStripMenuItem.Text = "색상";
            this.색상ToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.색상ToolStripMenuItem_DropDownItemClicked);
            // 
            // 빨강ToolStripMenuItem
            // 
            this.빨강ToolStripMenuItem.Name = "빨강ToolStripMenuItem";
            this.빨강ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.빨강ToolStripMenuItem.Text = "빨강색";
            // 
            // 파랑ToolStripMenuItem
            // 
            this.파랑ToolStripMenuItem.Name = "파랑ToolStripMenuItem";
            this.파랑ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.파랑ToolStripMenuItem.Text = "파랑색";
            // 
            // 노랑ToolStripMenuItem
            // 
            this.노랑ToolStripMenuItem.Name = "노랑ToolStripMenuItem";
            this.노랑ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.노랑ToolStripMenuItem.Text = "노랑색";
            // 
            // 주황ToolStripMenuItem
            // 
            this.주황ToolStripMenuItem.Name = "주황ToolStripMenuItem";
            this.주황ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.주황ToolStripMenuItem.Text = "주황색";
            // 
            // 초록ToolStripMenuItem
            // 
            this.초록ToolStripMenuItem.Name = "초록ToolStripMenuItem";
            this.초록ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.초록ToolStripMenuItem.Text = "초록색";
            // 
            // 펜굵기ToolStripMenuItem
            // 
            this.펜굵기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.얇은선ToolStripMenuItem,
            this.기본선ToolStripMenuItem,
            this.굵은선ToolStripMenuItem});
            this.펜굵기ToolStripMenuItem.Name = "펜굵기ToolStripMenuItem";
            this.펜굵기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.펜굵기ToolStripMenuItem.Text = "펜 굵기";
            this.펜굵기ToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.펜굵기ToolStripMenuItem_DropDownItemClicked);
            // 
            // 얇은선ToolStripMenuItem
            // 
            this.얇은선ToolStripMenuItem.Name = "얇은선ToolStripMenuItem";
            this.얇은선ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.얇은선ToolStripMenuItem.Text = "얇은 선";
            // 
            // 기본선ToolStripMenuItem
            // 
            this.기본선ToolStripMenuItem.Name = "기본선ToolStripMenuItem";
            this.기본선ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.기본선ToolStripMenuItem.Text = "기본 선";
            // 
            // 굵은선ToolStripMenuItem
            // 
            this.굵은선ToolStripMenuItem.Name = "굵은선ToolStripMenuItem";
            this.굵은선ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.굵은선ToolStripMenuItem.Text = "굵은 선";
            // 
            // 방만들기ToolStripMenuItem
            // 
            this.방만들기ToolStripMenuItem.Name = "방만들기ToolStripMenuItem";
            this.방만들기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.방만들기ToolStripMenuItem.Text = "방 만들기";
            this.방만들기ToolStripMenuItem.Click += new System.EventHandler(this.방만들기ToolStripMenuItem_Click);
            // 
            // 방참가ToolStripMenuItem
            // 
            this.방참가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.참가하기ToolStripMenuItem,
            this.연결끊기ToolStripMenuItem});
            this.방참가ToolStripMenuItem.Name = "방참가ToolStripMenuItem";
            this.방참가ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.방참가ToolStripMenuItem.Text = "방 참가";
            // 
            // 참가하기ToolStripMenuItem
            // 
            this.참가하기ToolStripMenuItem.Name = "참가하기ToolStripMenuItem";
            this.참가하기ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.참가하기ToolStripMenuItem.Text = "참가 하기";
            this.참가하기ToolStripMenuItem.Click += new System.EventHandler(this.참가하기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 연결끊기ToolStripMenuItem
            // 
            this.연결끊기ToolStripMenuItem.Enabled = false;
            this.연결끊기ToolStripMenuItem.Name = "연결끊기ToolStripMenuItem";
            this.연결끊기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.연결끊기ToolStripMenuItem.Text = "연결 끊기";
            this.연결끊기ToolStripMenuItem.Click += new System.EventHandler(this.연결끊기ToolStripMenuItem_Click);
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CanvasForm";
            this.Opacity = 0.4D;
            this.Text = "Canvas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CanvasForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasForm_MouseUp);
            this.contextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빨강ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파랑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 노랑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 초록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 펜굵기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 얇은선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기본선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵은선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방참가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 참가하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연결끊기ToolStripMenuItem;
    }
}

