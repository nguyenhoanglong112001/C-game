using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    internal class Amor : Item
    {
        public Amor(string itemName) : base(itemName)
        {
        }

        public override void Function(Charater charater)
        {
            charater.health = charater.health + charater.health * 0.2f;
        }

        public override void Use(string itemname)
        {
            Console.WriteLine($"Wearing {itemname}");
        }

        public override void Remove(Charater charater)
        {
            charater.health = charater.health - charater.health * 0.2f;
        }
    }
}
