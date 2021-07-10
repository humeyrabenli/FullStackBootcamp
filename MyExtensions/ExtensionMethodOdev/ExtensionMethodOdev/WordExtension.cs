using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodOdev
{
    public static class WordExtension
    {
        //kelime listesini parametre olarak alıyoruz
        public static string WordCounter(this string ebook, string[] wordList)
        {
            //kitapta bulunan , ve . 'yı replace metoduyla görmezden gelelim
            ebook = ebook.Replace(',', ' ').Replace('.', ' ').ToLower();


            //foreach ile kelime listesinde bulunan kelimelerin kitapta kaç defa geçtiği sayılıp ekrana yazdırılır.
            foreach (var wList in wordList)
            {

                int counter = 0;
                foreach (var word in ebook.Split())
                {
                    if (wList.ToLower() == word)
                    {
                        counter = counter + 1;
                    }
                }
                Console.WriteLine("{0} : {1}", wList, counter);

            }
            return string.Empty;
        }

    }
}
