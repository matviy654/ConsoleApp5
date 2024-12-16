class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number < 1 || number > 100)
            Console.WriteLine("Помилка");
        else if (number % 3 == 0 && number % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (number % 3 == 0)
            Console.WriteLine("Fizz");
        else if (number % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(number);
    }
}
class Program
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());
        Console.WriteLine(value * percent / 100);
    }
}
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        if (number.Length != 6)
        {
            Console.WriteLine("Error: is not a six-digit number.");
            return;
        }

        int pos1 = int.Parse(Console.ReadLine()) - 1;
        int pos2 = int.Parse(Console.ReadLine()) - 1;

        char[] numberArray = number.ToCharArray();
        char temp = numberArray[pos1];
        numberArray[pos1] = numberArray[pos2];
        numberArray[pos2] = temp;

        Console.WriteLine(new string(numberArray));
    }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100) { Console.WriteLine("Error"); return; }
        if (n % 3 == 0 && n % 5 == 0) Console.WriteLine("FizzBuzz");
        else if (n % 3 == 0) Console.WriteLine("Fizz");
        else if (n % 5 == 0) Console.WriteLine("Buzz");
        else Console.WriteLine(n);
    }
}
class Program
{
    static void Main()
    {
        int[,] B = new int[5, 5];
        Random rand = new Random();
        int minValue = int.MaxValue, maxValue = int.MinValue;
        int minPosX = -1, minPosY = -1, maxPosX = -1, maxPosY = -1, sum = 0;

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                B[i, j] = rand.Next(-100, 101);
                if (B[i, j] < minValue) { minValue = B[i, j]; minPosX = i; minPosY = j; }
                if (B[i, j] > maxValue) { maxValue = B[i, j]; maxPosX = i; maxPosY = j; }
            }

        int startX = Math.Min(minPosX, maxPosX), endX = Math.Max(minPosX, maxPosX);
        int startY = Math.Min(minPosY, maxPosY), endY = Math.Max(minPosY, maxPosY);

        for (int i = startX; i <= endX; i++)
            for (int j = startY; j <= endY; j++)
                sum += B[i, j];

        Console.WriteLine(sum);
    }
}
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int shift = 3;

        string encrypted = new string(input.Select(c => ShiftCharacter(c, shift)).ToArray());
        string decrypted = new string(encrypted.Select(c => ShiftCharacter(c, -shift)).ToArray());

        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
    }

    static char ShiftCharacter(char c, int shift)
    {
        if (char.IsLetter(c))
        {
            char offset = char.IsLower(c) ? 'a' : 'A';
            return (char)((((c - offset + shift) + 26) % 26) + offset);
        }
        return c;
    }
}
class Program
{
    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };
        int scalar = 2;

        PrintMatrix(MultiplyMatrixByScalar(A, scalar));
        PrintMatrix(AddMatrices(A, B));
        PrintMatrix(MultiplyMatrices(A, B));
    }

    static int[,] MultiplyMatrixByScalar(int[,] m, int s)
    {
        int r = m.GetLength(0), c = m.GetLength(1);
        int[,] res = new int[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++) res[i, j] = m[i, j] * s;
        return res;
    }

    static int[,] AddMatrices(int[,] A, int[,] B)
    {
        int r = A.GetLength(0), c = A.GetLength(1);
        int[,] res = new int[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++) res[i, j] = A[i, j] + B[i, j];
        return res;
    }

    static int[,] MultiplyMatrices(int[,] A, int[,] B)
    {
        int rA = A.GetLength(0), cA = A.GetLength(1), rB = B.GetLength(0), cB = B.GetLength(1);
        int[,] res = new int[rA, cB];
        for (int i = 0; i < rA; i++)
            for (int j = 0; j < cB; j++)
                for (int k = 0; k < cA; k++) res[i, j] += A[i, k] * B[k, j];
        return res;
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++) Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main() => Console.WriteLine(Calculate(Console.ReadLine()));

    static int Calculate(string expr)
    {
        var parts = expr.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        int result = int.Parse(parts[0]);

        for (int i = 1; i < parts.Length; i++)
            result += expr[i - 1] == '-' ? -int.Parse(parts[i]) : int.Parse(parts[i]);

        return result;
    }
}