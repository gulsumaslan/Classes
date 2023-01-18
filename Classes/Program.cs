using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture r = new Refrigerator();
            r.Run();
            r.Show();


            Console.WriteLine("++++++++++++++++++++++");


            WashingMachine w = new WashingMachine();
            w.Run();
            w.Show();
            w.Renk();

            Console.WriteLine("++++++++++++++++++++++");


            Dishwasher dishwasher = new Dishwasher();
            dishwasher.Run();
            dishwasher.Show();


            Console.WriteLine("++++++++++++++++++++++");

            TV tv = new TV();
            tv.Run();
            tv.Show();
            tv.Control();

        }
    }

    public abstract class Furniture // ABSTRACT CLASS, CLASS ÖRNEĞİ
    {
        public void Run()
        {
            Console.WriteLine("All powered by electricity");
        }
        public abstract void Show();
    }

    public class Refrigerator : Furniture
    {
       
        public override void Show()
        {
            Console.WriteLine("Refrigerator preserves food and drink");
        }


    }

    public class WashingMachine : Furniture  
    {
        public override void Show()
        {
            Console.WriteLine("Washing machine Washes clothes");
        }
        public void Renk()
        {
            Console.WriteLine("Color is gray.");
        }


    }

    public class Dishwasher : Furniture  
    {
        public override void Show()
        {
            Console.WriteLine("Dishwasher washes dishes");
        }
    }

    public class TV : Furniture
    {
        public override void Show()
        {
            Console.WriteLine("We watch movies on TV");
        }

        public void Control()
        {
            Console.WriteLine("CONTROLLED by TV remote");
        }
    }

}
