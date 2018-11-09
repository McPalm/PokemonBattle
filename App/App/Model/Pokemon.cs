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

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Health => throw new NotImplementedException();

        public Action<int> OnHealthChange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action OnKnockout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxHealth { set; get; } = 5;
        public int Attack { set; get; } = 5;
        public int Defence { set; get; } = 5;
        public int SpAttack { set; get; } = 5;
        public int SpDefence { set; get; } = 5;
        public int Speed { set; get; } = 5;

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
