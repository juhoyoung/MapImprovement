using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MapImprovement
{
    class SocketClient
    {
        Thread t_handler; // getMessage 처리 스레드
        bool ConnectState = false; // 연결 상태
        CanvasForm cForm;
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;


        public SocketClient(CanvasForm cForm)
        {
            this.cForm = cForm;
            ConnectServer();
        }

        public void SetConnectState()
        {
            
            bool temp = ConnectState;
            ConnectState = clientSocket.Connected;

            if (ConnectState != temp) // 연결 상태 바뀌면 알려줌
            {
                Console.WriteLine(ConnectState); 
                cForm.ChangeConnectState(ConnectState);
            }
        }

        public bool ConnectServer()
        {
            String IPAddress;
            int Port;

            IPAddress = OptionController.instance.getConnectIP();
            Port = OptionController.instance.getConnectPort();
            try
            {
                //clientSocket.Connect("110.14.208.196", 10000);
                clientSocket.Connect(IPAddress, Port);
                
                stream = clientSocket.GetStream();

                message = "Connected to Chat Server";
                DisplayText(message);
                SetConnectState(); // 서버 상태 체크

                byte[] buffer = Encoding.Unicode.GetBytes("$");
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();

                t_handler = new Thread(GetMessage); // 서버에서 오는 메세지 기다리기 위해 스레드
                t_handler.IsBackground = true;
                t_handler.Start();
                
            }
            catch(SocketException e)
            {
                MessageBox.Show("IP 주소나 Port 번호를 확인해주세요." + e);
                return false;
            }

            return true;
        }

        public void DisConnectServer()
        {
            //t_handler.Join();
            //t_handler.Interrupt();
            t_handler.Abort();
            clientSocket.Close();
            SetConnectState();
            Console.WriteLine("히히");
        }
        public void SendMessage(String drawInfo)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(drawInfo + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }


        private void GetMessage() 
        {
            while (true)
            {
                try
                {
                    stream = clientSocket.GetStream();
                    int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                    byte[] buffer = new byte[BUFFERSIZE];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                    //DisplayText(message);
                    Drawing(message);
                }
                catch(IOException e)
                {
                    Console.WriteLine("GetMessage Exception : " + e);
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine("GetMessage Exception : " + e);
                    SetConnectState();
                    DisConnectServer();
                }
                catch(ThreadAbortException)
                {
                    Console.WriteLine("GetMessage Thread 중단 ");
                }
            }
        }

        private void DisplayText(string text)
        {
            Console.WriteLine("Client" + " " + text);
            
        }

        private void Drawing(string text)
        {
            cForm.Drawing(text);
        }
    }
}
