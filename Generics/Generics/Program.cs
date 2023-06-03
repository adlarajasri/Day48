using System;



public class MainClass

{

    public static void PrintArray<T>(T[] array)

    {

        foreach (T element in array)

        {

            Console.WriteLine(element);

        }

    }

    public static void Main(string[] args)

    {

        int[] intArray = { 1, 2, 3, 4, 5 };

        string[] stringArray = { "Hello", "World", "C#", "Generics" };

        PrintArray(intArray);

        PrintArray(stringArray);

    }

}
