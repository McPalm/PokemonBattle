using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    class Move
    {
        public string Name { set; get; }
		public int BaseDamage { set; get; }
        public int DamageVersus(Pokemon user, Pokemon target) => throw new NotImplementedException();
		public bool SpecialMove { set; get; }
    }
}
