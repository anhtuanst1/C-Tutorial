using System;
using System.Collections.Generic;

namespace C_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //======================== Structure Basic ========================

            /* chuong trinh in dong chu Hello World trong C# */
            Console.WriteLine("Hello World!");

            Console.WriteLine("Chuong trinh minh hoa tinh huong doi tuong trong C#");
            Console.WriteLine("--------------------------------------------------\n");
            //tao doi tuong Rectangle
            Rectangle r = new Rectangle();
            //goi cac phuong thuc cua doi tuong nay
            r.Acceptdetails();
            r.Display();

            //======================== Structure Basic ========================

            /* Kieu du lieu */
            object obj;
            obj = 100;

            dynamic dem = 20;

            String str = "Hi, I am Tuan";

            Console.WriteLine("\n Kieu object: " + obj + "\n Kieu dynamic: " + dem + "\n Kieu string: " + str + "\n");

            /* Ep kieu */
            int x = 75;
            float y = 53.005f;
            double z = 2345.7652;
            bool check = true;
            //su dung phuong thuc ToString()
            Console.WriteLine(x + "\t\t to string \t" + x.ToString());
            Console.WriteLine(y + "\t\t to string \t" + y.ToString());
            Console.WriteLine(z + "\t to int \t" + (int)z);
            Console.WriteLine(check + "\t\t to string \t" + check.ToString());

            //khai bao bien
            Console.WriteLine("\nKhai bao va khoi tao bien trong C#");
            short a;
            int b;
            double c;
            int d = 3, e = 5;

            /* khoi tao bien */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("d = {0}, e = {1}", d, e);

            /* Nhap gia tri */
            String giatri;
            Console.Write("\n Input gia tri: ");
            giatri = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n Gia tri la: {0}", giatri);

            //Hang
            Console.WriteLine("Hang so trong C#");
            Console.WriteLine("-------------------");

            //khai bao hang so pi
            const double pi = 3.14159;

            double bk;
            Console.Write("Nhap ban kinh: ");
            bk = Convert.ToDouble(Console.ReadLine());
            double dien_tich = pi * bk * bk;
            Console.WriteLine("\nBan kinh: {0}, Dien tich: {1}", bk, dien_tich);


            //List<string>
            List<string> list = new List<string>();
            list.Add("abc");
            list.Add("123");
            //IEnumerable<object> en = list;


            //Ke thua
            ClassA classa = new ClassA();
            ClassB classb = new ClassB();
            ClassC classc = new ClassC();
            ClassD classd = new ClassD();

            classa.Height = 20 > 10 ? (classa.Height - 10) : (classc.methodA(8, 10));
            classb.Height = 10;
            classb.methodA();

            Console.WriteLine("Width = {0}", classc.Width);
            Console.WriteLine("MethodA = {0}", classc.methodA());
            Console.WriteLine("MethodA Dien tich = {0}", classc.methodA(5, 10));

            //Mang
            Console.WriteLine("\n ======== IN gia tri trong mang C1 ");
            int[] marks = new int[] { 99, 98, 92, 97, 95 };
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Gia tri phan tu {0} = {1}", i, marks[i]);
            }

            Console.WriteLine("\n ======== IN gia tri trong mang C2 ");
            foreach(int mark in marks)
            {
                Console.WriteLine("\t Gia tri phan tu la : {0}", mark);
            }

            Console.WriteLine("\n ======== IN gia tri trong mang Key - Value ");
            IDictionary<string, string> openWith = new Dictionary<string, string>()
                                                        {
                                                            { "txt", "notepad.exe" },
                                                            { "bmp", "paint.exe" },
                                                            { "rtf", "wordpad.exe" }
                                                        };
            foreach (KeyValuePair<string, string> de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            //Find MIN - MAX
            Console.Write("\n ======== Find MIN - MAX | num_array = ");

            int[] num_array = new int[] { -8, -98, 12, 97, 55, 22 };
            foreach (int num in num_array)
            {
                Console.Write("{0} \t", num);
            }

            FindMinMax MinMax = new FindMinMax();

            Console.WriteLine("\n Min = {0}", MinMax.FindMin(num_array));
            Console.WriteLine(" Max = {0}", MinMax.FindMax(num_array));












            //=================================================================
            //=================================================================

            Console.ReadLine();
            /* ngan can chuong trinh run, close 1 cach nhanh chong cho den khi push 1 char */
            //Console.ReadKey();

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }

    public class ClassA
    {
        readonly int str1 = 123;
        public int Height { get; set; } = 10;
        public int Width { get; } = 5;
        private int GiaTri_1 { get; set; } = 5;
        protected int GiaTri_2 { get; set; } = 5;

        public int methodA()
        {
            return Height;
        }

        public int methodA(int Height)
        {
            return Height;
        }

        public int methodA(int Height, int Width)
        {
            return Height * Width;
        }

        public enum TimeOfDay
        {
            mon = 2,
            tue = 3,
            web = 4
        }
    }

    public class ClassB : ClassA
    {

    }

    public class ClassC : ClassB
    {

    }

    public class ClassD : ClassA
    {

    }
}
