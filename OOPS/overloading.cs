using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class A
    {
        public int add(int i, int j)
        {
            return i + j;
        }
        public float add(float i, int j)
        {
            return i + j;
        }
        public float add(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class overloading
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine("sum is:" + obj.add(12, 45));
            Console.WriteLine("sum is:" + obj.add(12, 45,23));
            Console.WriteLine("sum is:" + obj.add(12.5f, 45));
            Console.ReadLine();
        }
    }
}
