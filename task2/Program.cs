/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

// int [] Convert(string message)

System.Console.WriteLine("Введите коэффициенты");
string stroka = Console.ReadLine();
string [] str = stroka.Split(", ");
double b1 = double.Parse(str[0]);
double k1 = double.Parse(str[1]);
double b2 = double.Parse(str[2]);
double k2 = double.Parse(str[3]);
if(k1-k2==0)
{
    System.Console.WriteLine("Прямые не пересекутся");
}
else {
double x0 = Math.Round((b2-b1)/(k1-k2),2);
double y0 = Math.Round(k1*x0+b1,2);
System.Console.WriteLine($"Точка пересечения {x0}; {y0}"); }