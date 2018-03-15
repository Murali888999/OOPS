using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class branch
    {
        int bcode;
        String bname;
        String baddress;
        public void getbranchdata()
        {
            Console.WriteLine("enter branch details:");
            this.bcode = Convert.ToInt32(Console.ReadLine());
            this.bname = Console.ReadLine();
            this.baddress = Console.ReadLine();
        }
        public void displyabranchdata()
        {
            Console.WriteLine("display branch details:");
            Console.WriteLine("bcode:" + this.bcode);
            Console.WriteLine("bname:" + this.bname);
            Console.WriteLine("baddress:" + this.baddress);

        }
    }
    class employee2 : branch
    {
        int eid;
        string ename;
        public void getempdata()
        {
            Console.WriteLine("enter employee details:");
            this.eid = Convert.ToInt32(Console.ReadLine());
            this.ename = Console.ReadLine();
        }
        public void displayempdata()
        {
            Console.WriteLine("display employee details");
            Console.WriteLine("eid:" + this.eid);
            Console.WriteLine("ename:" + this.ename);

        }
    }
    class salary :employee2
    {
        Double basic, da, hra;
        public void getsal()
        {
            Console.WriteLine("enter sal details:");
            this.basic = Convert.ToDouble(Console.ReadLine());
        }
        public void calculate()
        {
            this.da = basic * 0.03;
            this.hra = basic * 0.3;
        }
        public void displaysal()
        {
            Console.WriteLine("display sal details:");
            Console.WriteLine("basic sal:" + this.basic);
            Console.WriteLine("da:" + this.da);
            Console.WriteLine("hra:" + this.hra);
        }
  }
    class multilevelinheritance
    {
        static void Main(string[] args)
        {
            salary obj = new salary();
            obj.getbranchdata();
            obj.displyabranchdata();
            obj.getempdata();
            obj.displayempdata();
            obj.getsal();
            obj.calculate();
            obj.displaysal();
            Console.Read();
        }
    }
}


