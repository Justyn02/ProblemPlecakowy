using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject")]
[assembly: InternalsVisibleTo("App"), InternalsVisibleTo("GUI")]

namespace ProblemPlecakowy
{
    internal class Problem
    {
        public int n;
        public int seed;

        public List<Item> przedmioty = new List<Item>();

        public Problem(int n, int seed)
        {
            Random random = new Random(seed);

            for (int i=0; i<n; i++)
            {
                Item Item = new Item(random.Next(1, 11), random.Next(1, 11), i);
                przedmioty.Add(Item);
            }
            przedmioty = przedmioty.OrderByDescending(p => (double)p.value / p.weight).ToList();

        }


        public Result Solve(int capacity)
        {
            
            Result result = new Result();

            foreach (var przedmiot in przedmioty)
            {
                if (przedmiot.value > 0)
                {
                    if (result.total_value + przedmiot.value <= capacity)
                    {
                        result.List_ID.Add(przedmiot.ID);
                        result.total_value += przedmiot.value;
                        result.total_weight += przedmiot.weight;
                    }
                }
                else
                {
                    result.total_value = 0;
                    result.total_weight = 0;
                    
                }
            }

            return result;
        }

        public void ForceItems(int v, int w, int x)
        {
            przedmioty[x].value = v;
            przedmioty[x].weight = w;
        }

        public override string ToString()
        {
            string str= "";
            foreach (var item in przedmioty)
            {
                str += "ID: " + item.ID + " Value:" + item.value + "  Weight:" + item.weight;
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
