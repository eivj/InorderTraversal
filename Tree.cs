using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InorderTraversal
{
    public class Tree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public Node<T> AddNode(T inputDataNode, Node<T> root)
        {
            if (root == null)
            {
                root = new Node<T>(inputDataNode);
            }
            else
            {
                if (inputDataNode.CompareTo(root.Data) < 0)
                {

                    root.Left = AddNode(inputDataNode, root.Left);

                }
                else
                {
                    root.Right = AddNode(inputDataNode, root.Right);
                }
            }

            return root;
        }


        public void Write(int x, int y, Node<T> root, int delta = 0)
        {
            if (root != null)
            {
                if (delta == 0)
                    delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(root.Data);
                Write(x - delta, y + 3, root.Left, delta / 2);
                Write(x + delta, y + 3, root.Right, delta / 2);
            }

        }

        public string Inorder(Node<T> root, ref string result)
        {

            if (root != null)
            {
                Inorder(root.Left, ref result);
                result += Convert.ToString(root.Data) + " ";
                Inorder(root.Right, ref result);

            }

            return result;
        }
        public IEnumerator<string> GetEnumerator()
        {
            string Data = String.Empty;
            if (Root.Left != null)
            {
                Data = Inorder(Root, ref Data);

                string[] temp = Data.Split(' ');
                yield return Data;

            }
        }
    }
}
