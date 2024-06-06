namespace QueteDunTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrB = new int[5] { 6, 7, 8, 9, 10 };
            int[] arrC = new int[10];

            for (int i = 0; i < arrC.Length; i++)
            {
                if(i < arrA.Length)
                    arrC[i] = arrA[i];
                else 
                    arrC[i] = arrB[i - arrA.Length];
            }

            Console.WriteLine("Tableau 1 :");
            for (int j = 0; j < arrA.Length; j++)
                Console.Write(arrA[j] + " ");
            Console.WriteLine("\n\nTableau 2 :");
            for (int j = 0; j < arrB.Length; j++)
                Console.Write(arrB[j] + " ");
            Console.WriteLine("\n\nTableau 3 :");
            for (int j = 0;j < arrC.Length; j++)
                Console.Write(arrC[j] + " ");
            Console.WriteLine();
            
        }
    }
}
