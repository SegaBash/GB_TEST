string? inString = string.Empty;
Console.WriteLine("Введите слова через запятую");
inString = Console.ReadLine();
while (inString == string.Empty)
{
    Console.WriteLine("Поле не должно быть пустым");
    inString = Console.ReadLine();
}
string stringToArray = inString is null ? string.Empty: inString.Replace(" ","");
string[] stringArray = stringToArray.Split(',', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(string.Join(", ",GetShortArray(stringArray,3)));


string[] GetShortArray(string[] arr, int letterCount)
{
string[] shortArray = new string[arr.Length];
int k = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= letterCount)
    {
        shortArray[k] = arr[i];
        k++;
    }
}
Array.Resize(ref shortArray, k);
return shortArray;
}