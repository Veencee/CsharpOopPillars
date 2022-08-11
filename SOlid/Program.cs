namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 21, 34, 16, 54, 43, 42, 31, 26, 73, 43 };
            int temp ;

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
                //Console.WriteLine(String.Join(" ", num));
                //Console.WriteLine(num);

            }
            Console.WriteLine("Array in Descending order: ");
            foreach (int i in num) 
            {
                Console.WriteLine(i);
            }
        }
    }
}