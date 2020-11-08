using System;

namespace ClassBoxData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, widht, height);
                Console.WriteLine(box);//Console.WriteLine вика ToString() имплицитно
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
