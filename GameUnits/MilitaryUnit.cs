using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    class MilitaryUnit : Unit
    {
        public float AttackPower { get; protected set; }
        public float XP { get; protected set; }
        public override float Value => AttackPower + XP;

        public MilitaryUnit() : base()
        {
            
        }
    }
}
