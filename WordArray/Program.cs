// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которого меньше либо ровна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгаритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 
string[] array ={"first","two","second","one","five","ten"}; 
var WordArray= new string[array.Length];
var findeWord = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        WordArray[findeWord] = value;
        findeWord++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, WordArray, 0, findeWord));
