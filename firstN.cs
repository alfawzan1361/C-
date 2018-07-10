using System;
namespace volOfSphare
{
    class hyvolOfSphare 
    {
        static void Main(String[] args) 
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++){
                Console.WriteLine(i*i);
            }
        }
    }
}