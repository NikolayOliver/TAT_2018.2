using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class TranslationLetter
    {
        static void Main(string[] args)
        {
            char[] symbols;
            Dictionary<char, string> translationDictionary = new Dictionary<char, string>()
            {
                // Russian -> English
               {'А',"A"}, {'Б',"B"}, {'В',"V"},
               {'Г',"G"}, {'Д',"D"}, {'Е',"E"},
               {'Ё',"YO"}, {'Ж',"ZH"}, {'З',"Z"},
               {'И',"I"}, {'Й',"Y"}, {'К',"K"},
               {'Л',"L"}, {'М',"M"}, {'Н',"N"},
               {'О',"O"}, {'П',"P"}, {'Р',"R"},
               {'С',"S"}, {'Т',"T"}, {'У',"U"},
               {'Ф',"F"}, {'Х',"KH"}, {'Ц',"TS"},
               {'Ч',"CH"}, {'Ш',"SH"}, {'Щ',"SCH"},
               {'Ъ',"#"}, {'Ы',"Y"}, {'Ь',"#"},
               {'Э',"E"}, {'Ю',"YU"}, {'Я',"YA"},
                // English -> Russian
               {'A',"А"}, {'B',"Б"}, {'C',"Ц"},
               {'D',"Д"}, {'E',"Е"}, {'F',"Ф"},
               {'G',"ДЖ"}, {'H',"Х"}, {'I',"АЙ"},
               {'J',"Ж"}, {'K',"К"}, {'L',"Л"},
               {'M',"М"}, {'N',"Н"}, {'O',"О"},
               {'P',"П"}, {'Q',"КЬЮ"}, {'R',"Р"},
               {'S',"С"}, {'T',"Т"}, {'U',"Ю"},
               {'V',"В"}, {'W',"ВИ"}, {'X',"ИСК"},
               {'Y',"И"}, {'Z',"З"}
            };
            CheckingAndTranslateSymbols checkAndTranslate = new CheckingAndTranslateSymbols();
            Console.WriteLine("Input string consisting of letters");
            string newArg;
            while(true)
            {
                if(args.Length == 0)
                {
                    Console.WriteLine("You must to input string");
                }
                if(args.Length > 1)
                {
                    Console.WriteLine("Input only letter! \nTry again");
                }
                if(args.Length == 1)
                {
                    if(checkAndTranslate.CheckingSymbols(args) == true)
                    break;
                }
                newArg = Console.ReadLine();
                args = newArg.Split(' ');
            }
            
            StringBuilder translateString =  new StringBuilder(); 
            string str;

            foreach (string arg in args)
            {
                symbols = arg.ToCharArray();
                for (int i = 0; i < symbols.Length; i++)
                {
                    translateString.Append(checkAndTranslate.Translate(symbols[i], translationDictionary));
                }
            }
            str = translateString.ToString();
            Console.WriteLine(str);

            //string str = "sjdfs";
            //str = str.ToUpper();
            //str = str.Replace('D', 'д');
            //char ch = 'd';
            //if(Char.IsLetter('Б')==true)
            //{
            //    Console.WriteLine("yes");
            //}
           
            //Console.WriteLine(str.ElementAt(2));
            Console.ReadKey();
        }

    }
}
