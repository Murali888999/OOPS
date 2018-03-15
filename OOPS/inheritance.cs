using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class brach
    {
        int bcode;
        String bname;
        String baddress;
        public void test1()
        {
            Console.WriteLine("enter branch details:");
            this. bcode = Convert.ToInt32(Console.ReadLine());
            this. bname = Console.ReadLine();
            this. baddress = Console.ReadLine(); 
        }
        public void test2()
        {
            Console.WriteLine("display branch details:");
            Console.WriteLine("bcode:" + this.bcode);
            Console.WriteLine("bname:" + this.bname);
            Console.WriteLine("baddress:" + this.baddress);
           
        }
    }
    class employee1 :brach
    {
        int eid;
        string ename;
             public void test3()
            {
            Console.WriteLine("enter employee details:");
            this. eid = Convert.ToInt32(Console.ReadLine());
            this. ename = Console.ReadLine();
            }
            public void test4()
            {
                Console.WriteLine("display employee details");
                Console.WriteLine("eid:" + this.eid);
                Console.WriteLine("ename:" + this.ename);
                
            }
        }
    class inheritance
    {
        static void Main(string[] args)
        {
            employee1 obj = new employee1();
            obj.test1();
            obj.test2();
            obj.test3();
            obj.test4();
            Console.ReadKey();
        }
    }
}
