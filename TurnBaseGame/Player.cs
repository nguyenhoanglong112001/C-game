using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    public class Player : Charater
    {
        private int defend;
        public Player(string heroName) : base(heroName)
        {
            defend = GameHelper.GetRandom(10, 50);
        }

        public override void TakeDame(float dame)
        {
            dame -= defend;
            base.TakeDame(dame);
        }

        public override void CharacterInfomation()
        {
            base.CharacterInfomation();
            Console.WriteLine("Amor: " +  defend);
        }
    }
}
