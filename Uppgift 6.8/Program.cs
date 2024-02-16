using System;
namespace uppgift6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Skriv ett heltal: ");
                int heltal = int.Parse(Console.ReadLine());
                AntalPrimtal(heltal);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static bool ÄrPrimtal(int heltal)
        {
            for (int i = 2; i < heltal; i++)
            {
                if (heltal % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void AntalPrimtal(int a)
        {
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                else if (ÄrPrimtal(i))
                {
                    count++;
                }
            }
            Console.WriteLine("Det finns "+count+" antal primtal mindre än "+a);
        }
    }
}