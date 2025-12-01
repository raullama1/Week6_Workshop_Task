using System;

public class Program 
{
    // Add and Subtract Delegate 
    public delegate int Calculate(int a, int b);

    // Add and Subtract methods
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    // Discount Delegate 
    public delegate double DiscountStrategy(double price);

    // Discount methods (20%, 10%, no discount)
    public static double FestivalPrice(double price) => price - (price * 0.2);   // 20% off
    public static double SeasonalPrice(double price) => price - (price * 0.1);   // 10% off
    public static double NoDiscountPrice(double price) => price;                  // no discount

    // Task 2.1: Calculate Final Price 
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) 
        => strategy(originalPrice);

    public static void Main()
    {
        // Using Calculate delegate
        Calculate add = Add;
        Console.WriteLine("Add: " + add(5, 10));

        Calculate sub = Subtract;
        Console.WriteLine("Subtract: " + sub(10, 5));

        double originalPrice = 1000;

        //  Task 2: delegate calls
        DiscountStrategy festival = FestivalPrice;
        Console.WriteLine($"Festival Price: {festival(1000)}");

        DiscountStrategy seasonal = SeasonalPrice;
        Console.WriteLine($"Seasonal Price: {seasonal(1000)}");

        DiscountStrategy noDiscount = NoDiscountPrice;
        Console.WriteLine($"No Discount Price: {noDiscount(1000)}");

        // Task 2.1: Using CalculateFinalPrice method
        Console.WriteLine("\nTask 2.1 CalculateFinalPrice Method ");
        Console.WriteLine("Festival Final Price: " + CalculateFinalPrice(originalPrice, FestivalPrice));
        Console.WriteLine("Seasonal Final Price: " + CalculateFinalPrice(originalPrice, SeasonalPrice));
        Console.WriteLine("No Discount Final Price: " + CalculateFinalPrice(originalPrice, NoDiscountPrice));

        // 30% discount
        DiscountStrategy thirtyPercentDiscount = price => price - (price * 0.3);
        Console.WriteLine("30% Discount Final Price: " + CalculateFinalPrice(originalPrice, thirtyPercentDiscount));
    }
}
