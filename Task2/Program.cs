Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (A > max)
{
    Console.WriteLine(max = A);
}
else
{
    if (B > max)
      {
        Console.WriteLine(max = B);
      }
      else 
      {
        if (C > max)
         {
          Console.WriteLine(max = C);
         }
         else 
         {
            Console.WriteLine(max);
           }
      }
}