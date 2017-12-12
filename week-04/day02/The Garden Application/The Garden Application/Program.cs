using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden gd = new Garden();
            Flower fl1 = new Flower("Red");
            Flower fl2 = new Flower("Blue");
            Flower fl3 = new Flower("Pink");
            Flower fl4 = new Flower("Yellow");
            Tree t1 = new Tree("Yellow");
            Tree t2 = new Tree("Brown");
            Tree t3 = new Tree("Black");
            Tree t4 = new Tree("Purple");

            gd.AddTree(t1);
            gd.AddTree(t2);
            gd.AddTree(t3);
            gd.AddTree(t4);
            gd.AddFlower(fl1);
            gd.AddFlower(fl2);
            gd.AddFlower(fl3);
            gd.AddFlower(fl4);

            gd.Watering();
            gd.getStatus();
            gd.Watering();
            gd.getStatus();
            
            Console.ReadLine();
        }
    }
}
