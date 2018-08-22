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
            return Console.ReadLine().ToUpper() == "Y";
        }
    }
}
