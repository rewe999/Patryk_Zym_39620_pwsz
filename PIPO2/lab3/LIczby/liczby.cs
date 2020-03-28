using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIczby
{
    public class liczby
    {
        protected int a, b, c;

        public liczby(int a,int b,int c) {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }

        public int C
        {
            get => c;
            set => c = value;
        }
    }
}