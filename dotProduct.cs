using System.IO;
using System;

class dotProduct{
    static void Main(){
        Console.WriteLine("Enter first sequence:");
        string n = Console.ReadLine();
        string[] array1 = n.Split(' ');
        int[] s = Array.ConvertAll(array1, int.Parse);
        
        Console.WriteLine("Enter Second sequence:");
        string n1 = Console.ReadLine();
        string[] array2 = n1.Split(' ');
        int[] s1 = Array.ConvertAll(array2, int.Parse);
        double result = 0;

        for(int i = 0; i < s.Length; i++){

            result += s[i] * s1[i];
        }
        Console.WriteLine(result);
    }
}