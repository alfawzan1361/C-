using System;

class stateOfWater 
{
    static void Main(String[] args) 
    {
        Console.WriteLine("Enter the temp: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if(temp <= 32){
            Console.WriteLine("The state of water is solid.");
        }else{
            if(temp >= 33 && temp <=211){
                Console.WriteLine("The state of water is liquid.");
            }else{
                Console.WriteLine("The state of water is gas.");
            }
        }
    }
}