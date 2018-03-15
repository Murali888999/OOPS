using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
   abstract class employees2
    {
        protected int eid;
        protected String ename;
        String eaddress;
        int eage;
        public abstract void getempdata();
        public virtual void displayempdata()
        {
            Console.WriteLine("emp detailes are:");
            Console.WriteLine("eid:" + this.eid);
            Console.WriteLine("ename:" + this.ename);
            Console.WriteLine("eaddress:" + this.eaddress);
            Console.WriteLine("eage:" + eage);
        }
    }
    class manager1 : employees2
    {
        double ca, bonus;
        public override void getempdata()
        {
            Console.WriteLine("enter manager details:");
            this.eid = Convert.ToInt32(Console.ReadLine());
            this.ename = Console.ReadLine();
            this.ca = Convert.ToDouble(Console.ReadLine());
            this.bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override void displayempdata()
        {
            Console.WriteLine(" manager details are:");
            Console.WriteLine("manager id:" + this.eid);
            Console.WriteLine("manager name:" + this.ename);
            Console.WriteLine("ca:" + this.ca);
            Console.WriteLine("bonus:" + bonus);
        }
    }
    class abstract_1
    {
        static void Main(string[] args)
        {
            manager1 obj = new manager1();
            obj.getempdata();
            obj.displayempdata();
            Console.Read();
        }
    }
}
