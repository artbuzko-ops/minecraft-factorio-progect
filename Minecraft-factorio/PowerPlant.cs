using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public class PowerPlant : Production
    {
        public override void Produce(Warehouse warehouse, ref double availableElectricity)
        {
            if (!warehouse.HasResources(ActiveRecipe.RequiredResources))
                return;

            progress++;

            if (progress >= ActiveRecipe.Duration)
            {
                warehouse.RemoveResources(ActiveRecipe.RequiredResources);
                availableElectricity += ActiveRecipe.GeneratedElectricity;
                progress = 0;
            }
        }
    }
}
