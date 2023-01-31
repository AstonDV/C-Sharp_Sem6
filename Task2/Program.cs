// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


int Input(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

int Check(int numA, int numB, int numC)
{
    int sum = numA + numB + numC;
    if (numA < sum - numA && numB < sum - numB && numC < sum - numC) return 1;
    else return 0;
}

void main()
{
    Console.Clear();
    int a = Input("Введите сторону A");
    int b = Input("Введите сторону B");
    int c = Input("Введите сторону B");
    int checkResult = Check(a, b, c);
    if (checkResult == 1) Console.Write($"Треугольник со сторонами {a}, {b} и {c} может существовать");
    else Console.Write($"Треугольник со сторонами {a}, {b} и {c} не может существовать");
}

main();