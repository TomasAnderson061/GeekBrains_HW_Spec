/*Задача: 
Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
["hello", "2", "world",-> ["2"],
["1234", "1567", "-2", "computer science"] -> ["-2"] 
["Russia", "Denmark", "Kazan"] -> []
*/

string[] CreateArray(int size)
{
    string[] array = new string[size];

    string str;
    for (int i = 0; i < size; i++)
    {
    l1: Console.WriteLine($"Введите {i + 1}-й элемент: ");
        str = Console.ReadLine();
        if (str == "")
        {
            Console.WriteLine($"Элемент не может быть пустым: ");
            goto l1;
        }
        array[i] = str;
    }
    return array;
}
int CountBelow3(string[] array)
{
    int newlength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newlength++;
    }
    return newlength;
}

string[] CreateArray4Below3(string[] array, int newlength)
{
    string[] newarray = new string[newlength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine("]");
}

Console.WriteLine("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(N);

Console.Write($"Массив из строк, длина которых меньше или равна 3: ");

ShowArray(CreateArray4Below3(array, CountBelow3(array)));
