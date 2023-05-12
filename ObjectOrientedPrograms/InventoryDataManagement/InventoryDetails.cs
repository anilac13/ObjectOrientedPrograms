using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.InventoryDataManagement
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfWheat> typesOfWheat;
        public List<TypesOfPulses> typesOfPulses;
    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int pricePerKg;
    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int pricePerKg;
    }
    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int pricePerKg;
    }
}
