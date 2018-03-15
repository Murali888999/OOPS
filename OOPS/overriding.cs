using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class employees
    {
        protected int eid;
        protected String ename;
        String eaddress;
        int eage;
        public virtual void getempdata()
        {
            Console.WriteLine("enter emp details:");
            this.eid = Convert.ToInt32(Console.ReadLine());
            this.ename = Console.ReadLine();
            this.eaddress = Console.ReadLine();
            this.eage = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void displayempdata()
        {
            Console.WriteLine("emp detaile are:");
            Console.WriteLine("eid:" + this.eid);
            Console.WriteLine("ename:" + this.ename);
            Console.WriteLine("eaddress:" + this.eaddress);
            Console.WriteLine("eage:" + eage);
        }
    }
    class manager : employees
    {
        double ca, bonus;
        public override void getempdata()
        {
            Console.WriteLine("enter manager details:");
            this.eid= Convert.ToInt32(Console.ReadLine());
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
    class overriding
    {
        static void Main(string[] args)
        {
            manager obj = new manager();
            obj.getempdata();
            obj.displayempdata();
            Console.Read();
        }
    }
}
