namespace Binary7
{
    
    //Сгенерировать все числа, меньшие N, в двоичной записи которых есть M единиц. 
    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("N:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Incorrect data");
                return;
            }
            Console.WriteLine("M:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Incorrect data");
                return;
            }
            Console.WriteLine($"[{string.Join(", ", BinaryGenerator(a, b))}]");
        }
        public static List<int> BinaryGenerator(int n, int m)
        {
            if (n <= 0 || m < 0)
            {
                return new List<int>();
            }

            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int current = i;
                while (current > 0)
                {
                    count += current % 2;
                    current /= 2;
                }

                if (count == m)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}