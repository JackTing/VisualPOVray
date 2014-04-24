﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    public class Difference:PovObj
    {
         public PovObj o1, o2;
        public Difference(PovObj o1, PovObj o2)
        {
            this.o1 = o1;
            this.o2 = o2;   
        }

        public List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("difference {");
            l.AddRange(this.o1.render());
            l.AddRange(this.o2.render());
            l.Add("}");
            return l;
        }
    }
}