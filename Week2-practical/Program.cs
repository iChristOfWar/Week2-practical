using System;
Main();

    static void Main()
    {
        while (true)
        {
            PrintMenu();
            GetMessage();
        }

        void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello In German?");
            Console.WriteLine("4. Hello in Italian?");
            Console.WriteLine("0. Exit the application.");
        }
        int GetOption()
        {
            int option = 0;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                option = GetOption();
            }
            return option;
        }

        void GetMessage()
        {

            int choice = GetOption();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Bonjour!");
                    return;
                case 2:
                    Console.WriteLine("Hola!");
                    return;
                case 3:
                    Console.WriteLine("Guten Tag!");
                    return;
                case 4:
                    Console.WriteLine("Ciao!");
                    return;
                case 0:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Please select a vaild option.");
                    return;
            }
        }
    }