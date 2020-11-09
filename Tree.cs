using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinarySearchTreeCsharp
{
    public class Tree
    {
        static readonly int distance = 10; // for horizontal spacing when printing
        public static TreeNode baseVal;
        public Tree() // default constructor
        {
            baseVal = null;
        }

        public void addNum(int num) // adding ints to the binary tree object, recursively.
        {
            TreeNode node = new TreeNode(num);
            if (baseVal == null)
                baseVal = node;
            else
                addNode(baseVal, node);
        }

        public static void output(TreeNode nodeArg, int area) // recursively printing the BST horizontally
        {
            if (nodeArg == null)
                return;
            area += distance;
            output(nodeArg.rightNode, area);
            if (area != 0)
            {
                for (int i = distance; i < area - 1; i++)
                    Console.Write(" ");
                Console.Write(nodeArg.number + "\n");
            }
            output(nodeArg.leftNode, area); 
        }
        public static void printHorizontal(TreeNode na) // calls the print
        {
            output(na, 0);
        }

        public void addNode(TreeNode n1, TreeNode n2)
        {
            if (n2.number < n1.number)
            {
                if (n1.leftNode == null)
                    n1.leftNode = n2;
                else
                    addNode(n1.leftNode, n2);
            }
            else
            {
                if (n1.rightNode == null)
                    n1.rightNode = n2;
                else
                    addNode(n1.rightNode, n2);
            }

        }
        public static TreeNode getRoot() // returns the root value as the parent value. Every value will be compared to this value.
        {
            return baseVal;
        }
        public static void removeRandom(int num)
        {
            baseVal = removeNodeVal(baseVal, num);
        }
        public static TreeNode removeNodeVal(TreeNode tn, int val) // recursively removes a randomly assigned int
        {
            if (tn == null)
                return null;
            else if (val > tn.number)
                tn.rightNode = removeNodeVal(tn.rightNode, val);
            else if (val < tn.number)
                tn.leftNode = removeNodeVal(tn.leftNode, val);
            else
            {
                if (!(tn.leftNode == null) && !(tn.rightNode == null))
                {
                    Console.WriteLine("This value is a leaf node - will not be deleted"); // per assignment instructions
                    return tn;
                }
                else if (tn.leftNode == null)
                {
                    tn = tn.rightNode; // delete left node by variable assignment
                    return tn;
                }
                else if (tn.rightNode == null)
                {
                    tn = tn.leftNode;
                    return tn;
                }
            }
            return tn;
        }
        public void insert(int value)
        {
            baseVal = insertValue(baseVal, value);
        }
        public static TreeNode insertValue(TreeNode node, int n) // recursively inserts int based on > or < the previous node.
        {
            if (node == null)
            {
                node = new TreeNode(n);
                return node;
            }
            if (n > node.number)
                node.rightNode = insertValue(node.rightNode, n);
            else if (n < node.number)
                node.leftNode = insertValue(node.leftNode, n);
            return node;


        }
    }
}

