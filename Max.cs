using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program{
    static void Main(){
        Console.WriteLine("Enter a sequence:");
        string n = Console.ReadLine();
        string[] array = n.Split(' ');
        int[] s = Array.ConvertAll(array, int.Parse); 
        int result = 0;
        for(int i = 0; i < s.Length; i++){
            result = s.Max();
        }
        Console.WriteLine("The maximum number is: " + result);
    }
}