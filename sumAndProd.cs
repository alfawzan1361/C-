using System.IO;
using System;

class sumAndProd{
    static void Main(){
        Console.WriteLine("Enter a sequence:");
        string n = Console.ReadLine();
        string[] array = n.Split(' ');
        int[] s = Array.ConvertAll(array, int.Parse); 
        int sum = 0;
        int prod = 1; 
        for(int i = 0; i < s.Length; i++){
         sum += s[i];
         prod *= s[i];
        }
    Console.WriteLine("The sum is: " + sum);
    Console.WriteLine("The product is: " + prod);
    }
}