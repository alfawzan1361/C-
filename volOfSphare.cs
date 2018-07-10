using System;
namespace volOfSphare
{
    class hyvolOfSphare 
    {
        static void Main(String[] args) 
        {
            Console.WriteLine("Enter the raduis: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double sphare = (4.0/3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine(sphare);
        }
    }
}