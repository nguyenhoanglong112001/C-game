using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    internal class Sword : Item
    {
        public Sword(string itemName) : base(itemName)
        {

        }

        public override void Function(Charater charater)
        {
            charater.attack = charater.attack + charater.attack * 0.15f;
        } 

        public override void Use(string itemname)
        {
            Console.WriteLine($"Using {itemname}");
        }

        public override void Remove(Charater charater)
        {
            charater.attack = charater.attack - charater.attack * 0.15f;
        }
    }
}
