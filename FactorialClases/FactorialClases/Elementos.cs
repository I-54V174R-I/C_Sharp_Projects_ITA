using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorialClases
{
    class Elementos
    {
        private int no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }
        private int res;

        public int Res
        {
            get { return res; }
            set { res = value; }
        }
        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public void factorial(int x) {
            int c = 1;
            String s = "";
            for (int i=x;i>=1 ;i--) {
                c = c + 1;
                s = s+" * "+i;
            }
        }
    }
}
