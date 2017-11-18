using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kockanap
{
    class Program
    {
        public static object Window { get; private set; }

        static void Main(string[] args)
        {
            // simple geometry

            UDPServer server = new UDPServer();
            HandleDataClass hdc = new HandleDataClass();


            Thread serverThread = new Thread(() => server.Listen());
            serverThread.Start();

            Thread dataHandlerThread = new Thread(() =>
            hdc.SubscribeToEvent(server));
            dataHandlerThread.Start();
            Thread http = new Thread(() => httpCliens.SimpleListenerExample());
            http.Start();

            while (true)
            {
                Thread.Sleep(100);
            }
             
        }
    }
}
