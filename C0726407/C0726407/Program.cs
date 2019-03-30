using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("download complete");
        }


        class Network
        {
           static ArrayList WebPagesContents = new ArrayList();
            public static async Task Download();{
            HttpClient client = new HttpClient();
            string data = await client.GetStringAssync("http://torontopubliclibrary");
            Console.WriteLine(data);
                foreach (var i in data)
                {
                WebPageContents.Add(i);
        }
    }
}


