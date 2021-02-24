using AWebsite.DataReaders;
using System;

namespace AWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new DataReader();

            IDataRequest fileReq = new FileReader("SomeFile.txt");
            IDataRequest webReq = new WebReader("https://www.google.com/");

            Console.WriteLine(dataReader.ReadData(fileReq));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(dataReader.ReadData(webReq));
        }
    }
}
