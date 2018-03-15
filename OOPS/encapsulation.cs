using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class employee
    {
        int id;
        String name;
        int age;
        public void get()
        {
            Console.WriteLine("enter emp details");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("print emp details");
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
        }
    }
    class encapsulation
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            obj.get();
            obj.display();
            Console.Read();
        }
    }
}


