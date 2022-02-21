void PrintStrArray(string[] strArray)
{
    Console.Write("[");
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"\"{strArray[i]}\"");
        if (i != strArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");

}

int FindStringsWithSizeLessOrEqual3(string[] strArray)
{
    int numberOfStr = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            numberOfStr++;
        }
    }
    return numberOfStr;
}

string[] CreateNewArrayWithSizeLessOrEqual3(string[] strArray, int findSizeArray)
{
    string[] newStrArray = new string[findSizeArray];
    int j = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            newStrArray[j] = strArray[i];
            j++;
        }
    }
    return newStrArray;
}

string[] stringArray = { "hello", "2", "world", ":-)"};
PrintStrArray(stringArray);

int sizeNewArray = FindStringsWithSizeLessOrEqual3(stringArray);
string[] newStrArray = CreateNewArrayWithSizeLessOrEqual3(stringArray,sizeNewArray);
Console.Write(" => ");
PrintStrArray(newStrArray);

