using System;

namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Carson's Realty Open House!");
            Console.WriteLine();

            if (UI.UserAnswersYes("Interested in taikng a tour of this beautiful home?"))
            {
                Console.WriteLine("Let's start with the Day Room, yes!");
                Console.WriteLine("This room can be converted into a Livingroom, it is little over 355 sqaure feet.");
                Console.WriteLine("The Opulent Crystal chandeliar is an early, 1920s original.");
                Console.WriteLine();
                
                if (UI.UserAnswersYes("Would you like to see the Openfloor plan of the Diningroom and Kitchen?"))
                {
                    Console.WriteLine("Dinningroom has Wainwritght walls with cheery wood borders enough space tp set 12 comfortably.");
                    Console.WriteLine("Kitchen has stainless steel appliances an gourmet island with granite countertops and authentic Panamian tile shipped from Central America.");
                    Console.WriteLine();
                    Console.ReadLine();
                }
                
                if (UI.UserAnswersYes("Would you like to tour the next see the basement?"))
                {
                    Console.WriteLine("The basement is 1000 ft and runs the entire length of the house.");
                    Console.WriteLine("This would be an awesome space for a man cave/ Diva's Destination.");
                    Console.WriteLine();
                    Console.ReadLine();
                }
                
                if (UI.UserAnswersYes("Would you like to go upstairs?"))
                {
                    Console.WriteLine("There are 3 Bedrooms on this floor.");
                    Console.WriteLine("Extra large bedrooms and 1 with a spa master suite");
                    Console.WriteLine();
                    Console.ReadLine();
                }

                if (UI.UserAnswersYes("Would you like to see the extra room?"))
                {
                    Console.WriteLine("This room is large enough for an office or babyroom.");
                    Console.WriteLine();
                    Console.ReadLine();
                }

                if (UI.UserAnswersYes("Would you like to see the bathroom?"))
                {
                    Console.WriteLine("The bathroom on this floor is a full bath with a sauna and surround sound.");
                    Console.ReadLine();
                }

                if (UI.UserAnswersYes("Would you like to see the attic?\nThis is the last room."))
                {
                    Console.WriteLine("The attic is well vented, accesaible and a lot of storage space.");
                }

                if (UI.UserAnswersYes("Would you like to discuss the Comps?"))
                {
                    Console.WriteLine("Let's go to the office and talk.");
                }
                else
                {
                    Console.WriteLine("Thank you for selecting this home to view! Call if you have any more questions, here's my card.");
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
