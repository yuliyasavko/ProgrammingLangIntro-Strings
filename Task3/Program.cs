bool IsPalindrom(string str){
    string temp = str.ToLower();
    return temp.SequenceEqual(temp.Reverse());
}

string str = Console.ReadLine();
if (IsPalindrom(str))
{
   Console.WriteLine($"{str} - палиндром");
}
else
{
    Console.WriteLine($"{str} - не палиндром");
}