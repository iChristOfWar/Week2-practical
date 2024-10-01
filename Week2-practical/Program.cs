using System;

    PrintMenu();
    GetMessage();

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
        int option = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Ola!");
            return;
        case 3:
            Console.WriteLine("Gutentag!");
            return;
        case 4:
            Console.WriteLine("Caoi!");
            return;
        case 0:
            return;
        default:
            Console.WriteLine("Please select a vaild option!");
            return;
    }
}