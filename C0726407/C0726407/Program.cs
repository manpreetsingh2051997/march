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
    
        static void Download()
    {
        Thread.Sleep(66000);
            Console.WriteLine("Download complete");
    }
}
}
