using System;
namespace hypo
{
    class hypo 
    {
        static void Main(String[] args) 
        {
            Console.WriteLine("Enter the Base: ");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());
            double hypo = 0;
            hypo = Math.Sqrt(Math.Pow(Base , 2) + Math.Pow(Height, 2));

            Console.WriteLine(hypo);
        }
    }
}