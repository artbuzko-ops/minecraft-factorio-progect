using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Dictionary<ResourceType, double> RequiredResources { get; set; } = new Dictionary<ResourceType, double>();
        public Dictionary<ResourceType, double> ReceivedResources { get; set; } = new Dictionary<ResourceType, double>();

        public double RequiredElectricity { get; set; }
        public double GeneratedElectricity { get; set; }

        public int Duration { get; set; }
    }
}
