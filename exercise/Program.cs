
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


void Main()
{
    string[] userArray = ReadLineToArray("Введите обрабатываемый массив через пробел");
    string[] newArray = new string[0];
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length-1] = userArray[i];
        }
    }
    
   
    Console.WriteLine($"[{string.Join("; ", newArray)}]");
}

Main();