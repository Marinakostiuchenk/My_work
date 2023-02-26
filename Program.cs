// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        string element = Convert.ToString(Console.ReadLine());
        int length = element.Length;
        if (length > 0 && length < 4)
        {
            arr[i] = element;
        }
    }
    return arr;
}

string PrintArray(string[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == "[") str += arr[i];
        else str += $", {arr[i]}";
    }
    str += "]";
    return str;
}

string[] array = CreateArray(size);
Console.WriteLine(array);
Console.WriteLine(PrintArray(array));
