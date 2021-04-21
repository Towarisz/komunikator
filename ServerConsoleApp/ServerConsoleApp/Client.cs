using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

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
        public Match privatemessage;
        public string[] messagesplit;


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
                Broadcast(name(names), "Serverlist");
                while (connected)
                { 
                    try
                    {
                        recivedMessge = reading.ReadString();
                        privatemessage = Regex.Match(recivedMessge,@"^(/msg)\s");
                        if ( recivedMessge == end)
                        {
                            Broadcast(nazwa + " has disconnected", "Server" );
                            Delete(this);
                            Console.WriteLine(nazwa + " has disconnected");
                            Broadcast(name(names), "Serverlist");
                            connected = false;
                        }else if(privatemessage.Success)
                        {
                            messagesplit = recivedMessge.Split(' ');
                            Pv(recivedMessge.Substring(messagesplit[1].Length + 5),nazwa,messagesplit[1]);
                        }else
                        {
                            Broadcast(recivedMessge, nazwa);
                        }
                    }catch(Exception ex)
                    {
                        
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
                try
                {
                    client.writing.Write(sender + ": " + message);
                    client.writing.Flush();
                }
                catch { }
            }
        }

        public static void Pv(String Message,String sender,String reciver)
        {
            Client rec = users.Find(x => x.nazwa == reciver);
            Client sen = users.Find(x => x.nazwa == sender);

            if(sender == reciver)
            {
                sen.writing.Write("Server: you can't write private message to yourselfe");
            }
            else
            {
                if(rec != null)
                {
                rec.writing.Write(sender + " -> " + reciver + ": " + Message);
                sen.writing.Write(sender + " -> " + reciver + ": " + Message);
                }
                else
                {
                sen.writing.Write("Server:"+reciver+" does not exist");
                }
                
            }
        }

        public static string name(List<string> nikci)
        {
            string brrr = "";
            nikci.ForEach(x => brrr += x + " ");
            return brrr;
        }

        public static void Delete(Client dissconnectedClient)
        {
            names.Remove(dissconnectedClient.nazwa);
            users.Remove(dissconnectedClient);
        }
       

    }
}
