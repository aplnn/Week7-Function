using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            //programm küsib kasutajal sisestada numbrid 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnimi esimene täht;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkus.

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number 1, 2 või 3:");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    GetUserNameData(userName);
                    break;
                case '2':
                    GetUserNameLetter(userName);
                    break;
                case '3':
                    GetUserNameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Ups...");
                    break;
            }

        }

        public static void GetUserNameData(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void GetUserNameLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void GetUserNameLenght(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

    }
}
