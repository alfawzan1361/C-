using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class reDup{
    static void Main(){
        Console.WriteLine("Enter a sequence:");
        string n = Console.ReadLine();
        string[] array = n.Split(' ');
        for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " " + array[i] + " ");
        }
    }
}