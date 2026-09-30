class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        List<int> divisors = new();

        if (args != null && args.Length != 0)
        {
            input = int.Parse(args[0]);
        }
        else
        {
            Console.Write("정수 값을 입력하세요: ");
            input = int.Parse(Console.ReadLine());
            Console.Write("\n");
        }

        for (int i = 1; i < input + 1; i += 1)
        {
            if (input % i == 0)
            {
                divisors.Add(i);
            }
        }


        Console.Write($"{input}의 약수: ");
        foreach (int item in divisors)
        {
            Console.Write($"{item} ");
        }
        Console.Write("\n");
    }
}
