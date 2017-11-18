using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
    public class UDPServer
    {
        
        public void Listen()
        {
            UdpClient listener = new UdpClient(1940);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("192.168.1.15"), 1940); // 123 módosítani
            while (true)
            {
                byte[] data = listener.Receive(ref serverEP);
                RaiseDataReceived(new ReceivedDataArgs(serverEP.Address, serverEP.Port, data));
            }
        }
        public delegate void DataReceived(object sender, ReceivedDataArgs args);
        public event DataReceived DataReceivedEvent;
        private void RaiseDataReceived(ReceivedDataArgs args)
        {
            if (DataReceivedEvent != null)
                DataReceivedEvent(this, args);
        }
    }
    public class ReceivedDataArgs
    {
        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }
        public byte[] ReceivedBytes;
        public ReceivedDataArgs(IPAddress ip, int port, byte[] data)
        {
            this.IpAddress = ip;
            this.Port = port;
            this.ReceivedBytes = data;
        }
    }
    public class  HandleDataClass
    {
        public static Blokk cucc = new Blokk();
        public void SubscribeToEvent(UDPServer server)
        {
            server.DataReceivedEvent += server_DataReceivedEvent;
        }

        void Kiir(string ki)
        {
            string[] cucc2 = ki.Split('?');
            string[] cucc3 = new string[2];
            int xyz = 0;
            for (int i = 0; i < cucc2.Length; i++)
            {
                if (cucc2[i].Contains("59998"))
                {
                    cucc3[xyz] = cucc2[i];
                    xyz++;
                }
            }
            string[] jatekosokEsLabda = cucc3[0].Split('|');
            if (cucc3[1]!=null)
            {
                string[] eredmenyek = cucc3[1].Split('|');
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Labda:\t{0}\t{1}", jatekosokEsLabda[1], jatekosokEsLabda[2]);
                Console.WriteLine();
                Console.WriteLine("P1-U1:\t{0}\t{1}", jatekosokEsLabda[3], jatekosokEsLabda[4]);
                Console.WriteLine("P1-U2:\t{0}\t{1}", jatekosokEsLabda[5], jatekosokEsLabda[6]);
                Console.WriteLine("P1-U3:\t{0}\t{1}", jatekosokEsLabda[7], jatekosokEsLabda[8]);
                Console.WriteLine();
                Console.WriteLine("P2-U1:\t{0}\t{1}", jatekosokEsLabda[9], jatekosokEsLabda[10]);
                Console.WriteLine("P2-U2:\t{0}\t{1}", jatekosokEsLabda[11], jatekosokEsLabda[12]);
                Console.WriteLine("P2-U3:\t{0}\t{1}", jatekosokEsLabda[13], jatekosokEsLabda[14]);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Eredmény:\nP1G: {0} P:{1}", eredmenyek[1], eredmenyek[2]);
                Console.WriteLine("P2G: {0} P:{1}", eredmenyek[3], eredmenyek[4]);
            }
        }
        void server_DataReceivedEvent(object sender, ReceivedDataArgs args)
        {

            //Console.WriteLine("Received message from [{0}:{1}]:\r\n{2}",
            //    args.IpAddress.ToString(), args.Port.ToString(),
            //    Encoding.ASCII.GetString(args.ReceivedBytes));
          
            cucc.CsomagDarabolas(Encoding.ASCII.GetString(args.ReceivedBytes));
            //Console.WriteLine("Received message from [{0}:{1}]:\r\n{2}",
            //   args.IpAddress.ToString(), args.Port.ToString(),
            //   Encoding.ASCII.GetString(args.ReceivedBytes));
            string ki = Encoding.ASCII.GetString(args.ReceivedBytes);
            Kiir(ki);
            



        }
    }

}
