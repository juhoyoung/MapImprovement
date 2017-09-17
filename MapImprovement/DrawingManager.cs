using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapImprovement
{

    class DrawingManager
    {
        string DrawInfoSet = ""; // 그리기 정보
        int countInfoset = 0; // 펜 정보 몇개 쌓였는지
        int startX = 0, startY = 0;
        Color PenColor = Color.Red; // 펜 색깔
        Color SubPenColor = Color.Red; // 외부 펜 색깔
        float PenWidth = 4.0f; // 펜 굵기
        float SubPenWidth = 4.0f; // 외부 펜 굵기
        ViewForm vForm = new ViewForm();

        CanvasForm cForm;
        public DrawingManager(CanvasForm cForm)
        {
            this.cForm = cForm;
            vForm.Show();
        }

        public void SetStartPoint(Point p) // 마우스 첫클릭시 좌표
        {
            startX = p.X;
            startY = p.Y;
        }
        
        public String getDrawInfoSet()
        {
            String tempInfo;
            tempInfo = DrawInfoSet;
            DrawInfoSet = "";
            countInfoset = 0;
            return tempInfo;
        }

        public void Drawing(MouseEventArgs e) // 내가 그릴때
        {
            countInfoset++;

            Pen myPen;
            myPen = new System.Drawing.Pen(PenColor, PenWidth); // 펜 설정

            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //myPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(10,0,0,255));


            Graphics formGraphics = vForm.CreateGraphics(); // viewForm 에 대신 그림
                                                            //Console.WriteLine(e.X + " " + e.Y);
            formGraphics.DrawLine(myPen, startX, startY, e.X, e.Y);
            DrawInfoSet += ((startX + "," + startY + "," + e.X + "," + e.Y + "," + PenColor.Name + "," + PenWidth.ToString()).ToString() + ",<EOF>\n");

            startX = e.X;
            startY = e.Y;

            if (countInfoset >= 30)
            {
                // 서버 전송
                cForm.SendPenInfo(DrawInfoSet);
                countInfoset = 0;
                DrawInfoSet = "";
            }

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void Drawing(String penInfo) // 서버에서 받아서 그림.
        {
            String[] SplitPenInfo = penInfo.Split('\n'); // 10개씩 받은 정보 분할    
            for (int i = 0; i < SplitPenInfo.Length - 1; i++)
            {
                String[] Info = new String[6]; // 0,1,2,3 = 점 좌표 / 4 = 펜 색상 / 5 = 펜 굵기
                Info = SplitPenInfo[i].Split(',');

                SubPenColor = ColorClassification(Info[4], true); // 펜 색상
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

        public Color ColorClassification(String color, bool isReturn = false) // 펜 색상 분류 , 리턴 값이 필요한지
        {
            Color tempColor = System.Drawing.Color.Red;

            if (isReturn == true) // 서버에서 들어온 값 처리
            {
                switch (color)
                {
                    case "Red":
                        tempColor = Color.Red;
                        break;

                    case "Blue":
                        tempColor = Color.Blue;
                        break;

                    case "Yellow":
                        tempColor = Color.Yellow;
                        break;

                    case "Orange":
                        tempColor = Color.Orange;
                        break;

                    case "Lime":
                        tempColor = Color.Lime;
                        break;

                }
                //Console.WriteLine(tempColor);

                return tempColor;
            }
            else // 내가 그린거 바로 씀
            {
                switch (color)
                {
                    case "빨강색":
                        PenColor = Color.Red;
                        break;

                    case "파랑색":
                        PenColor = Color.Blue;
                        break;

                    case "노랑색":
                        PenColor = Color.Yellow;
                        break;

                    case "주황색":
                        PenColor = Color.Orange;
                        break;

                    case "초록색":
                        PenColor = Color.Lime;
                        break;
                }
            }

            return tempColor;
        }


        public float PenWidthClassification(String width, bool isReturn = false) // 펜 굵기 분류 , 리턴 값이 필요한지
        {
            //Console.WriteLine(width);
            float temp = 4.0f;
            
            switch (width)
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

            return temp;
        }
    }
}
