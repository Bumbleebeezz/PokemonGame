namespace PokemonCommon
{
    public class StartScreenMenu
    {
        public static void  StartLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " ###    ##   #  #  ####  #   #   ##   #  #"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " #  #  #  #  # #   #     ## ##  #  #  ## #"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " ###   #  #  ##    ###   # # #  #  #  # ##"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " #     #  #  # #   #     #   #  #  #  #  #"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " #      ##   #  #  ####  #   #   ##   #  #")); 
            Console.ResetColor(); 
        }
    }
}
