using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Pokemon : IPokemon
    {
        public List<IMove> Moves => throw new NotImplementedException();

        public string Name { get => name; set
            {
                if (value.Length > 0 && value.Length <= 10)
                    name = value;
            }
        }
        private string name = "missingno";

        public int Health { get => MaxHealth - damage; }
        private int damage = 0;

        public Action<int> OnHealthChange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action OnKnockout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxHealth { set => maxHealth = value > 0 ? value : maxHealth; get => maxHealth; }
        private int maxHealth = 5;
        public int Attack { set => attack = value > 0 ? value : attack; get => attack; }
        private int attack = 5;
        public int Defence { set => defence = value > 0 ? value : defence; get => defence; }
        private int defence = 5;
        public int SpAttack { set => spAttack = value > 0 ? value : spAttack; get => spAttack; }
        private int spAttack = 5;
        public int SpDefence { set => spDefence = value > 0 ? value : spDefence; get => spDefence; }
        private int spDefence = 5;
        public int Speed { set => speed = value > 0 ? value : speed; get => speed; }
        private int speed = 5;

        public bool CanAct => throw new NotImplementedException();

        public bool KnockedOut => throw new NotImplementedException();

        public void Heal(int heal)
        {
            throw new NotImplementedException();
        }

        public void Hurt(int dmg)
        {
            throw new NotImplementedException();
        }

        public bool UseMove(IMove move, IPokemon target)
        {
            throw new NotImplementedException();
        }
    }
}
