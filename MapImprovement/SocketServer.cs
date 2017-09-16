using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapImprovement
{
    class SocketServer
    {
        bool ServerState = false;
        CanvasForm cForm;
        TcpListener server = null;
        TcpClient clientSocket = null;
        static int counter = 0;

        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public SocketServer(CanvasForm cForm)
        {
            this.cForm = cForm;
            // socket start
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        public void SetServerState() // 서버 상태 바뀔때 호출
        {
            bool temp = ServerState;
            try
            {
                ServerState = server.Server.IsBound;
            }
            catch (Exception)
            {
                Console.WriteLine("SocketServerState Exception");
                ServerState = false;
            }

            if (ServerState != temp)
                cForm.ChangeServerState(ServerState);
        }

        

        private void InitSocket()
        {
            //server = new TcpListener(IPAddress.Parse("192.168.35.168"), 10000);
            server = new TcpListener(IPAddress.Any, 10000);

            try
            {
                
                clientSocket = default(TcpClient);

                
                server.Start(); 
                DisplayText(">> Server Started");
                SetServerState();


                while (true)
                {
                    try
                    {
                        counter++;
                        clientSocket = server.AcceptTcpClient();
                        DisplayText(">> Accept connection from client");

                        NetworkStream stream = clientSocket.GetStream();
                        byte[] buffer = new byte[1024];
                        int bytes = stream.Read(buffer, 0, buffer.Length);
                        string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                        user_name = user_name.Substring(0, user_name.IndexOf("$"));

                        clientList.Add(clientSocket, user_name);

                        // send message all user
                        //SendMessageAll(user_name + " Joined ", "", false);

                        handleClient h_client = new handleClient();
                        h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                        h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                        h_client.startClient(clientSocket, clientList);
                    }
                    catch (SocketException se)
                    {
                        Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                        break;
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                        break;
                    }
                }

                clientSocket.Close();
                server.Stop();
            }
            catch(SocketException e)
            {
                SetServerState();
                MessageBox.Show("아이피 주소를 확인하세요! \n " + e);
            }
        }

        public void CloseServer() // 서버 닫기
        {
            try
            {
                clientSocket.Close();
                server.Stop();
                SetServerState();
            }
            catch(SocketException e)
            {
                Console.WriteLine("CloseServer Exception" + e);
            }
        }

        void h_client_OnDisconnected(TcpClient clientSocket)
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }

        private void OnReceived(string message, string user_name)
        {
            //string displayMessage = "From client : " + user_name + " : " + message;
            string displayMessage = message;
            //DisplayText(displayMessage); // 콘솔 출력
            Drawing(displayMessage); // 그리기
            SendMessageAll(message, user_name, true);
        }

        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList)
            {
                Trace.WriteLine(string.Format("tcpclient : {0} user_name : {1}", pair.Key, pair.Value));

                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    //buffer = Encoding.Unicode.GetBytes(user_name + " says : " + message); // 클라이언트에게 전달
                    buffer = Encoding.Unicode.GetBytes(message);
                }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        private void DisplayText(string text)
        {
            Console.WriteLine("Server : " + " " + text);
            
        }

        private void Drawing(string text)
        {
            cForm.Drawing(text);
        }
    }
}

