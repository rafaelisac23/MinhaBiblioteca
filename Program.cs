namespace MinhaBibliotexa;
class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void  ShowMenu()
    {
        SetConfig();
        ShowQuad();
        ShowOptions();
        Console.SetCursorPosition(10,10);
        Console.WriteLine("Option: ");
        Console.SetCursorPosition(17,10);
        try
        {
            int option = int.Parse(Console.ReadLine());
            if (option > 5)
            {
                ShowMenu();
            }
            SelectAction(option);
        }
        catch (FormatException e)
        {
            Console.Clear();
            Console.WriteLine("The Option is not valid option.");
            Thread.Sleep(2000);
            Console.Clear();
            ShowMenu();
        }
       
        
    }
    static void SetConfig()
    {
        Console.Clear();
        Console.BackgroundColor= ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void ShowQuad()
    {
        Console.Write("┌");
        for (int i = 0; i < 28; i++)
        {
            Console.Write("─");
        }     
        Console.Write("┐");
        Console.WriteLine();
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write("│");
            for (int j = 0; j < 28; j++)
            {
                Console.Write(" ");
            } 
            Console.WriteLine("│");
        }     
        Console.Write("└");
        for (int i = 0; i < 28; i++)
        {
            Console.Write("─");
        }     
        Console.Write("┘");
        
    }
    static void ShowOptions()
    {
        Console.SetCursorPosition(8,2);
        Console.WriteLine("1-Register book");
        Console.SetCursorPosition(8,3);
        Console.WriteLine("2-Register Person");
        Console.SetCursorPosition(8,4);
        Console.WriteLine("3-Borrow Book");
        Console.SetCursorPosition(8,5);
        Console.WriteLine("4-Return Book");
        Console.SetCursorPosition(8,6);
        Console.WriteLine("5-List Books");
        Console.SetCursorPosition(8,7);
        Console.WriteLine("0-Exit");
     
    }
    static void SelectAction(int option)
    {
        
    }
   
}
