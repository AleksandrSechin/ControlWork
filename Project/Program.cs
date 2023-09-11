// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] > [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] > [“-2”]
// [“Russia”, “Denmark”, “Kazan”] > []

string[] oldArray = {"hi", "world", "goodbye", "day", "12345", "hello", "bye"};
string[] newArray = new string[oldArray.Length];

void CreateArray(string[] oldArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
    if(oldArray[i].Length < 4)
        {
        newArray[count] = oldArray[i];
        count++;
        }
    }
}

CreateArray(oldArray, newArray);
