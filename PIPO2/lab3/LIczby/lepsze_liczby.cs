using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIczby
{
    public class Lepsze_liczby : liczby
    {
        protected int d;

        public Lepsze_liczby(int a, int b, int c, int d) : base(a, b, c)
        {
            this.d = 0;
        }

        public int D
        {
            get => d;
            set => d = value;
        }
    }
}