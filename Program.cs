class Program
{
    static void Main(string[] args)
    {
        string input = String.Empty;
        int inputInt = 0;
        List<int> divisors = new();

        if (args != null && args.Length != 0)
        {
            input = args[0];
        }

        while (!int.TryParse(input, out inputInt))
        {
            Console.Write("정수 값을 입력하세요: ");
            input = Console.ReadLine();
            Console.Write("\n");
        }

        for (int i = 1; i < inputInt + 1; i += 1)
        {
            if (inputInt % i == 0)
            {
                divisors.Add(i);
            }
        }


        Console.Write($"{inputInt}의 약수: ");
        foreach (int item in divisors)
        {
            Console.Write($"{item} ");
        }
        Console.Write("\n");
    }
}
