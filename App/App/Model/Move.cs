using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Move : IMove
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BaseDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SpecialMove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DamageVersus(Pokemon user, Pokemon target)
        {
            throw new NotImplementedException();
        }
    }
}
