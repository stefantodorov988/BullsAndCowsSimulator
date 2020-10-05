namespace CowsAndBulls.BCTreeFactory
{
    using CowsAndBulls.BCTreeFactory.Interface;
    using CowsAndBulls.Tree;
    using HtmlAgilityPack;
    using System.IO;

    public class BCTreeFactory : IBCTreeFactory
    {
        public BCTree CreateTree()
        {
            var file = File.ReadAllText(@"..\..\..\..\res\solving_tree.txt");
            var json = new HtmlDocument();
            json.LoadHtml(file);

            var tree = json.GetElementbyId("black");
            var startNode = tree.ChildNodes[1];

            var bcTree = new BCTree();
            bcTree.PopulateTreeFromHtmlNodes(startNode);
            return bcTree;
        }
    }
}
