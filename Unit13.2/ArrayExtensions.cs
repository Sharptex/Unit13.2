using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit13._2
{
    public static class ArrayExtensions
    {
        public static void ShowTop(this string[] words, int max)
        {
            Console.WriteLine($"{max} слов наиболее часто встречающиеся в тексте: ");

            var freqeuncyDictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (freqeuncyDictionary.ContainsKey(word))
                {
                    freqeuncyDictionary[word]++;
                }
                else
                {
                    freqeuncyDictionary.Add(word, 1);
                }
            }

            int counter = 0;
            foreach (var item in freqeuncyDictionary.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value} раз");
                counter++;
                if (counter > max) break;
            }
        }
    }
}
