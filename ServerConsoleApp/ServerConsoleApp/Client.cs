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
        static string adres = "127.0.0.1";
        static int port = 1001;
        public static TcpListener server = new TcpListener(new IPEndPoint(IPAddress.Parse(adres), port));
        public static List<string> names = new List<string>();
        public static List<Client> users = new List<Client>();

        public TcpClient client;
        public Thread message;
        public string nazwa;
        public string connectionTime;
        public BinaryReader reading;
        public BinaryWriter writing;
        public bool connected = true;
        public string recivedMessge;
        public string end = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";


        public Client(ref TcpClient newConnection,ref BinaryReader newStreamReader, ref String newNick, string whenConnect)
        {
            client = newConnection;
            nazwa = newNick;
            connectionTime = whenConnect;
            reading = newStreamReader;
            writing = new BinaryWriter(client.GetStream());

            message = new Thread(new ThreadStart(() =>
            {
                Broadcast(nazwa + " has connected", "Server");
                while (connected)
                { 
                    try
                    {
                        recivedMessge = reading.ReadString();
                        if ( recivedMessge == end)
                        {
                            Broadcast(nazwa + " has disconnected", "Server" );
                            Delete(this);
                            connected = false;
                        }
                        else
                        {
                            Broadcast(recivedMessge, nazwa);
                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.message.Abort();
            }));
            message.Start();
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
        }
       

    }
}
