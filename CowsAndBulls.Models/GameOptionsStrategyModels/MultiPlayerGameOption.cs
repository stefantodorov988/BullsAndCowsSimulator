namespace CowsAndBulls.Models.GameOptionsStrategyModels
{
    using CowsAndBulls.CompareService.Interface;
    using CowsAndBulls.Constants;
    using CowsAndBulls.IO.Service.Interface;
    using Interface;
    using System;

    public class MultiPlayerGameOption : IGameOption
    {
        private readonly ICodeCompareService codeCompareService;
        private readonly IWriter writer;
        private readonly IReader reader;
        private string firstPlayerCode;
        private string secondPlayerCode;
        private bool isFirstPlayerTurn = true;
        public MultiPlayerGameOption(IWriter writer, IReader reader, ICodeCompareService codeCompareService)
        {
            this.writer = writer;
            this.reader = reader;
            this.codeCompareService = codeCompareService;
        }
        public void Run()
        {
            this.ReceivePlayersCode();
            this.StartMatch();

        }
        public bool IsApplicable(string input)
        {
            return input == UserInputConstants.MULTI_PLAYER;
        }
        private void ReceivePlayersCode()
        {
            this.InitializePlayers();
        }

        private void StartMatch()
        {
            if (isFirstPlayerTurn)
                writer.ChangeOutputColor(ConsoleColor.DarkGray);
            else
                writer.ChangeOutputColor(ConsoleColor.Blue);

            writer.PrintOnNewLine(isFirstPlayerTurn ? MenuMessages.FIRST_PLAYER_ATTEMPT_CONSTANT : MenuMessages.SECOND_PLAYER_ATTEMPT_CONSTANT);
            var playersGuess = reader.ReadNewLine();

            var compareResult = isFirstPlayerTurn ?
                codeCompareService.CompareCode(secondPlayerCode, playersGuess)
              : codeCompareService.CompareCode(firstPlayerCode, playersGuess);



            writer.PrintOnNewLine(MenuMessages.COWS_COUNTER_MESSAGE + compareResult.CowsNumber);
            writer.PrintOnNewLine(MenuMessages.BULLS_COUNTER_MESSAGE + compareResult.BullsNumber);
            writer.PrintOnNewLine(MenuMessages.MENU_SEPARATOR);

            if (compareResult.BullsNumber == GameLimitConstants.MAX_CHARACTERS_NUMBER)
            {
                writer.PrintOnNewLine(isFirstPlayerTurn ? MenuMessages.FIRST_PLAYER_WON : MenuMessages.SECOND_PLAYER_WON);
                writer.PrintOnLine(MenuMessages.ATTEMPT_COUNTER_MESSAGE);
                return;
            }

            isFirstPlayerTurn = !isFirstPlayerTurn;
            this.StartMatch();
        }
        private void InitializePlayers()
        {
            writer.ClearInterface();
            writer.PrintOnNewLine(MenuMessages.FIRST_PLAYER_INPUT_CONSTANT);
            firstPlayerCode = reader.ReadNewLine();
            writer.ClearInterface();
            writer.PrintOnNewLine(MenuMessages.SECOND_PLAYER_INPUT_CONSTANT);
            secondPlayerCode = reader.ReadNewLine();
            writer.ClearInterface();
        }
    }
}
