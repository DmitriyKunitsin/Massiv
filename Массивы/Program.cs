// See https://aka.ms/new-console-template for more information
Console.WriteLine("С какого числа начнем цикл");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Сколько циклов?");
int b = int.Parse(Console.ReadLine());
int[] NewArray = Enumerable.Range(n,b).ToArray();
for (int i = 0;i < n; i++)   
{
    Console.WriteLine(NewArray[i]);
    
}
    
//Console.WriteLine(NewArray);
Console.ReadLine();