using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public class Warehouse
    {
        public int Id { get; set; }

        private Dictionary<ResourceType, double> resources = new Dictionary<ResourceType, double>();

        public bool HasResources(Dictionary<ResourceType, double> needed)
        {
            foreach (var item in needed)
            {
                if (!resources.ContainsKey(item.Key) || resources[item.Key] < item.Value)
                    return false;
            }
            return true;
        }

        public void AddResources(Dictionary<ResourceType, double> added)
        {
            foreach (var item in added)
            {
                if (!resources.ContainsKey(item.Key))
                    resources[item.Key] = 0;

                resources[item.Key] += item.Value;
            }
        }

        public void RemoveResources(Dictionary<ResourceType, double> removed)
        {
            foreach (var item in removed)
            {
                resources[item.Key] -= item.Value;
            }
        }
    }
}
