using ObjectOrientedPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class StockDetails
    {
        public List<Bajaj> bajaj;
        public List<Nestle> nestle;
        public List<Britannia> britannia;
    }
    public class Bajaj
    {
        public string stockName;
        public int numOfShares;
        public int sharePrice;
    }
    public class Nestle
    {
        public string stockName;
        public int numOfShares;
        public int sharePrice;
    }
    public class Britannia
    {
        public string stockName;
        public int numOfShares;
        public int sharePrice;
    }
}
