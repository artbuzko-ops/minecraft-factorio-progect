using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_factorio
{
    public abstract class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ResourceType Type { get; set; }
    }
    public enum ResourceType
    {
        Coal,
        IronOre,
        Iron,
        Copper,
        Lead,
        Oil,
        Fuel,
        Plastic,
        Kettle
    }
}
