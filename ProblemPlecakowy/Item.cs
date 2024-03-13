using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Item
    {
        public int value;
        public int weight;
        public int ID;

        public Item(int value, int weight, int iD)        {
            this.value = value;
            this.weight = weight;
            ID = iD;
        }
    }
}
