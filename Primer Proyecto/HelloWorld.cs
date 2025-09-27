using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace CSharpHelloWorld {}

class HelloWorld
{
    static void Main(String[] args)
    {
        //hola mundo, yo soy un comentario
        Console.WriteLine("Hello, World!");
        /*
        Hola soy
        un 
        comentario 
        en varias
        lineas 
        */

        string myString = "Esto es una cadena de texto";
        myString = "Aqui cambio el valor de la cadena de texto";
        Console.WriteLine(myString);

        int myInt = 7;
        //ahora cambio el valor de la variable entera
        myInt = myInt + 4;
        Console.WriteLine(myInt);
        Console.WriteLine(myInt - 1);
        Console.WriteLine(myInt);

        double myDOuble = 6.5;
        Console.WriteLine(myDOuble);

        float myFloat = 6.5f;
        Console.WriteLine(myFloat);

        dynamic myDynamic = 6;
        myDynamic = "Mi dato dinamico es ahora texto";
        Console.WriteLine(myDynamic);


        Console.WriteLine(myInt + myDOuble + myFloat);

        bool myBool = true;
        myBool = false;
        Console.WriteLine(myBool);

        string myString2 = "mi nueva cadena de texto";
        Console.WriteLine(myString2);

        var myVar = "Mi variable de tipo inferido";
        //myVar = 7; //Esto  da error porque ya se infirio el tipo como string
        Console.WriteLine(myVar);

        Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

        const string MyConst = "Mi constante";
        Console.WriteLine(MyConst);

        //Estructuras 

        var myArray = new String[] { "Alex", "Mendez", "Adydx" };
        Console.WriteLine(myArray[0]);

        myArray[2] = "46";
        Console.WriteLine(myArray[2]);

        var myDictionary = new Dictionary<string, int>
        {
            {"Alex", 20},
            {"AuronPlay", 30},
            {"Patricio", 40}
        };

        Console.WriteLine(myDictionary["Alex"]);

        var mySet = new HashSet<string> { "Alex", "Mendez", "Adydx" };

        var myTuple = ("Alex", "Mendez", "Adydx");
        Console.WriteLine(myTuple);

        //Bucles

        for (int index = 0; index < 10; index++)
        {
            Console.WriteLine(index);
        }

        foreach (var myItem in mySet)
        {
            Console.WriteLine(myItem);
        }

        //Flujos

        myInt = 12;

        if (myInt == 11 && myBool == true)
        {
            Console.WriteLine("el valor es 11");
        }
        else if (myInt == 12 || myBool == false)
        {
            Console.WriteLine("el valor es 12");
        }
        else
        {
            Console.WriteLine("el valor no es 11");
        }

        //Funciones 

        myFunction();
        Console.WriteLine(MyFunctionWithReturn(4));

        //TODO: Clases
        var MyClass = new MyClass("alex");
        MyClass.myName = "pedrito";
        Console.WriteLine(MyClass.myName);

    }
    static void myFunction()
    {
        Console.WriteLine("Mi funcion");
    }

    static int MyFunctionWithReturn(int param)
    {
        return 10 + param;
    }

    class MyClass
    {
        public string myName { get; set; }
        public MyClass(string myName)
        {
            this.myName = myName;
        }
    }
}

