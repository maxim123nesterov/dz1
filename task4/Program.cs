Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

for (int B = 0; B <= A; B++)
{
 if (B % 2 == 0)
 {
    Console.WriteLine(B);
 }
}