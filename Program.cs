// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 99);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void GetSumOddNumsPosition(int[] nums)
{
    int sum = 0;
    for (int i = 1; i < nums.Length; i+=2)
    {
        sum += nums[i];
    }
    System.Console.WriteLine(sum);
}

int userNum = ReadInt("Введите число");
int[] arr = GenerateArray(userNum);
ShowArray(arr);
System.Console.WriteLine();
GetSumOddNumsPosition(arr);