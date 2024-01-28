using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TurnBaseGame
{
    public class Charater
    {
        public string name;
        public float health;
        public float attack;
        public float attackSpeed;
        public float crit;
        public float spellDame;
        public Item itemeUse;
        public float luck;

        public float HealthPoint
        {
            get { return health; }
            set { health = value; }
        }

        public float AttackDamage
        {
            get
            {
                return attack;
            }
            set { attack = value; }
        }

        public float AttackSpeed
        {
            get
            {
                return attackSpeed;
            }
            set
            {
                attackSpeed = value;    
            }
        }
        public Charater() 
        {
        }

        public Charater(string heroName)
        {
            this.name = heroName;
            health = GameHelper.GetRandom(1000, 5001);
            attack = GameHelper.GetRandom(100, 301);
            attackSpeed = GameHelper.GetRandom(10, 101);
            crit = GameHelper.GetRandom(1,101);
            spellDame = GameHelper.GetRandom(1, 100);
        }

        public bool Alive => health > 0;

        public virtual void TakeDame(float damage)
        {
            if (!Alive)
            {
                return;
            }
            health -= damage;
        }

        public void CritAttack(Charater opponent)
        {
            if (!Alive)
            {
                return;
            }
            opponent.TakeDame(attack * 2f);
        }

        public float Attack(Charater opponent)
        {
            opponent.health = opponent.health - this.attack;
            return opponent.health;
        }

        public virtual void CharacterInfomation()
        {
            Console.WriteLine("Hero Information: ");
            Console.WriteLine("Hero Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Attack Damage: " + attack);
            Console.WriteLine("Speed: " + attackSpeed);
            Console.WriteLine("Crit: " + crit);
        }
    }
}
