using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public interface IMove
    {
        string Name { set; get; }
        int BaseDamage { set; get; }
        int DamageVersus(Pokemon user, Pokemon target);
        bool SpecialMove { set; get; }
    }
}
