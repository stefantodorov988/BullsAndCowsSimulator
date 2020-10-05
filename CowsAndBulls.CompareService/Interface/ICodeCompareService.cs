namespace CowsAndBulls.CompareService.Interface
{
    using CowsAndBulls.CompareService.Models;
    public interface ICodeCompareService
    {
        CodeCompareResultObject CompareCode(string code, string guess);
    }
}
