
//Вывести массив
void PrintArray (String[] array)
{
    
        Console.WriteLine("["+string.Join(";",array)+"]");

}
//Метод для добавления в массив элемент
//Не лучший вариант т.к. для таких задач лучше подходят связанные списки
string [] AddStrElementToArray(string[] array, string strToAdd)
{
    var result =new string[array.Length+1];
    array.CopyTo(result,0);
    result[array.Length]=strToAdd;
    return result;
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
        if (line==null) line=string.Empty; //Спорный момент - в моем случае не бывает Null строк в массиве, но бывают пустые
        result=AddStrElementToArray(result,line);
        line=Console.ReadLine();
    }
    return result;
}
//Вернуть массив строк длина которых меньше или равна maxLength по умолчанию 3
string [] ShortStrings(string []array,int maxLength=3)
{
    int newLength=0;
    for (int i=0;i<array.Length;i++) //Узнаем размер нового массива
    {
        if (array[i].Length<=maxLength)
        {
            newLength++;
        }
    }
    string [] result=new string[newLength]; //Не будет ошибки если массив окажется пустой
    int newIndex=0;
    for (int i=0;i<array.Length;i++) //Создаем новый массив
    {
        if (array[i].Length<=maxLength)
        {
            result[newIndex]=array[i]; //копируем элемент массива
            newIndex++;ы
        }
    }
    return result;
}

string[] array=ReadArrayFromConsole(); //Считываем массив с клавиатуры
Console.WriteLine("Вы ввели массив строк: ");
PrintArray(array);
Console.WriteLine("Мы оставили все элементы длина которых меньше или равно 3 символам: ");
var newArray=ShortStrings(array); //Укорачиваем массив
PrintArray(newArray);