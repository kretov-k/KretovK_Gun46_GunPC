namespace KretovK_Gun42_GunPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the first number");
            if (!Int32.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine("First number is incorrect");
                return;
            }

            Console.WriteLine("Enter the second number");
            if (!Int32.TryParse(Console.ReadLine(), out var b))
            {
                Console.WriteLine("Second number is incorrect");
                return;
            }
            Console.WriteLine("Enter a bitwise operator (&, | or ^): ");
            var c = Console.ReadLine();
            if (c.Length == 0 || c.Length > 1)
            {
                Console.WriteLine("Not a bitwise operator");
                return;
            }
            int z = 0;
            switch (c[0])
            {
                case '&':
                    z = a & b;
                    break;
                case '|':
                    z = a | b;
                    break;
                case '^':
                    z = a ^ b;
                    break;
                default:
                    Console.WriteLine("Not a bitwise operator");
                    return;
            }
            Console.WriteLine("Binary result: " + Convert.ToString(z, 2));
            Console.WriteLine("Decimal result: " + z);
            Console.WriteLine("Hex result: " + Convert.ToString(z, 16));
        }
    }
}
