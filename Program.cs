namespace KretovK_Gun42_GunPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5, 8, 13 };

            string[] monthsoftheyear =
            {
                "January", "February", "March", "April",
                "Mary", "June", "July", "August",
                "September", "October", "November", "December"
            };

            int[,] matrix =
            {
                { 2, 3, 4 },
                { 4, 9, 16 },
                { 8, 27, 64 },
            };

            double[][] jagged = new double[3][];

            jagged[0] =  new double[] {1, 2, 3, 4, 5};
            jagged[1] = new double[] { Math.E, Math.PI };
            jagged[2] = new double[] {
                Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)
            };

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8 , 9, 10, 11, 12, 13 };

            Array.Copy(array, array2, 3);

            Array.Resize(ref array, array.Length * 2);
        }
    }
}
