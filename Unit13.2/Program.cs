using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Text1.txt");
            var words = LoadData(textFile);

            words.ShowTop(10);

            Console.ReadKey();
        }

        public static string[] LoadData(string path)
        {
            var result = new List<string>();

            var text = File.ReadAllText(path);
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = new[] { ' ' };
            var words = noPunctuationText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}
