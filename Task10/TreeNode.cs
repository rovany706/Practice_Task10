using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class TreeNode
    {
        private static Random rand = new Random();
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int data)
        {
            Data = data;
        }

        public static TreeNode GenerateTree(int size)
        {
            int randomNumber = rand.Next(-50, 51);
            TreeNode root = new TreeNode(randomNumber);
            for (int i = 1; i < size; i++)
                root = Add(root, rand.Next(-50, 51));

            return root;
        }

        public static TreeNode Add(TreeNode root, int number)
        {
            TreeNode p = root;
            TreeNode r = null;
            bool ok = false;
            while (p != null && !ok)
            {
                r = p;
                if (number == p.Data)
                    ok = true;
                else if (number < p.Data)
                    p = p.Left;
                else
                    p = p.Right;
            }

            if (ok)
                return root;
            TreeNode newNode = new TreeNode(number);

            if (number < r.Data)
                r.Left = newNode;
            else
                r.Right = newNode;
            return root;
        }

        public static void ShowTree(TreeNode p, int l)
        {
            if (p != null)
            {
                ShowTree(p.Right, l + 5);
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine("{0,10:F4} ", p.Data);
                ShowTree(p.Left, l + 5);
            }
        }

        public static TreeNode DeleteTree(TreeNode root)
        {
            root = null;
            return root;
        }
    }
}
