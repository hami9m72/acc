using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoAnCSharp.Utils
{
    public class SimpleServer
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;


        public void StartServer()
        {
            //serverLogsText.Text = "";

            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    //serverPort = int.Parse(serverPortText.Text.ToString());

                    if (serverPort > 65535 || serverPort <= 0)
                    {
                        throw new Exception("Server Port not within the range");
                    }
                }
                catch (Exception ex)
                {
                    serverPort = 80;
                    Console.WriteLine("Server Failed to Start on Specified Port \n");
                }
                thread = new Thread(new ThreadStart(this.connectionThreadMethod));
                thread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                Console.WriteLine("Server Starting Failed \n");
            }

            Console.WriteLine("Server Started");
        }

        public void StopServer()
        {
            try
            {
                // Close the Socket
                httpServer.Close();

                // Kill the Thread
                thread.Abort();

                // Disable and Enable Buttons
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopping Failed");
            }
        }

        private void connectionThreadMethod()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endpoint);
                httpServer.Listen(1);
                startListeningForConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("I could nt start");
            }
        }

        private void startListeningForConnection()
        {
            while (true)
            {
                DateTime time = DateTime.Now;

                String data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept(); // Blocking Statement

                // Reading the inbound connection data
                while (true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                // Data Read

                

                // Send back the Response
                String resHeader = "HTTP/1.1 200 Everything is Fine\nServer: my_csharp_server\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = "<!DOCTYE html> " +
                    "<html>" +
                    "<head><title>My Server</title></head>" +
                    "<body>" +
                    "<h4>Server Time is: " + time.ToString() + "</h4>" +
                    "</body></html>";

                String resStr = resHeader + resBody;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);
                
                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();
            }
        }
    }
}
