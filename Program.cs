string filePath = "C:\\CodeForces\\Ozon 3.txt";
int [,]text2 = createMatrix(filePath);
sorted(queries(2));
displayMatrix(text2);


int [,] sorted(int [] iS)
{
    foreach (int i in iS)
    {
        int[] myArray = new int[text2.GetLength(0)];
        for (int m = 0; m < text2.GetLength(0); m++)
        {
            myArray[m] = text2[m, i];
        }
        Array.Sort(myArray);
        int counter = 0;
        foreach (int j in myArray)
        {
            text2[counter, i] = j;
            counter++;
        }
    }
    return text2;

}

int[] queries(int k)
{
    int[] iS = new int[k];
    for (int i = 0; i < iS.Length; i++)
    {
        Console.WriteLine("Введите номер стобца:");
        iS[i] = Convert.ToInt32(Console.ReadLine());
    }
    return iS;
}
void displayMatrix(int[,] text2)
{
    for (int i = 0; i < text2.GetLength(0); i++)
    {
        for (int j = 0; j < text2.GetLength(1); j++)
        {
            Console.Write(text2[i, j] + ",");
        }
        Console.WriteLine();
    }

}
int [,] createMatrix(string filePath)
{
    string[] text = File.ReadAllText(filePath).Trim().Split('\n');
    int[,] text2 = new int[4, 3];
    int number = 0;
    int i1 = 0;
    int j1 = 0;
    foreach (string i in text)
    {
        string[] columns = i.Split(',');
        foreach (string j in columns)
        {
            number = Convert.ToInt32(j);
            text2[i1, j1] = number;
            j1++;
        }
        i1++;
        j1 = 0;
    }
    return text2;

}
