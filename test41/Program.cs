// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System.Transactions;

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < Array.MaxLength; i++)
    {
        array[i] = Prompt($"введите {i + 1} элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}


int CountPosNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }   
    return count;
}

int length = Prompt("введите количество элементов");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"количество чисел боьше нуля равно {CountPosNum(array)}");