using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TurnBaseGame
{
    internal class Bow : Item
    {
        public Bow(string itemName) : base(itemName)
        {
        }

        public override void Function(Charater charater)
        {
            charater.attackSpeed = charater.attackSpeed + charater.attackSpeed*0.2f;
        }

        public override void Use(string itemname)
        {
            Console.WriteLine($"Using {itemname}");
        }

        public override void Remove(Charater charater)
        {
            charater.attackSpeed = charater.attackSpeed - charater.attackSpeed*0.2f;
        }
    }
}
