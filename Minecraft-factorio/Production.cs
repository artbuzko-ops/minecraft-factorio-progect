using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public abstract class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Recipe> RecipeList { get; set; } = new List<Recipe>();
        public Recipe ActiveRecipe { get; set; }

        public double Efficiency { get; set; } = 100.0;

        protected int progress = 0;

        public abstract void Produce(Warehouse warehouse, ref double availableElectricity);
    }
}
