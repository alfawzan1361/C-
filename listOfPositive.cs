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
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] >= 0) {
                Console.Write(s[i]+" ");
            }
        }
    }
}