using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    struct Stuff
    {
        //Struct properties
        public int Intager { get; }
        public double Double { get; }
        public bool Bool { get; }

        // Constructor
        public Stuff(int _intager, double _double, bool _bool)
        {
            Intager = _intager;
            Double = _double;
            Bool = _bool;
        }
    }
}
