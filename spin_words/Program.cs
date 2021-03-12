using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace ConsoleApp5

{ 
    class Program 
    {
        public static string Order(string words) 
        { 
            Regex pattern = new Regex(@"\d{1}"); 
            var new_word = ""; 
            Dictionary<int, string> dict = new Dictionary<int, string>(); 
            if (words.Count() == 0) 
            { 
                return "";
            } 
            foreach (var i in words.Split(" ")) 
            {
                var number = pattern.Matches(i);
                dict.Add(Convert.ToInt32(number[0].Value), i);
            } 
            foreach (var i in Enumerable.Range(+1, dict.Count())) 
            { 
                new_word = new_word + " " + dict[i];
            } 
            return new_word.Trim(); 
        }
        public static string test(string words)
        {
            Regex pattern = new Regex(@"\d{1}");
            var number = pattern.Matches(words);
            return number.ToString();
        }
        static void Main(string[] args) 
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
            test("is2");
        } 

        
    } 
}