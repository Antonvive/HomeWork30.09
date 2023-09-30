// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int Print (string mg)
{
    Console.Write(mg);
    string readInput=Console.ReadLine();
    int result=int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random random=new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(min,max+1);
    }
    return array;
}
void PtintArray(int[] array)
{
    Console.Write ("[");
    for (int i = 0; i<array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int Length = Print("Длина массива:");
int mina = Print ("Начальное значение, для диапазона случайного числа:");
int maxa = Print ("Конечное значение, для диапазона случайного числа:");
int [] array = GenerateArray(Length, mina, maxa);
PtintArray (array);
