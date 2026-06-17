using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public class IronMine : Production
    {
        public override void Produce(Warehouse warehouse, ref double availableElectricity)
        {
            if (ActiveRecipe == null) return;

            if (availableElectricity < ActiveRecipe.RequiredElectricity)
                return;

            progress++;

            if (progress >= ActiveRecipe.Duration)
            {
                availableElectricity -= ActiveRecipe.RequiredElectricity;
                warehouse.AddResources(ActiveRecipe.ReceivedResources);
                progress = 0;
            }
        }
    }
}
