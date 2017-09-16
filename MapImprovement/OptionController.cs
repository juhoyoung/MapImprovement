using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapImprovement
{
    class OptionController
    {
        public static OptionController oController = new OptionController();

        private int ServerPort = 10000; // 서버 포트
        private int ConnectPort = 10000; // 클라이언트에서 연결할 포트
        private String ConnectIP = "127.0.0.1"; // 클라이언트에서 연결할 아이피 주소
        private Color PenColor = Color.Red; // 펜 색상
        private float PenWidth = 4; // 펜 두께


        public int getServerPort()
        {
            return ServerPort;
        }
        public void setServerPort(int ServerPort)
        {
            this.ServerPort = ServerPort;
        }

        public int getConnectPort()
        {
            return ServerPort;
        }
        public void setConnectPort(int ConnectPort)
        {
            this.ConnectPort = ConnectPort;
        }

        public String getConnectIP()
        {
            return ConnectIP;
        }
        public void setConnectIP(String ConnectIP)
        {
            this.ConnectIP = ConnectIP;
        }

        public Color getPenColor()
        {
            return PenColor;
        }
        public void setPenColor(Color PenColor)
        {
            this.PenColor = PenColor;
        }

        public float getPenWidth()
        {
            return PenWidth;
        }
        public void setPenWidth(float PenWidth)
        {
            this.PenWidth = PenWidth;
        }
    }
}
