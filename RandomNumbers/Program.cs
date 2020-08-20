using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
  
            // Create a list of Random numbers
            var intList = new List<int>();
            for (int i = 0; i < 20; i++)
                intList.Add(random.Next(1, 50));

            // Square numbers inside list of Random numbers and add to new list
            var squaredIntList = intList.Select(i => i * i).ToList();
            prettyPrint(squaredIntList, "Squared Numbers");

            // Remove from list odd numbers
            squaredIntList = squaredIntList.Where(i => i % 2 == 0).ToList();
            prettyPrint(squaredIntList,"Even Numbers");

            // One-Line Solution
            // var result = intList.Select(i => i * i).Where(i => i % 2 == 0).ToList();
        }

        static void prettyPrint(List<int> list, String premessage)
        {
            Console.WriteLine($"\n{premessage}");
            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}

/*

for (int i = 0; i < 20; i++)
{
    intList.Add(random.Next(1, 50));
}

foreach (var num in intList)
{
    squaredIntList.Add(num * num);
}

for (int i = 0; i < squaredIntList.Count; i++)
{
    if (squaredIntList[i] % 2 == 1)
    {
        squaredIntList.RemoveAt(i);
        i -= 1;
    }
}

foreach (var item in squaredIntList)
{
    Console.WriteLine(item);
}
*/
// Populate the list