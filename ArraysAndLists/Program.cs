using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            
            var myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            
            var evens = new List<int>() { };
            var odds = new List<int>() { };
            
            foreach(var number in myArray)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                    Console.WriteLine($"{number} is even");
                   
                }
                else
                {
                    odds.Add(number);
                    Console.WriteLine($"{number} is odd");
                }
            }
            {
               
            }

            //for ( int i = 0; i <= myArray.Length; i++ )
            //{
            //    if (myArray[i] % 2 == 0) 
            //    {
            //        evens.Add(myArray[i]);
            //    }
            //    else
            //    {
            //        odds.Add(myArray[i]);
            //    }
                
             
            



            
        }
    }
}
