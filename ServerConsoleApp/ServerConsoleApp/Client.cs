using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;

namespace ServerConsoleApp
{
    class Client
    {
        static string adres;
        static int port;
        public static TcpListener server = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1001));
        public static List<string> names = new List<string>();
        public static List<Client> users = new List<Client>();

        public TcpClient client;
        public Thread message;
        public string nazwa;
        public string connectionTime;
        public BinaryReader reading;
        public BinaryWriter writing;


        public Client(ref TcpClient newConnection,ref BinaryReader newStreamReader, ref String newNick, string whenConnect)
        {
            client = newConnection;
            nazwa = newNick;
            connectionTime = whenConnect;
            reading = newStreamReader;
            writing = new BinaryWriter(client.GetStream());

            message = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        Broadcast(reading.ReadString(), nazwa);
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            });
        }

            public static void Broadcast(String message, String sender)
        {
            foreach(Client client in users)
            {
                client.writing.Write(sender + ": "+ message);
                client.writing.Flush();
            }
        }

        public static void Delete(Client dissconnectedClient)
        {
            names.Remove(dissconnectedClient.nazwa);
            users.Remove(dissconnectedClient);
            dissconnectedClient.message.Abort();
        }
       

    }
}
