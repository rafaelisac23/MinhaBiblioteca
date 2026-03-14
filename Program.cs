namespace MinhaBibliotexa;
class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void  ShowMenu()
    {
        Console.Clear();
        Console.BackgroundColor= ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        ShowQuad();
        
        
        Console.SetCursorPosition(4,10);
        Console.WriteLine("Option: ");
        Console.SetCursorPosition(11,10);
        int option = int.Parse(Console.ReadLine());
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

   
}
