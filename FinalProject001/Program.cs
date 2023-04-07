// Задача: написать программу, которая из имеющуегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Дано: ["hello", "2", "world", ":-)"]     Требуемый результат: ["2", ":-)"]

string[] array = {"hello", "2", "world", ":-)"};
var result = new string[array.Length];
var newSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[newSize] = value;
        newSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, newSize));

