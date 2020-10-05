namespace CowsAndBulls.Tree
{
    using HtmlAgilityPack;

    public interface IBCTree
    {
        void PopulateTreeFromHtmlNodes(HtmlNode node);
    }
}
