


namespace sauna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = Run();
            while (temperature < 73 || temperature > 77)
                temperature = Run();
        }
        static double Run()

        {
            Console.Write("Enter temperature ");
            double far = Int32.Parse(Console.ReadLine());
            double cel = (far - 32) * 5 / 9;

            {
                if (cel < 73)
                {
                    Console.WriteLine("tempreture is too low");
                }
                else if (cel > 77)
                {
                    Console.WriteLine("tempreture is too high");
                }
                else
                {
                    Console.WriteLine("acceptable temperature");
                }
                return cel;
            }
        }
    }
}   
 