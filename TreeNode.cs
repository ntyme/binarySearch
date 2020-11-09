using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeCsharp
{
   public class TreeNode
    {
        public int number { get; set; } // root
        public TreeNode leftNode { get; set; }
        public TreeNode rightNode { get; set; }

        public TreeNode(int num)
        {
            number = num;
            leftNode = null;
            rightNode = null;
        }
    }
}
