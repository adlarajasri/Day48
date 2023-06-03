using System;



interface Food

{

    string GetType();

}

class Pizza : Food

{

    public string GetType()

    {

        return "Someone ordered a Fast Food!";

    }

}

class Cake : Food

{

    public string GetType()

    {

        return "Someone ordered a Dessert!";

    }

}

class FoodFactory

{

    public Food GetFood(string order)

    {

        if (order.Equals("pizza", StringComparison.OrdinalIgnoreCase))

        {
            Console.WriteLine("The Factory Returned Class Pizza");
            return new Pizza();

        }

        else if (order.Equals("cake", StringComparison.OrdinalIgnoreCase))

        {
            Console.WriteLine("The Factory Returned Class Cake");
            return new Cake();

        }

        else

        {

            return null;

        }

    }

}

public class MainClass

{

    public static void Main(string[] args)

    {

        Console.Write("Enter your order: ");

        string order = Console.ReadLine();

        FoodFactory foodFactory = new FoodFactory();

        Food food = foodFactory.GetFood(order);

        if (food != null)

        {

            Console.WriteLine(food.GetType());

        }

        else

        {

            Console.WriteLine("Invalid order. Please try again.");

        }

    }

}

