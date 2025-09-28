
using System;


//LINQ

var names = new List<string>()
{
    "Hector", "Juan", "sofia", "Pedro", "ana"
};

var namesResult = from n in names
                    orderby n
                    select n;


foreach (var name in namesResult)
{
    Console.WriteLine(name);
}