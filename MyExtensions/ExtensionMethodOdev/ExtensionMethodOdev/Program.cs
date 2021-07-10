using System;
using System.IO;

namespace ExtensionMethodOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //kelime listesinin olduğu bir txt dosyasını okuyalım
            string words = System.IO.File.ReadAllText(@"C:\Users\humeyra\Desktop\wordlist.txt");

            //kelime listesinde bulunan her bir kelimeyi ayırarak bir diziye atalım
            string[] wordList = words.Split();


            //txt formatında bir e-kitap seçip bu dosyayı da okuyalım
            string ebook = System.IO.File.ReadAllText(@"C:\Users\humeyra\Desktop\insanneileyasar.txt");

            //kelime listesinde bulunan kelimelerin bu kitapta kaç defa geçtiğini sayan WordCounter isimli Extension metodu kullanalım
            ebook.WordCounter(wordList);
        }

    }
}
