// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Например:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "competer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// метод ввода числа
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания и заполнения пользователем исходного массива
string[] GetArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

// метод для определения размера нового массива newArray
int SizeArray(string[] arr, int сharacters)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int length = arr[i].Length;
        if (length <= сharacters)
        {
            size++;
        }
    }
    return size;
}

// метод создания и заполнения нового массива из строк, длина которых меньше либо равна simbol.
string[] GetResultArray(string[] arr, int size, int сharacters)
{
    string[] newArray = new string[size];
    int indexNewArray = 0;
    for (int indexArray = 0; indexArray < arr.Length; indexArray++)
    {
        int length = arr[indexArray].Length;
        if (length <= сharacters)
        {
            newArray[indexNewArray] = arr[indexArray];
            indexNewArray++;
        }
    }
    return newArray;
}

// метод вывода массива в терминал
void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int sizeArray = ReadNumber("Введите размер создаваемого массива:");
string[] array = GetArray(sizeArray);
int simbol = ReadNumber("Введите максимальную длину строки для элементов нового массива:");
Console.WriteLine("Массив пользователя:");
PrintArray(array);
int sizeNewArray = SizeArray(array, simbol);
string[] newArray = GetResultArray(array, sizeNewArray, simbol);
Console.WriteLine("Полученный массив:");
PrintArray(newArray);
