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
        ArrayList list = new ArrayList();
        for(int i = 0; i < array.Length; i++){
            if(!list.Contains(array[i])) {
                list.Add(array[i]);
                Console.Write(array[i] + " ");
            }
        }
    }
}