using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            // int[] numArray1 = {0,1,2,3,4,5,6,7,8,9};
            // string[] stringArray = {"Tim", "Martin", "Nikki", "Sara"};
            // bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
            
            // for (int i = 0; i < numArray1.Length; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int i = 0; i < stringArray.Length; i++)
            // {
            //     Console.WriteLine(stringArray[i]);
            // }

            // for (int i = 0; i < boolArray.Length; i++)
            // {
            //     Console.WriteLine(boolArray[i]);
            // }

            //Multiplication Table
            int[,] arr = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(arr[i,j] = (i + 1) * (j + 1));

                }
            }   
            
            //List of flavors
            // List<string> flavors = new List<string>();
            // flavors.Add("Chocolate");
            // flavors.Add("Vanilla");
            // flavors.Add("Straberry");
            // flavors.Add("Rocky Road");
            // flavors.Add("Pistachio");
            //Console.WriteLine("We currently have {0} ice cream flavors.", flavors.Count);
            //Console.WriteLine(flavors[2]);
            //flavors.RemoveAt(2);
            //Console.WriteLine("We currently have {0} ice cream flavors.", flavors.Count);

            /// User Info Dictonary
            // Dictionary<string, string> userInfo = new Dictionary<string,string>();
            // Random rand = new Random();
            // foreach(string name in stringArray)
            // {
            //     userInfo[name] = flavors[rand.Next(flavors.Count)];
            // }
            // Console.WriteLine("Users and their favor ice cream flavors:");
            // foreach(KeyValuePair<string, string> info in userInfo)
            // {
            //     Console.WriteLine(info.Key + " - " + info.Value);
            // }

            
        }
    } 
}
