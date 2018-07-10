using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var list = new List<KeyValuePair<string, int>>();
        list.Add(new KeyValuePair<string, int>("Aziz", 25));
        list.Add(new KeyValuePair<string, int>("jack", 23));
        list.Add(new KeyValuePair<string, int>("sara", 55));
        list.Add(new KeyValuePair<string, int>("john", 60));
        
        int array = list[0].Value;
        int youngest = 0;
        int i = 0;
        foreach (KeyValuePair<string, int> S in list) {
            if(array > S.Value) {
                array = S.Value;
                youngest = i;
            }
            i++;
        }
        Console.WriteLine("The youngest person is "+list[youngest].Key);
    }
}