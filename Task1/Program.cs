namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num_Small_Carpets, Num_Large_Carpets,sale_dayes;
            sale_dayes = 30;
            double Large_Carpets_Price = 35;
            double Small_Carpets_Price = 25;
            double T_cost,total,S_taxi;
            Console.WriteLine("Enter The Number of small carpets:");
            Num_Small_Carpets=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter The Number of large carpets:");
            Num_Large_Carpets= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"The Number of Small Carpets:{Num_Small_Carpets}");
            Console.WriteLine($"The Number of Large Carpets:{Num_Large_Carpets}");
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            total=(Num_Small_Carpets*Small_Carpets_Price)+(Num_Large_Carpets*Large_Carpets_Price);
            S_taxi = (total * 6 / 100);
            T_cost = ((Num_Small_Carpets * Small_Carpets_Price) + (Num_Large_Carpets * Large_Carpets_Price))+S_taxi;
            Console.WriteLine($"Cost:${total}");
            Console.WriteLine($"Tax:${S_taxi}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate:${T_cost}");
            Console.WriteLine($"This estimate is valid for {sale_dayes} days");

        }
    }
}
