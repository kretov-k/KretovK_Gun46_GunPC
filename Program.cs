namespace KretovK_Gun42_GunPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(a + " ");
                int f = a + b;
                a = b;
                b = f;
            }
            Console.WriteLine();
            //even
            for (int i = 2; i <= 20; i += 2)
                Console.Write(i + " ");

            Console.WriteLine();
            //multiplication table
            for (int i = 1; i <= 5; i++)
            {
                for (int m = 1;  m <= 5; m++)
                {
                    Console.Write(i * m + "  ");
                }
                Console.WriteLine();
            }
            //password
            string password = "qwerty";
            string pstry;

            do
            {
                Console.Write("Password: ");
                pstry = Console.ReadLine();
                if (pstry != password)
                {
                    Console.WriteLine("Wrong password, try again.");
                }
            }
            while (pstry != password);
            Console.WriteLine("Password is correct!");
        }
    }
}
