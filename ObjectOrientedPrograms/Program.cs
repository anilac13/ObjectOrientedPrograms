using ObjectOrientedPrograms.InventoryDataManagement;
using ObjectOrientedPrograms.StockAccountManagement;
using System;
namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\BridgeLabs\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\StockAccountManagement\\Stock.json";
            StockAccountManagement.ReadTheData readTheData = new StockAccountManagement.ReadTheData();
            StockDetails data = readTheData.Read(filePath);
            //for (int i = 0; i < data.bajaj.Count; i++)
            //{
            //    Console.WriteLine(data.bajaj[i].stockName);
            //    Console.WriteLine(data.bajaj[i].numOfShares);
            //    Console.WriteLine(data.bajaj[i].sharePrice);
            //}
            Console.WriteLine("Stocks of Bajaj");
            Console.WriteLine("============================");
            foreach (var item in data.bajaj)
            {
                Console.WriteLine(item.stockName);
                Console.WriteLine(item.numOfShares);
                Console.WriteLine(item.sharePrice);
                Console.WriteLine("Stock value: " + item.numOfShares * item.sharePrice);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("\nStocks of Nestle");
            Console.WriteLine("============================");
            foreach (var item in data.nestle)
            {
                Console.WriteLine(item.stockName);
                Console.WriteLine(item.numOfShares);
                Console.WriteLine(item.sharePrice);
                Console.WriteLine("Stock value: " + item.numOfShares * item.sharePrice);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("\nStocks of Britannia");
            Console.WriteLine("============================");
            foreach (var item in data.britannia)
            {
                Console.WriteLine(item.stockName);
                Console.WriteLine(item.numOfShares);
                Console.WriteLine(item.sharePrice);
                Console.WriteLine("Stock value: " + item.numOfShares * item.sharePrice);
                Console.WriteLine("---------------------------");
            }
        }
    }
}