//43
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


//41
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");