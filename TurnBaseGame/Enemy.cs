using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    internal class Enemy : Charater
    {
        public int GrowOnLevel = 1;

        public Enemy()
        {
        }

        public Enemy(string heroName) : base(heroName)
        {
            health *= GrowOnLevel;
            attack *= GrowOnLevel;
            attackSpeed *= GrowOnLevel;
        }
    }
}
