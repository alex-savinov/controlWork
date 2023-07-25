//Конвертируем введенную пользователем строку в массив слов
string[] ReadLineToArray(string value)
{
    try
    {
        Console.Write($"{value}: ");
        string[] array = Console.ReadLine()!.Split().ToArray();
        return array;
    }
    catch
    {
        string[] array = {""};
        return array;
    }
}
//Функция принимает массив слов и искомую длину слов (по дефолту 3). Отсеивает слова
string[] ConvertArrayForTask1(string[] userArray, int maxLength = 3)
{
    string[] newArray = new string[0];
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= maxLength)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = userArray[i];
        }
    }
    return newArray;
}
//Функция принимает массив слов и искомую длину слов (по дефолту 3). Отсеивает слова
string[] ConvertArrayForTask2(string[] userArray, int maxLength = 3)
{
     return userArray = userArray.Where(element => element.Length <= maxLength).ToArray();
}

void Main()
{
   /* string[] userArray = ReadLineToArray("Введите обрабатываемый массив через пробел");
    Console.WriteLine($"\r\nИсходный массив:\r\n[{string.Join("; ", userArray)}]");
    Console.WriteLine($"\r\nРезуальтат выполнения первой программы:\r\n[{string.Join("; ", ConvertArrayForTask1(userArray))}]");
    Console.WriteLine($"\r\nРезуальтат выполнения второй программы:\r\n[{string.Join("; ", ConvertArrayForTask2(userArray))}]");*/
    Console.WriteLine(Console.ReadLine()!.Split().Where(element => element.Length <= 3).ToArray());

}

Main();