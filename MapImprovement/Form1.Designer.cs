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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanvasForm));
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
            this.CreateServer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseServer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방참가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectServer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisConnectServer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopDrawing_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HidePicture_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPicture_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartDrawing_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotKey_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu1.SuspendLayout();
            this.notify_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HidePicture_MenuItem,
            this.색상ToolStripMenuItem,
            this.펜굵기ToolStripMenuItem,
            this.StopDrawing_MenuItem,
            this.방만들기ToolStripMenuItem,
            this.방참가ToolStripMenuItem,
            this.HotKey_MenuItem,
            this.Exit_MenuItem});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(153, 202);
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
            this.방만들기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateServer_MenuItem,
            this.CloseServer_MenuItem});
            this.방만들기ToolStripMenuItem.Name = "방만들기ToolStripMenuItem";
            this.방만들기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.방만들기ToolStripMenuItem.Text = "방 만들기";
            // 
            // CreateServer_MenuItem
            // 
            this.CreateServer_MenuItem.Name = "CreateServer_MenuItem";
            this.CreateServer_MenuItem.Size = new System.Drawing.Size(126, 22);
            this.CreateServer_MenuItem.Text = "방 만들기";
            this.CreateServer_MenuItem.Click += new System.EventHandler(this.CreateServer_MenuItem_Click);
            // 
            // CloseServer_MenuItem
            // 
            this.CloseServer_MenuItem.Name = "CloseServer_MenuItem";
            this.CloseServer_MenuItem.Size = new System.Drawing.Size(126, 22);
            this.CloseServer_MenuItem.Text = "방 닫기";
            this.CloseServer_MenuItem.Click += new System.EventHandler(this.CloseServer_MenuItem_Click);
            // 
            // 방참가ToolStripMenuItem
            // 
            this.방참가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectServer_MenuItem,
            this.DisConnectServer_MenuItem});
            this.방참가ToolStripMenuItem.Name = "방참가ToolStripMenuItem";
            this.방참가ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.방참가ToolStripMenuItem.Text = "방 참가";
            // 
            // ConnectServer_MenuItem
            // 
            this.ConnectServer_MenuItem.Name = "ConnectServer_MenuItem";
            this.ConnectServer_MenuItem.Size = new System.Drawing.Size(126, 22);
            this.ConnectServer_MenuItem.Text = "참가 하기";
            this.ConnectServer_MenuItem.Click += new System.EventHandler(this.ConnectServer_MenuItem_Click);
            // 
            // DisConnectServer_MenuItem
            // 
            this.DisConnectServer_MenuItem.Enabled = false;
            this.DisConnectServer_MenuItem.Name = "DisConnectServer_MenuItem";
            this.DisConnectServer_MenuItem.Size = new System.Drawing.Size(126, 22);
            this.DisConnectServer_MenuItem.Text = "연결 끊기";
            this.DisConnectServer_MenuItem.Click += new System.EventHandler(this.DisConnectServer_MenuItem_Click);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Exit_MenuItem.Text = "종료";
            this.Exit_MenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // StopDrawing_MenuItem
            // 
            this.StopDrawing_MenuItem.Name = "StopDrawing_MenuItem";
            this.StopDrawing_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.StopDrawing_MenuItem.Text = "그리기 중지";
            this.StopDrawing_MenuItem.Click += new System.EventHandler(this.StopDrawing_MenuItem_Click);
            // 
            // HidePicture_MenuItem
            // 
            this.HidePicture_MenuItem.Name = "HidePicture_MenuItem";
            this.HidePicture_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.HidePicture_MenuItem.Text = "숨기기";
            this.HidePicture_MenuItem.Click += new System.EventHandler(this.HidePicture_MenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notify_contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Option";
            // 
            // notify_contextMenu
            // 
            this.notify_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPicture_MenuItem,
            this.StartDrawing_MenuItem});
            this.notify_contextMenu.Name = "notify_contextMenu";
            this.notify_contextMenu.Size = new System.Drawing.Size(139, 48);
            // 
            // ShowPicture_MenuItem
            // 
            this.ShowPicture_MenuItem.Name = "ShowPicture_MenuItem";
            this.ShowPicture_MenuItem.Size = new System.Drawing.Size(138, 22);
            this.ShowPicture_MenuItem.Text = "보이기";
            this.ShowPicture_MenuItem.Click += new System.EventHandler(this.ShowPicture_MenuItem_Click);
            // 
            // StartDrawing_MenuItem
            // 
            this.StartDrawing_MenuItem.Name = "StartDrawing_MenuItem";
            this.StartDrawing_MenuItem.Size = new System.Drawing.Size(138, 22);
            this.StartDrawing_MenuItem.Text = "그리기 시작";
            this.StartDrawing_MenuItem.Click += new System.EventHandler(this.StartDrawing_MenuItem_Click);
            // 
            // HotKey_MenuItem
            // 
            this.HotKey_MenuItem.Name = "HotKey_MenuItem";
            this.HotKey_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.HotKey_MenuItem.Text = "단축키";
            this.HotKey_MenuItem.Click += new System.EventHandler(this.HotKeyMenuItem_Click);
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 361);
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
            this.notify_contextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방참가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectServer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisConnectServer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateServer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseServer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopDrawing_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem HidePicture_MenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notify_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowPicture_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartDrawing_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotKey_MenuItem;
    }
}

