namespace CowsAndBulls.CompareService
{
    using CowsAndBulls.CompareService.Interface;
    using CowsAndBulls.CompareService.Models;
    public class CodeCompareService : ICodeCompareService
    {
        public CodeCompareResultObject CompareCode(string code, string guess)
        {
            return Compare(code, guess);
        }

        private CodeCompareResultObject Compare(string code, string guess)
        {
            var resultObject = new CodeCompareResultObject();

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == guess[i])
                {
                    resultObject.BullsNumber++;
                    continue;
                }
                else
                {
                    var currentChar = guess[i];
                    for (int j = 0; j < code.Length; j++)
                    {
                        if (j == i)
                            continue;

                        if (currentChar == code[j])
                        {
                            resultObject.CowsNumber++;
                            continue;
                        }
                    }
                }
            }
            return resultObject;
        }
    }
}
