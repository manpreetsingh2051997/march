using System;
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
            static public Task Download()
            {
                return Task.Run(() = ThreadStaticAttribute.Sleep(66000));
            }
        }
    }
}

