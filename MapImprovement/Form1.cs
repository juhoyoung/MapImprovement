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
        ClientSettingForm cSetForm = new ClientSettingForm(); // 클라이언트 접속할때 뜨는 폼

        bool isVisible = true; // 폼 숨기고 표시하기 위한 변수
        bool isServerState = false; // 서버 열었는지.
        bool isConnected = false; // 클라이언트 일 때 서버 연결 되어있는지.

        string DrawInfoSet = ""; // 그리기 정보
        int countInfoset = 0; // 펜 정보 몇개 쌓였는지
        int x = 0, y = 0;
        Color PenColor = System.Drawing.Color.Red; // 펜 색깔
        Color SubPenColor = System.Drawing.Color.Red; // 외부 펜 색깔
        float PenWidth = 4.0f; // 펜 굵기
        float SubPenWidth = 4.0f; // 외부 펜 굵기
        ViewForm vForm = new ViewForm();

        SocketServer sServer;
        SocketClient sClient;
        
        public CanvasForm()
        {
            InitializeComponent();
            //this.Size = new Size(System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height);
            this.Location = new Point(0, 0);
            vForm.Show();
            KeyProcessing.kProcessing.SetHook();
            

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
                x = e.X;
                y = e.Y;
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
                Drawing(e);

            }
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e) // 마우스 올릴때.
        {
            if (e.Button == MouseButtons.Left)
            {
                SendPenInfo();

                DrawInfoSet = "";
                countInfoset = 0;
            }
        }
        private void SendPenInfo()
        {
            if (isConnected == true) // 클라이언트에서 서버로 그림정보 보냄
                sClient.SendMessage(DrawInfoSet);

            if (isServerState == true) // 서버에서 클라이언트로 그림정보 보냄
                sServer.SendMessageAll(DrawInfoSet, "Server", true);

            DrawInfoSet = "";
        }


        private void Drawing(MouseEventArgs e) // 내가 그릴때
        {
            countInfoset++;

            Pen myPen;
            myPen = new System.Drawing.Pen(PenColor, PenWidth); // 펜 설정
            
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //myPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(10,0,0,255));


            Graphics formGraphics = vForm.CreateGraphics(); // viewForm 에 대신 그림
                                                                           //Console.WriteLine(e.X + " " + e.Y);
            formGraphics.DrawLine(myPen, x, y, e.X, e.Y);
            DrawInfoSet += ((x + "," + y + "," + e.X + "," + e.Y + "," + PenColor.Name + "," + PenWidth.ToString()).ToString() + ",<EOF>\n");

            x = e.X;
            y = e.Y;

            if(countInfoset >= 15)
            {
                // 서버 전송
                SendPenInfo();
                countInfoset = 0;
            }

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void Drawing(String penInfo) // 서버에서 받아서 그림.
        {
            String[] SplitPenInfo = penInfo.Split('\n'); // 10개씩 받은 정보 분할    
            for(int i=0; i<SplitPenInfo.Length-1; i++)
            {
                String[] Info = new String[6]; // 0,1,2,3 = 점 좌표 / 4 = 펜 색상 / 5 = 펜 굵기
                Info = SplitPenInfo[i].Split(',');

                SubPenColor = ColorClassification(Info[4]); // 펜 색상
                SubPenWidth = float.Parse(Info[5]); // 펜 굵기

                Pen myPen;
                myPen = new Pen(SubPenColor, SubPenWidth); // 펜 설정

                myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                //myPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(10,0,0,255));

                Graphics formGraphics = vForm.CreateGraphics(); // viewForm 에 대신 그림
                formGraphics.DrawLine(myPen, float.Parse(Info[0]), float.Parse(Info[1]), float.Parse(Info[2]), float.Parse(Info[3]));

                myPen.Dispose();
                formGraphics.Dispose();
            }
        }

        public void ChangeServerState(bool state) // 서버 열때 서버 상태 체크
        {
            //Console.WriteLine("서버 상태" + state);
            isServerState = state;

            if(isServerState == true) // 열려있으면 또 못열게
            {

            }
            else
            {

            }
        }

        public void ChangeConnectState(bool state) // 클라이언트에서 서버 연결 상태 체크
        {
            //Console.WriteLine("서버 상태" + state);
            isConnected = state;            
            if (isConnected == true) // 열려있으면 또 못열게
            {

                참가하기ToolStripMenuItem.Enabled = false;
                연결끊기ToolStripMenuItem.Enabled = true;
            }
            else
            {
                참가하기ToolStripMenuItem.Enabled = true;
                연결끊기ToolStripMenuItem.Enabled = false;
            }
        }
        private Color ColorClassification(String color) // 펜 색상 분류
        {
            Color tempColor = System.Drawing.Color.Red;

            switch (color)
            {
                case "빨강색":
                    tempColor = System.Drawing.Color.Red;
                    break;

                case "Red":
                    tempColor = System.Drawing.Color.Red;
                    break;

                case "파랑색":
                    tempColor = System.Drawing.Color.Blue;
                    break;

                case "Blue":
                    tempColor = System.Drawing.Color.Blue;
                    break;

                case "노랑색":
                    tempColor = System.Drawing.Color.Yellow;
                    break;

                case "Yellow":
                    tempColor = System.Drawing.Color.Yellow;
                    break;

                case "주황색":
                    tempColor = System.Drawing.Color.Orange;
                    break;

                case "Orange":
                    tempColor = System.Drawing.Color.Orange;
                    break;

                case "초록색":
                    tempColor = System.Drawing.Color.Lime;
                    break;

                case "Lime":
                    tempColor = System.Drawing.Color.Lime;
                    break;

            }

            //Console.WriteLine(tempColor);

            return tempColor;
        }

        private void contextMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) // 컨텍스트 메뉴 컨트롤
        {

        }
        private void 색상ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) // 색상 메뉴 컨트롤
        {
            Console.WriteLine(e.ClickedItem);
            // 빨 파 노 주 초
            PenColor = ColorClassification(e.ClickedItem.ToString());

        }


        private void 펜굵기ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) // 펜 굵기 컨트롤
        {
            Console.WriteLine(e.ClickedItem);
            // 빨 파 노 주 초
            switch (e.ClickedItem.ToString())
            {
                case "얇은 선":
                    PenWidth = 2.0f;
                    break;

                case "기본 선":
                    PenWidth = 4.0f;
                    break;

                case "굵은 선":
                    PenWidth = 6.0f;
                    break;


            }
        }

        private void 참가하기ToolStripMenuItem_Click(object sender, EventArgs e) // 서버 참가할떄
        {
            cSetForm.ShowDialog();
            sClient = new SocketClient(this);

        }

        private void 방만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sServer = new SocketServer(this);
        }

        private void 연결끊기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sClient.DisConnectServer();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e) // 종료
        {
            Application.Exit();
        }

    }
}
