using Newtonsoft.Json;
using ObjectOrientedPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class ReadTheData
    {
        public StockDetails Read(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockDetails>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
