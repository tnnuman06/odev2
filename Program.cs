namespace ödev_oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to sort?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number:");
            int end = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                bool unique;
                do
                {
                    number = rnd.Next(start, end);
                    unique = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[j] == number)
                        {
                            unique = false;
                            break;
                        }
                    }
                } while (!unique);
                numbers[i] = number;
            }
            Array.Sort(numbers);
            Console.WriteLine("Print sequential numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
