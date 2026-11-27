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
   Console.Write("Kino nomini kiriting: ");
string kino = Console.ReadLine();
 
Console.Write("Yoshingizni kiriting: ");
string yosh = Console.ReadLine();
 
Console.Write("O'rindiq raqamini kiriting: ");
string orindiq = Console.ReadLine();
 
Console.WriteLine("********");
Console.WriteLine("      KINOTEATR CHIPTASI");
Console.WriteLine("********");
Console.WriteLine($"Kino:      {kino}");
Console.WriteLine($"Yosh:      {yosh}");
Console.WriteLine($"O'rindiq:  {orindiq}");
Console.WriteLine("********");
  }
 }
}
