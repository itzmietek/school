using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.tasks
namespace _2_string
{
  internal  class Program 
  {
    static void Main(string[] args)
    {
        string Firstname = "Janusz";
        string lastname= "Nowak";
        string fullname $"{firstname} {lastname}";
      Console.WriteLine(fullname); //janusz nowak
      //lieteały dosłowne 
      string path = "C:\\Users\\egzamin\\Desktop\\Programowanie_Obiektowe"; //C:\\Users\\egzamin\\Desktop\\Programowanie_Obiektowe
      Console.WriteLine(path);
      path = @"C:\Users\egzamin\Desktop\Programowanie_Obiektowe";
            Console.WriteLine(path);
        string multiline = "to jest wieloliniowy ciag znaków";
            Console.WriteLine(multiline);
      //metody manipulacji ciągami
        string text = "Programowanie obiektowe";
        string newText = text.Replace ("obiektowe , " "strukturalne");
            Console.WriteLine(newText);
            newText = newText.Replace('e' , 'E');
            Console.WriteLine(newText)
        Console.ReadKey();
      

    }
  }
}
