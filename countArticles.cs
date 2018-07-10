using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class countArticles{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string n = Console.ReadLine();
        string[] array = n.Split(' ');
        int count = 0;
        for(int i = 0; i < array.Length; i++){
            if(array[i].Equals("a") || array[i].Equals("an") || 
            array[i].Equals("the")){
                count++;
            }
        }
        Console.WriteLine(count);
    }
}