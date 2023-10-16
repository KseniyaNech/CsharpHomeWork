


System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
   System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}
