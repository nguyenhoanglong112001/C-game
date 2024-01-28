using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    internal class Staff : Item
    {
        public Staff(string itemName) : base(itemName)
        {
        }

        public override void Function(Charater charater)
        {
            charater.spellDame = charater.spellDame + charater.spellDame*0.2f;
        }

        public override void Use(string itemname)
        {
            Console.WriteLine($"get {itemname}");
        }

        public override void Remove(Charater charater)
        {
            charater.spellDame = charater.spellDame - charater.spellDame * 0.2f;
        }
    }
}
