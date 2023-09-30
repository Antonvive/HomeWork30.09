//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Print (string mg)
{
    Console.Write(mg);
    string readInput=Console.ReadLine();
    int result=int.Parse(readInput);
    return result;
}
int Sum(int N)
{
    int p=0;
    int s=0;
    while (N>0)
    {
        p=N%10;
        N=N/10;
        s=s+p;
        
    }
    return s;
}
int number=Print("Введите положительное число:");
Console.WriteLine($"Сумма цифр числа {number} равна: {Sum(number)}");


