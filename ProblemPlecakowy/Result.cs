using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Result
    {
        public int total_value;
        public int total_weight;
        public List<int> List_ID;
        public Result() {
            total_value = 0;
            total_weight = 0;
            List_ID = new List<int>();
        }
        public Result(int value, int weight, List<int> Lista )
        {
            total_value = value;
            total_weight = weight;
            List_ID = Lista;
        }

        public override string ToString() {

            string str= "";
            str += "Items ID: ";

            foreach(var id in List_ID)
            {
                str += id.ToString() + " ";
            }

            str += Environment.NewLine;

            str += "Total Vaule:" + total_value;
            str += "   Total Weight:" + total_weight;

            return str;

        }



    }
}
