using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public class Concern
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Production> ProductionList { get; set; } = new List<Production>();
        public Warehouse Warehouse { get; set; } = new Warehouse();

        public double AvailableElectricity { get; set; }

        public void Run(int ticks)
        {
            for (int i = 0; i < ticks; i++)
            {
                foreach (var production in ProductionList)
                {
                    production.Produce(Warehouse, ref AvailableElectricity);
                }
            }
        }
    }
}
