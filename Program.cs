// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Вывести массив
void PrintArray (String array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.WriteLine("["+string.Join(", ",array)+"]");
    }
}
//Метод для добавления в массив элемент
//Не лучший вариант т.к. для таких задач лучше подходят связанные списки
string [] AddStrElementToArray(string[] array, string strToAdd)
{
    var result =new string[array.Length+1];
    array.CopyTo(result,0);
    result[array.Length]=strToAdd;
}
//Прочитать массив строк с клавиатуры построчно. 
//stopCombination - комбинация символов для остановки считывания
string [] ReadArrayFromConsole(string stopCombination="%%")
{
    Console.WriteLine("Введите массив строк построчно, для прекращения ввода используйте комбинацию: "+stopCombination);
    var result=new string[0];
    var line=Console.ReadLine();
    while (line!=stopCombination)
    {
        result=AddStrElementToArray(result,line);
        line=Console.ReadLine();
    }
}

var array=ReadArrayFromConsole();
PrintArray(array);