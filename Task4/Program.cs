string ReverseWords(string str){
    string[] arr = str.Split(" ");
    int n = arr.GetLength(0);

    string[] result = new string [n];
    for (int i = 0; i < n; i++)
    {
        result[n-i-1] = arr[i];
    }

    return string.Join(" ", result);
}
string str = Console.ReadLine();
string strnew= ReverseWords(str);
Console.WriteLine(strnew);