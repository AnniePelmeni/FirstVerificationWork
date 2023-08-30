string[] ChangeArray(string[] initialArray)
{
    int count = 0;
    for(int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length < 4) count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    int j = 0;
    while (k < newArray.Length)
    {
        if (initialArray[j].Length < 4) 
        {
            newArray[k] = initialArray[j];
            j++;
            k++;
        }
        else j++;
    }
    return newArray;    
}

string[] FillArray()
{
    string[] array = new string[4];
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine("Напишите слово: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] array = FillArray();
string str = string.Join(" ", array);
Console.Write($"[{str}] -> ");
string[] array2 = ChangeArray(array);
string str2 = string.Join(" ", array2);
Console.WriteLine($"[{str2}]");