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
            Console.WriteLine("Tümü elektrik ile çalışır");
        }
        public abstract void Show();
    }

    public class Refrigerator : Furniture
    {
       
        public override void Show()
        {
            Console.WriteLine("Buzdolabı yiyecek ve içecekleri korur");
        }


    }

    public class WashingMachine : Furniture  
    {
        public override void Show()
        {
            Console.WriteLine("Çamaşır makinesi Kıyafetleri yıkar");
        }
        public void Renk()
        {
            Console.WriteLine("Rengi gridir.");
        }


    }

    public class Dishwasher : Furniture  
    {
        public override void Show()
        {
            Console.WriteLine("Bulaşık makinesi tabakları yıkar");
        }
    }

    public class TV : Furniture
    {
        public override void Show()
        {
            Console.WriteLine("Televizyonda film izleriz");
        }

        public void Control()
        {
            Console.WriteLine("TV kumanda ile KONTROL EDİLİR");
        }
    }

}
