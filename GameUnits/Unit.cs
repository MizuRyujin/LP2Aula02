using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    public abstract class Unit
    {
        // Class properties
        public virtual int Health { get; protected set; }
        public abstract float Value { get; }

        public Unit()
        {

        }

        public virtual void Move()
        {

        }
    }
}
