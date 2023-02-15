//                 Задача: Написать программу, которая из имеющегося
//                 массива строк формирует новый массив из строк,
//                 длина которых меньше, либо равна 3 символам.
//                 Первоначальный массив можно ввести с клавиатуры,
//                  либо задать на старте выполнения алгоритма.
//                   При решении не рекомендуется пользоваться коллекциями,
//                   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// string[] array1 = new string[] {"Russia", "Denmark", "Kazan"};
// string[] array1 = new string[] {"1234", "1567", "-2", "computer science"};
string[] array1 = new string[] { "Hello", "2", "world", ":-)", "rtgnsk", "67y", " " };

int SecondArraySize(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateArray(int size)
{
    return new string[size];
}
void Final(string[] array, string[] result)
{
    int size = array.Length;
    int pos = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            result[pos] = array[i];
            pos++;
        }
    }
}

void Print(string[] Array)
{
    Console.WriteLine("[" + string.Join(",", Array) + "]");
}

int size = SecondArraySize(array1);
string[] result = CreateArray(size);
Final(array1, result);
Print(result);
