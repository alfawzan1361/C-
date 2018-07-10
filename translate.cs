using System.IO;
using System;

class Program
{
    static void Main()
    {
        string[] numbers = new string[] 
        { "", "One", "Two", "Three", "Four"};
        Console.Write("Enter a word: ");
        string array = Console.ReadLine();
        string[] words = array.Split(' ');
        for(int i=0;i<words.Length;i++) {
            int j = 0;
            for( j=0;j<numbers.Length;j++) {
                if(string.Equals(numbers[j], 
                words[i], StringComparison.OrdinalIgnoreCase)) {
                break;
                }
            }
            Console.WriteLine("{0} means {1}",words[i],j);
        }
    }
}