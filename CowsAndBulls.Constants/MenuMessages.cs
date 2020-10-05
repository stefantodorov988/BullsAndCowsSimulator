namespace CowsAndBulls.Constants
{
    public class MenuMessages
    {
        public const string MAIN_MENU_MESSAGE = "1. Single player\r\n" +
                                        "2. Multiplayer\r\n" +
                                        "3. Exit";
        public const string MENU_SEPARATOR = "------------------------";

        public const string FIRST_PLAYER_INPUT_CONSTANT = "Player one should input his code : ";
        public const string FIRST_PLAYER_ATTEMPT_CONSTANT = "Player one should guess opponents code : ";
        public const string SECOND_PLAYER_INPUT_CONSTANT = "Player two should input his code : ";
        public const string SECOND_PLAYER_ATTEMPT_CONSTANT = "Player two should guess opponents code : ";

        public const string HUMAN_PLAYER_INPUT_CONSTANT = "Human player should input his code : ";
        public const string HUMAN_PLAYER_ATTEMPT_CONSTANT = "Human player should guess opponents code : ";

        public const string BOT_INPUT_CONSTANT = "Second player(bot) code was randomly generated. ";
        public const string BOT_ATTEMPT_CONSTANT = "Bot should guess opponents code : (fake 2 seconds thinking).";

        public const string COWS_COUNTER_MESSAGE = "Number of cows : ";
        public const string BULLS_COUNTER_MESSAGE = "Number of bulls : ";
        public const string ATTEMPT_COUNTER_MESSAGE = "Number of attempts : ";


        public const string FIRST_PLAYER_WON = "Player one has won the game!";
        public const string SECOND_PLAYER_WON = "Player two has won the game!";
        public const string BOT_WON = "Bot has won the game!";
    }
}
