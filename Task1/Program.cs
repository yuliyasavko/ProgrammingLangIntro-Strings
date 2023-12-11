char[,] CreateArray(int rows, int cols) {
    char[,] arr = new char [rows, cols];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i,j] = (char) random.Next('a', 'z' + 1);
        }
    }
    return arr;
}

void PrintArray(char[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0;  j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

string CreateStringFromArray(char[,] arr){
    string result = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0;  j < arr.GetLength(1); j++)
        {
            result += arr[i,j];
        }
    }
    return result;
}

char[,] arr = CreateArray(4,4);
PrintArray(arr);
string str = CreateStringFromArray(arr);
Console.WriteLine(str);
