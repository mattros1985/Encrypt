using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a key for encription");
            string key = Console.ReadLine();
            Fill cipher1 = new Fill();
            Fill cipher2 = new Fill();
            cipher1.fill();
            cipher2.fill();
            List<char> cipher = new List<char>();
            List<char> original = new List<char>();
            cipher = cipher1.alphabet;
            original = cipher2.alphabet;
            for(int i = 0; i < key.Length; i++)
            {
                cipher.Remove(key[i]);
            }
            for (int i = key.Length -1; i >= 0 ; i--)
            {
                cipher.Insert(0, key[i]);
            }
            Console.WriteLine("Enter sentence to be scrambled");
            StringBuilder sentenceBuilder = new StringBuilder();
            string sentence =  Console.ReadLine();
            sentenceBuilder.Append(sentence);
            int j = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                j = cipher2.position(sentence[i]);
                sentenceBuilder[i] = cipher[j];                          //Jacob: you can't do this with string!
            }
            Console.WriteLine(sentenceBuilder);
            Console.ReadLine();
        }
    }
}
