#pragma warning disable 
Console.Clear(); 
Console.WriteLine("Задача:Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами");

Console.Write("Введите количество элементов массива: ");

int N = Convert.ToInt32(Console.ReadLine());
string[] Arr = new string[N];

Mas(Arr);
printArr(newArr(Arr));


void Mas(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        Arr[i] = Console.ReadLine()!;
    }
}

string[] newArr(string[] Arr)
{
    int n = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= 3)
            n++;
    }
    string[] arrayres = new string[n];
    int j = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= 3)
        {
            arrayres[j] = Arr[i];
            j++;
        }
    }
    return arrayres;
}
void printArr(string[] Arr)
{
    Console.WriteLine("Элементы массива удовлетворяющие требование задачи: ");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine(Arr[i] + " ");
    }
    Console.WriteLine();
}

