using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse
{
    class UI
    {
        public static bool UserAnswersYes(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine().ToUpper();

            string[] affirmativeOptions = { "Y", "YES", "YEP", "YUP", "YEAH", "SURE", "YES, PLEASE", "ABSOLUTELY" };
            foreach (string option in affirmativeOptions)
            {
                if (response == option) return true;
            }

            return false;
        }
    }
}
