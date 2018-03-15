using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class employee5
    {
        int num1, num2, result;
        public int pnum1
        {
            set { num1 = value; }
        }
        public int pnum2
        {
            set { num2 = value; }       
        }
        public int presult
        {
            get { return result; }
        }
        public void add()
        {
            result = num1 + num2;
        }
        public void mul()
        {
            result = num1 * num2;
        }
    }
}
