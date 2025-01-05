class Program
{
    public static void Main(string[] args)
    {
        const double TaxRate = 6;
        const int SmallPrice = 25;
        const int LargePrice = 35;
        const int ValidTo = 30;
        double Cost = 0;
        int SmallNumber = 0;
        int LargeNumber = 0;
        double Total = 0;
        double Tax = 0;
        Console.WriteLine("Estimate for carpet cleaning service");
        Console.Write("Number of Small Carpets: ");
        SmallNumber = int.Parse(Console.ReadLine());
        Console.Write("Number of Large Carpets: ");
        LargeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Price per small room: ${SmallPrice} ");
        Console.WriteLine($"Price per large room: ${LargePrice} ");
        Cost = (SmallNumber * SmallPrice) + (LargeNumber * LargePrice);
        Console.WriteLine($"Cost: ${Cost}");
        Tax = Cost * (TaxRate / 100);
        Console.WriteLine($"Tax: ${Tax}");
        Total = Cost + Tax;
        Console.WriteLine("================================");
        Console.WriteLine($"Total estimate: ${Total}");
        Console.WriteLine($"This estimate is valide for {ValidTo} days");


    }
}