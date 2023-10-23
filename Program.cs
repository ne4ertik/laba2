
Console.WriteLine("Введите три числа");
double A=Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());
if ((A < C) | (B < C) | (A < B)){
   A=2*A; 
   B=2*B;
   C=2*C;
    Console.WriteLine($"Удвоенные числа равны {A}{B}{C}") ;
}
 else
{
    Console.WriteLine("Ошибка");
}