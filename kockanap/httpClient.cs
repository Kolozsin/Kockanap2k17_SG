using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace kockanap
{
    class httpCliens
    {
        public static void SimpleListenerExample()
        {
            string prefixes = "http://192.168.1.15:1945/simpleg/";
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Create a listener.
            HttpListener listener = new HttpListener();
            // Add the prefixes.
                listener.Prefixes.Add(prefixes);

            listener.Start();
            while (true)
            {
                // Note: The GetContext method blocks while waiting for a request. 
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                string raw = request.Url.Query;
                string matchid = raw.Substring(7, raw.Length - 7).Split('&').First();
                string player = raw.Substring(7, raw.Length - 7).Split('&').Last().Last().ToString();
                // Obtain a response object.
                HttpListenerResponse response = context.Response;
              
                // Construct a response.
                string responseString = Calculate(matchid, player);
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                //listener.Stop();
            }

        }

        private static string Calculate( string matchid, string player)
        {
           
           return HandleDataClass.cucc.merkozesek.Find(x => x.merkozesazonosito == matchid).Move(player);
        
        }
    }
}
