// Задача: написать программу, которая из имеющуегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Дано: [hello, 2, world, :-)]     Требуемый результат: [2, :-)]

string[] myArray = {"hello", "2", "world", ":-)"};
var newArray = new string[myArray.Length];
var newSize = 0;
foreach (var value in myArray)
{
    if (value.Length <= 3)
    {
        newArray[newSize] = value;
        newSize++;
    }
}

Console.WriteLine($"[{string.Join(", ", myArray)}] -> [{string.Join(", ", newArray, 0, newSize)}]");

