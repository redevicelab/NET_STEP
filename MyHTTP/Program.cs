using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyHTTP
{
    class Program
    {
        static Thread threadListener;
       
        public static void Method1(object prefix)
        {
            HttpListener listener = new HttpListener();

            listener.Prefixes.Add(prefix.ToString());
            listener.Start();
            while (true)
            {
                Console.WriteLine("Прослушка работает..");
                HttpListenerContext context = listener.GetContext();
                
                HttpListenerRequest request = context.Request;
                var qry = request.RawUrl.Split('/');
                string Segment = null;
                Segment = qry[1];
                Console.WriteLine("Получено.." + Segment);


                HttpListenerResponse response = context.Response;

                string responseString = "<HTML><BODY> HELLO " + Segment + " </BODY></HTML>";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);

                output.Close();
            }
            listener.Stop();
        }
       
        static void Main(string[] args)
        {
            threadListener = new Thread(new ParameterizedThreadStart(Method1));
            threadListener.Start("http://localhost:12345/");
           
            //Method1("http://localhost:12345/");
        }
    }
}