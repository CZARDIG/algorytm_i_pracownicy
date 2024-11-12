namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; 
            int b = 0;

            Console.WriteLine("Wpisz liczbe a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Wpisz liczbe b: ");
            int.TryParse(Console.ReadLine(), out b);

            if(a > 0 && b > 0)
            {
                while(a != b)
                {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else
                        {
                            b = b - a;
                        }
                    }
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Podałeś niepoprawną wartość");
            }
        }
    }
}
