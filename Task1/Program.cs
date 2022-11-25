Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int max = A;
if (A > max)
{
    max = A;
    Console.WriteLine("Max =" +max);
}
else
{
    if (B > max)
      {
        max = B;
        Console.WriteLine("Max = " +max);
      }
      else
      {
        Console.WriteLine("Max =" +max);
      }
}    
    
      