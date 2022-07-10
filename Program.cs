// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int CalcSum (int numberM, int numberN)
{
int sum = 0;
{
    if (numberM > numberN) 
    {
        return 0;
    }
else
{
    sum = numberM+CalcSum(numberM+1,numberN);
    return sum;
}
}
}
int numberM = Prompt("Введите число M: ");
int numberN = Prompt("Введите число N: ");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма натуральных чисел между {numberM} и {numberN}:");
System.Console.WriteLine(CalcSum(numberM, numberN));