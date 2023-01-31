// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Input(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

double[] GetArray(int size)
{
    double[] res = new double[size];
    res[0] = 0;
    res[1] = 1;

    for (int i = 2; i < size; i++)
    {
        res[i] = res[i -1] + res[i - 2];
    }
    return res;
}

void PrintResult(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine(array[i]);
    }
    // Console.WriteLine($"{String.Join(", ", array)}");
}

void main()
{
    Console.Clear();
    int n = Input("Введите число");
    double[] array = GetArray(n);
    PrintResult(array);        
}

main();