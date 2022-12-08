 int[] Array(int[] mass)
{
    int index = 0;
    while (index < mass.Length)
    {
        mass[index] = new Random().Next();
        index++;
    }
    return mass;
}
int []ok = new int[8];
string text = string.Join(",", Array(ok)); 
Console.WriteLine(text);
