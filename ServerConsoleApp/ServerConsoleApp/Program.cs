using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace ServerConsoleApp
{
    class Program
    {
      

        static Thread waitForConnect = new Thread(() =>
        {
            Console.WriteLine("Server Working...");
            while (true)
            {
                TcpClient tpcClient = Client.server.AcceptTcpClient();
                BinaryReader Reader = new BinaryReader(tpcClient.GetStream());
                String nazwa = Reader.ReadString();
                while (Client.names.Contains(nazwa))
                {
                    nazwa += " - sobowtór";
                }
                Client.names.Add(nazwa);
                Client.users.Add(new Client(ref tpcClient, ref Reader, ref nazwa, DateTime.Now.ToString("h:mm:ss tt")));
                Console.WriteLine(nazwa + " joined");
            }
        });

       
       
        static void Main(string[] args)
        {
            Client.server.Start();
            waitForConnect.Start();
        }
    }
}
