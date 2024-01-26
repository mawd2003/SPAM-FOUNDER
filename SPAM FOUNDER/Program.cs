using System;

namespace project1
{
    public class SPAM
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public SPAM() { }

        public SPAM(string Text)
        {
            text = Text;
        }

        public int spamfounder()
        {
            int spam = 0;
            int uppercaseletter = 0;
            int reapeatletter = 0;
            int vowelletter = 0;
            int nonletter = 0;
            int isdigit = 0;


            for (int i = 0; i < text.Length; i++)
            {
                char character = char.Parse(text.Substring(i, 1));

                byte aski = Convert.ToByte(character);

                if (aski >= 65 && aski <= 90)
                {

                    uppercaseletter++;

                }

                if (i > 0 && character == Char.Parse(text.Substring(i - 1, 1)))
                {

                    reapeatletter++;

                }

                if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'u' || character == 'U' || character == 'o' || character == 'O')
                {

                    vowelletter++;

                }

                if (character == '|' || character == '/' || character == '-' || character == '@' || character == '!' || character == '$' || character == '=' || character == '?' || character == '+' || character == '*')
                {

                    nonletter++;

                }

                if (Char.IsDigit(character) == true)
                {

                    isdigit++;

                }

                if (character == ' ')
                {
                    if (uppercaseletter >= 2 || reapeatletter >= 3 || vowelletter == 0 || nonletter != 0 || isdigit != 0)
                    {
                        spam++;
                    }
                    uppercaseletter = 0;
                    reapeatletter = 0;
                    vowelletter = 0;
                    nonletter = 0;
                    isdigit = 0;

                }

            }

            return spam;



        }
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Enter text :");
                string txt = Console.ReadLine();
                SPAM sf = new SPAM(txt);
                Console.WriteLine(sf.spamfounder());
                Console.ReadKey();
            }
        }
    }
}
