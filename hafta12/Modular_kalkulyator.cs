using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
 public class Program
 {
  public static void Main(string[] args)
  {
   static void Statistika(params int[] sonlar)
{
    int yigindi = 0;
    foreach (int s in sonlar) yigindi += s;
    double ortacha = (double)yigindi / sonlar.Length;
    Console.WriteLine($"Yig'indi: {yigindi}, O'rtacha: {ortacha}");
}
 
static void Almashtir(ref int a, ref int b)
{
    int vaqtinchalik = a;
    a = b;
    b = vaqtinchalik;
}
 
static void MinMax(int[] massiv, out int min, out int max)
{
    min = massiv[0];
    max = massiv[0];
    foreach (int m in massiv)
    {
        if (m < min) min = m;
        if (m > max) max = m;
    }
}
  }
 }
}
