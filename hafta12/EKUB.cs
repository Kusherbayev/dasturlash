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
   static int EkubRekursiv(int a, int b)
{
    if (b == 0) return a;
    return EkubRekursiv(b, a % b);
}
 
static int EkubIterativ(int a, int b)
{
    while (b != 0)
    {
        int vaqtinchalik = b;
        b = a % b;
        a = vaqtinchalik;
    }
    return a;
}
 
Console.WriteLine(EkubRekursiv(48, 18));  // 6
Console.WriteLine(EkubIterativ(48, 18));  // 6
  }
 }
}
