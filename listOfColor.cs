using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class listOfColor{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string n = Console.ReadLine();
        string[] array = n.Split(' ');
        for(int i = 0; i < array.Length; i++){
            if(array[i].Equals("black") || array[i].Equals("brown") 
            || array[i].Equals("blue") || array[i].Equals("red") 
            || array[i].Equals("yellow") || array[i].Equals("orange")
            || array[i].Equals("purple") || array[i].Equals("green")
            || array[i].Equals("gray") || array[i].Equals("pink")){
                Console.Write(array[i]+ " ");
            }
        }
    }
}