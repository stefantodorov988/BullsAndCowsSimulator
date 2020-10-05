namespace CowsAndBulls.Tree
{
    using CowsAndBulls.Constants;
    using HtmlAgilityPack;
    using System.Collections.Generic;
    using System.Linq;

    public class BCTree : IBCTree
    {
        public TreeNode Root { get; set; }
        public BCTree()
        {
            Root = new TreeNode();
        }
        public void PopulateTreeFromHtmlNodes(HtmlNode node)
        {
            Root = Populate(node);
        }

        private TreeNode Populate(HtmlNode node)
        {
            var currentInfo = node.ChildNodes.FirstOrDefault(x => x.Name == HTMLConstants.SpanTag).InnerHtml.Split(HTMLConstants.SpanSplitter);
            var currentKey = currentInfo[0];
            var nextGuess = currentInfo[2];
            var childList = node.ChildNodes.FirstOrDefault(x => x.Name == HTMLConstants.UnorderedListTag);

            var treeNode = new TreeNode();
            treeNode.children = new List<TreeNode>();
            treeNode.nextGuess = nextGuess;
            treeNode.key = currentKey;

            if (childList != null && childList.ChildNodes != null)
            {
                var elementsInChildNode = childList.ChildNodes.Where(x => x.Name == HTMLConstants.ListTag);

                foreach (var child in elementsInChildNode)
                {
                    treeNode.children.Add(Populate(child));
                }
            }
            return treeNode;
        }
    }
}