namespace CowsAndBulls.Models.GameOptionsStrategyModels
{
    using CowsAndBulls.CompareService.Interface;
    using CowsAndBulls.Constants;
    using CowsAndBulls.Digits.Service.Interface;
    using CowsAndBulls.IO.Service.Interface;
    using CowsAndBulls.Models.DataStructures;
    using Interface;
    using System;

    public class SinglePlayerGameOption : IGameOption
    {
        private readonly ICodeCompareService codeCompareService;
        private readonly IDigitsService digitsService;
        private readonly IWriter writer;
        private readonly IReader reader;
        private string playerCode;
        private string botCode;
        private bool isPlayersTurn = true;
        private string lastResultOfBotGuess = string.Empty;
        private TreeNode currentNodeOfBotOptions;
        private IBCTreeFactory bCTreeFactory;
        public SinglePlayerGameOption(IWriter writer, IReader reader, ICodeCompareService codeCompareService, IDigitsService digitsService)
        {
            this.writer = writer;
            this.reader = reader;
            this.codeCompareService = codeCompareService;
            this.digitsService = digitsService;
        }
        public void Run()
        {
            InitializePlayers();
            StartMatch();
        }
        public bool IsApplicable(string input)
        {
            return input == UserInputConstants.SINGLE_PLAYER;
        }

        private void StartMatch()
        {
            while (true)
            {
                writer.ChangeOutputColor(isPlayersTurn ? ConsoleColor.DarkGray : ConsoleColor.Blue);
                writer.PrintOnNewLine(isPlayersTurn ? MenuMessages.HUMAN_PLAYER_ATTEMPT_CONSTANT : MenuMessages.BOT_ATTEMPT_CONSTANT);

                if (isPlayersTurn)
                {
                    var playersGuess = reader.ReadNewLine();
                    var compareResult = codeCompareService.CompareCode(botCode, playersGuess);

                    writer.PrintOnNewLine(MenuMessages.COWS_COUNTER_MESSAGE + compareResult.CowsNumber);
                    writer.PrintOnNewLine(MenuMessages.BULLS_COUNTER_MESSAGE + compareResult.BullsNumber);
                    writer.PrintOnNewLine(MenuMessages.MENU_SEPARATOR);

                    if (compareResult.BullsNumber == GameLimitConstants.MAX_CHARACTERS_NUMBER)
                    {
                        writer.PrintOnNewLine(MenuMessages.FIRST_PLAYER_WON);
                        return;
                    }
                }
                else
                {
                    string botGuess = string.Empty;
                    if (lastResultOfBotGuess == string.Empty)
                        botGuess = GameLimitConstants.BOT_FIRST_ATTEMPT;
                    else
                        botGuess = FindBotNextGuess();

                    var compareResult = codeCompareService.CompareCode(playerCode, botGuess);

                    writer.PrintOnNewLine(MenuMessages.COWS_COUNTER_MESSAGE + compareResult.CowsNumber);
                    writer.PrintOnNewLine(MenuMessages.BULLS_COUNTER_MESSAGE + compareResult.BullsNumber);
                    writer.PrintOnNewLine(MenuMessages.MENU_SEPARATOR);

                    if (compareResult.BullsNumber == GameLimitConstants.MAX_CHARACTERS_NUMBER)
                    {
                        writer.PrintOnNewLine(MenuMessages.BOT_WON);
                        return;
                    }
                }


                isPlayersTurn = !isPlayersTurn;
            }
        }

        private string FindBotNextGuess()
        {
            return "";
        }

        private void InitializePlayers()
        {
            writer.ClearInterface();
            writer.PrintOnNewLine(MenuMessages.HUMAN_PLAYER_INPUT_CONSTANT);
            playerCode = reader.ReadNewLine();
            botCode = digitsService.GenerateRandomCode(GameLimitConstants.MAX_CHARACTERS_NUMBER);
            writer.PrintOnNewLine(MenuMessages.BOT_INPUT_CONSTANT);
            writer.ClearInterface();
        }
    }
}
