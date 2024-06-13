// Задача
// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreatFirstStrArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int numOfElements = Convert.ToInt32(Console.ReadLine());


    string[] firstArr = new string[numOfElements];
    for (int i = 0; i < firstArr.Length; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
        firstArr[i] = Console.ReadLine();
    }
    return firstArr;
}


string[] CreatSecondStrArray(string[] arr)
{
    int numOfElements = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            numOfElements++;
        }
    }

    string[] secondArr = new string[numOfElements];

    int secondArrIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            secondArr[secondArrIndex] = arr[i];
            secondArrIndex++;
        }
    }
    return secondArr;
}


void PrintArray(string[] array)
{
    Console.Write("\n[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.Write("]");
}


string[] array = CreatFirstStrArray();
string[] result = CreatSecondStrArray(array);
PrintArray(result);