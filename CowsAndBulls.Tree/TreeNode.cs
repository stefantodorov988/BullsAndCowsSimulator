namespace CowsAndBulls.Tree
{
    using System.Collections.Generic;

    public class TreeNode
    {
        public List<TreeNode> children;
        public string nextGuess;
        public string key;
        public TreeNode()
        {
            children = new List<TreeNode>();
        }
    }
}
