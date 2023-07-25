
string[] ReadLineToArray(string value)
{
    try
    {
        Console.WriteLine($"{value}: ");
        string[] array = Console.ReadLine()!.Split().ToArray();
        return array;
    }
    catch
    {
        string[] array = {""};
        return array;
    }
}

string[] ConvertArrayForTask(string[] userArray)
{
    string[] newArray = new string[0];
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = userArray[i];
        }
    }
    return newArray;
}


void Main()
{
    string[] userArray = ReadLineToArray("Введите обрабатываемый массив через пробел");
    Console.WriteLine($"\r\nИсходный массив:\r\n[{string.Join("; ", userArray)}]");
    Console.WriteLine($"\r\nРезуальтат выполнения программы:\r\n[{string.Join("; ", ConvertArrayForTask(userArray))}]");
}

Main();