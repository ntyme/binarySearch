using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTreeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree newtree = new Tree();
            Random num = new Random();
            int[] ary = new int[20];
            for (int i = 0; i < ary.Length; i++)
                ary[i] = num.Next(1, 100);
            Console.WriteLine("Array has been filled");
            foreach (int i in ary)
                newtree.addNum(i);
            Console.WriteLine("Binary Search Tree has been filled\n\n");
            Console.WriteLine("Printing Tree Output: The Binary Search Tree will read horizontally,\n rather than vertically," +
                    " with the nodes clearly visible. The parent node is the left-most number.");
            TreeNode baseNode = Tree.getRoot(); 
            Tree.printHorizontal(baseNode);
            int random = num.Next(0, 19); // random int in binary tree to be removed
            Console.WriteLine("\n\nRemoving random value: " + ary[random]);
            Tree.removeRandom(ary[random]);
            Console.WriteLine("\nPrinting Tree Output After Removing : " + ary[random]);
            TreeNode bn = Tree.getRoot();
            int ranNumLast = num.Next(1, 20);
            Console.WriteLine("Adding Random Value " + ranNumLast);
            newtree.insert(ranNumLast);
            TreeNode n = Tree.getRoot();
            Tree.printHorizontal(n);
        }
    }
}
