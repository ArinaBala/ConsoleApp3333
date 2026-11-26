namespace ConsoleApp3
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string text = @" diana@gmail.com, diana.di@yahoo.com, maria_123@outlook.com, test-diana@company.ua, admin123diana@mail.co.uk. , dianagmail.com, dida@, @gmail.com, dianka@gmail, dian@gmail.c ";

            string pattern = @"\b[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }
        }
    }
}
