using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapImprovement
{

    public partial class CanvasForm : Form
    {
        ClientSettingForm cSetForm; // 클라이언트 접속할때 뜨는 폼
        ServerSettingForm sSetForm;
        
        bool isVisible = true; // 폼 숨기고 표시하기 위한 변수
        bool isServerState = false; // 서버 열었는지.
        bool isConnected = false; // 클라이언트 일 때 서버 연결 되어있는지.


        DrawingManager dManager; // 그리기 총괄

        SocketServer sServer;
        SocketClient sClient;
        
        public CanvasForm()
        {   
            InitializeComponent();
            cSetForm = new ClientSettingForm();
            sSetForm = new ServerSettingForm();
            //this.Size = new Size(System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height);
            this.Location = new Point(0, 0);
            KeyProcessing.kProcessing.SetHook();
            dManager = new DrawingManager(this);


        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            KeyProcessing.kProcessing.getCanvasForm(this);
        }


        public void SetVisibleForm() // 폼 visible 설정
        {
            Console.WriteLine("canvas setvisibleForm 호출");
            if (isVisible == true)
            {
                this.Hide();
                isVisible = false;

            }
            else
            {
                this.Show();
                isVisible = true;
            }
        }



        //System.Drawing.SolidBrush brushBlue = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

        private void CanvasForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 그리기 첫 좌표
            {
                Console.WriteLine("마우스 클릭");
                dManager.SetStartPoint(new Point(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right) // 우클릭시 메뉴
            {
                Console.WriteLine("마우스 우클릭");
                
                contextMenu1.Show(Cursor.Position);
            }
        }


        private void CanvasForm_MouseMove(object sender, MouseEventArgs e) // 마우스 다운 처리
        {
            if (e.Button == MouseButtons.Left)
            {
                dManager.Drawing(e);

            }
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e) // 마우스 올릴때.
        {
            if (e.Button == MouseButtons.Left)
            {
                //////////////////////////////////////////////////////////////////////////////////////
                String DInfoSet; // 그림 정보 받아오는 변수
                DInfoSet = dManager.getDrawInfoSet();
                SendPenInfo(DInfoSet);
            }
        }

        public void Drawing(String penInfo) // 서버 요청 그리기
        {
            dManager.Drawing(penInfo);
        }

        public void SendPenInfo(String DrawInfoSet)
        {
            if (isConnected == true) // 클라이언트에서 서버로 그림정보 보냄
                sClient.SendMessage(DrawInfoSet);

            if (isServerState == true) // 서버에서 클라이언트로 그림정보 보냄
                sServer.SendMessageAll(DrawInfoSet, "Server", true);

            DrawInfoSet = "";
        }


        public void ChangeServerState(bool state) // 서버 열때 서버 상태 체크
        {
            //Console.WriteLine("서버 상태" + state);
            isServerState = state;

            if(isServerState == true) // 열려있으면 또 못열게
            {
                방참가ToolStripMenuItem.Enabled = false;
                CreateServer_MenuItem.Enabled = false;
                CloseServer_MenuItem.Enabled = true;
            }
            else
            {
                방참가ToolStripMenuItem.Enabled = true;
                CreateServer_MenuItem.Enabled = true;
                CloseServer_MenuItem.Enabled = false;
            }
        }


        public void ChangeConnectState(bool state) // 클라이언트에서 서버 연결 상태 체크
        {
            //Console.WriteLine("서버 상태" + state);
            isConnected = state;            
            if (isConnected == true) // 열려있으면 또 못열게
            {
                방만들기ToolStripMenuItem.Enabled = false;
                ConnectServer_MenuItem.Enabled = false;
                DisConnectServer_MenuItem.Enabled = true;
            }
            else
            {
                방만들기ToolStripMenuItem.Enabled = true;
                ConnectServer_MenuItem.Enabled = true;
                DisConnectServer_MenuItem.Enabled = false;
            }
        }

        private void contextMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) // 컨텍스트 메뉴 컨트롤
        {

        }
        private void 색상ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) // 색상 메뉴 컨트롤
        {
            Console.WriteLine(e.ClickedItem);
            // 빨 파 노 주 초
            dManager.ColorClassification(e.ClickedItem.ToString());

        }


        private void 펜굵기ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) // 펜 굵기 컨트롤
        {
            Console.WriteLine(e.ClickedItem);
            dManager.PenWidthClassification(e.ClickedItem.ToString());
        }

        private void CreateServer_MenuItem_Click(object sender, EventArgs e) // 서버 만들때 Server
        {
            sSetForm.ShowDialog();
            sServer = new SocketServer(this);
        }

        private void CloseServer_MenuItem_Click(object sender, EventArgs e) // 서버 닫을때 Server
        {
            sServer.CloseServer();
        }

        private void ConnectServer_MenuItem_Click(object sender, EventArgs e) // 서버 참가할떄 Client
        {
            cSetForm.ShowDialog();
            sClient = new SocketClient(this);
        }

        private void DisConnectServer_MenuItem_Click(object sender, EventArgs e) // 서버 연결 끊을때 Client
        {
            sClient.DisConnectServer();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
