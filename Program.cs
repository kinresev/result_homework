// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Enter a non-negative number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a non-negative number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return Akkerman(m - 1, 1);
    }
    else 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write($"The Akkerman function is equal to {Akkerman(m, n)} ");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
public static class Homework
{ 
    public static void print(int [] A, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(A[n] + " "); 
      	print(A, n - 1); 
      } 
      else Console.WriteLine(A[0]); 
    } 
    public static void Main()   
    { 
      int [] num = {5, 0, 1001, -3, 11, 159}; 
      print(num, num.Length - 1); 
    }  
  }   
