using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTTP_CLIENT
{
    class Program
    {

        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var content = await client.GetStringAsync("http://localhost:12345/Alex");
        //    Console.WriteLine(content);
        //}

        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("http://localhost:12345/Alex");
        //    //var result = response.Content.ReadAsStringAsync().Result;
        //    using (StreamReader sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
        //    {
        //        string result = sr.ReadToEnd();
        //        Console.WriteLine(result);
        //    }

        //}

        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetByteArrayAsync("http://localhost:12345/Alex");
        //    //var result = response.Content.ReadAsStringAsync().Result;
        //    string result = Encoding.UTF8.GetString(response);
        //    Console.WriteLine(result);
        //}

        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetStreamAsync("http://localhost:12345/Alex");            
        //    using (StreamReader sr = new StreamReader(response))
        //    {
        //        string result = sr.ReadToEnd();
        //        Console.WriteLine(result);
        //    }

        //}

        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetStreamAsync("http://localhost:12345/Alex");
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        response.CopyTo(ms);
        //        string result = Encoding.UTF8.GetString(ms.ToArray());
        //        Console.WriteLine(result);
        //    }

        //}
      

        //static void Main(string[] args)
        //{
        //    using (var client = new WebClient())
        //    {
        //        string result = client.DownloadString("http://localhost:12345/Alex");
        //        Console.WriteLine(result);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    using (var client = new WebClient())
        //    {
        //        var result = client.DownloadData("http://localhost:12345/Alex");
        //        Console.WriteLine(Encoding.UTF8.GetString(result));
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:12345/Alex");
        //    webRequest.Method = WebRequestMethods.Http.Get;
        //    using (StreamReader sr = new StreamReader(webRequest.GetResponse().GetResponseStream()))
        //    {
        //        string result = sr.ReadToEnd();
        //        Console.WriteLine(result);
        //    }


        //}

    }
}
