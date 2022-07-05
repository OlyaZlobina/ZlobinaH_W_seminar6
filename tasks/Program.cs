// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3


int[] FibanacciArray(int num)
{
    int[] array = new int[num]; 
    array[0] = 0; array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i - 2];
    }
    return array;
}
void PrintFibanacciArray(int [] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
}
Console.Clear();
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] myArray = FibanacciArray(N);
PrintFibanacciArray(myArray);


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

 int [] PositivNumbersArray(int num)
{
    int[] array = new int [num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PositivNumbersCount(int[] size)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] > 0)
        {
            count++;
        }
    }
    Console.Write($" -> {count}");
}

void PrintPositivNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Clear();
Console.Write("Input count of nambers: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] MyArray = PositivNumbersArray(M);
PrintPositivNumbers(MyArray);
PositivNumbersCount(MyArray);
Console.WriteLine();


