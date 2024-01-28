using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TurnBaseGame
{
    public enum ItemType
    {
        Bow,
        Sword,
        Staff,
        Amor
    }
    public class Item
    {
        public ItemType Type;
        public int value;

        public Item(int Value, ItemType type)
        {
            this.value = Value;
            this.Type = type;
        }

        public virtual void Use()
        {
        }


        public virtual void Remove(Charater charater)
        {

        }

        public void ShowIteminformation()
        {

        }
    }
}
