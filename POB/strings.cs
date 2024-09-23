using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interpolacja ciągów znaków (łączenie imienia i nazwiska)
            string firstname = "Janusz";
            string lastname = "Nowak";
            string fullname = $"{firstname} {lastname}"; // poprawiona interpolacja ciągów
            Console.WriteLine(fullname); // Wyświetli: Janusz Nowak

            // Ciągi znaków dosłowne
            string path = "C:\\Users\\egzamin\\Desktop\\Programowanie_Obiektowe"; // dosłowne użycie backslash
            Console.WriteLine(path);
            
            // Użycie literału werbalnego (verbatim literal)
            path = @"C:\Users\egzamin\Desktop\Programowanie_Obiektowe"; 
            Console.WriteLine(path);

            // Ciąg wieloliniowy
            string multiline = "to jest wieloliniowy ciąg znaków";
            Console.WriteLine(multiline);

            // Metody manipulacji ciągami znaków
            string text = "Programowanie obiektowe";
            string newText = text.Replace("obiektowe", "strukturalne"); // poprawiono Replace
            Console.WriteLine(newText); // Wyświetli: Programowanie strukturalne

            newText = newText.Replace('e', 'E'); // zamiana 'e' na 'E'
            Console.WriteLine(newText); // Wyświetli: ProgramowaniE strukturalnE

            // Dzielenie zdania na słowa
            string sentence = "Franciszek to programista";
            string[] words = sentence.Split(' '); // dzielenie po spacji
            foreach (string word in words)
            {
                Console.WriteLine(word); // Wyświetli każde słowo osobno
            }

            // Kolejny przykład podziału
            string sentence1 = "Janusz Nowak mieszka w poznaniu";
            string[] words1 = sentence1.Split(' ');
            foreach (string word1 in words1)
            {
                Console.Write(word1 + ' '); // Wyświetli: Janusz Nowak mieszka w poznaniu
            }
            Console.WriteLine(); // Przełamanie linii po pętli

            // Dzielenie z użyciem konkretnego separatora
            string sentence2 = "Janusz;Nowak;to;programista";
            char[] separators = { ';' };
            string[] words2 = sentence2.Split(separators);
            foreach (string word2 in words2)
            {
                Console.WriteLine(word2); // Wyświetli słowa rozdzielone średnikiem
            }

            // Kolejny przykład z wieloma separatorami
            string sentence3 = "Janusz, Nowak; programista";
            char[] separators2 = { ';', ',' };
            string[] words3 = sentence3.Split(separators2, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word3 in words3)
            {
                Console.WriteLine(word3.Trim()); // Wyświetli słowa podzielone po ',' i ';' oraz usunie spacje
            }

            // Długość ciągu znaków i przycinanie
            string text2 = "Franciszek";
            Console.WriteLine(text2.Length); // Wyświetli: 10 (długość ciągu)
            text2 = text2.Trim();
            Console.WriteLine(text2.Length); // Wyświetli 10 (brak spacji do przycięcia)

            // Przykład przycinania (Trim)
            string text3 = " Janusz  ";
            string trimmedStart = text3.TrimStart(); // usuwa spacje z początku
            string trimmedEnd = text3.TrimEnd(); // usuwa spacje z końca
            Console.WriteLine(text3); // Wyświetli: " Janusz  "
            Console.WriteLine(trimmedStart); // Wyświetli: "Janusz  "
            Console.WriteLine(trimmedEnd); // Wyświetli: " Janusz"
            
            string trimmed = text3.Trim(); // usuwa spacje z obu stron
            Console.WriteLine(trimmed.Length); // Wyświetli: 6 (długość ciągu "Janusz")
        }
    }
}
