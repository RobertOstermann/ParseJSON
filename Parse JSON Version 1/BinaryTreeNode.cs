/* BinaryTreeNode.cs
 * Author: Rod Howell
 * Modified By: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_JSON_Version_1
{
    public class BinaryTreeNode<T>
    {
        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Gets this node's left child.
        /// </summary>
        public BinaryTreeNode<T> LeftChild { get; }

        /// <summary>
        /// Gets this node's right child.
        /// </summary>
        public BinaryTreeNode<T> RightChild { get; }

        /// <summary>
        /// Stores the height of the tree
        /// </summary>
        private int _height;

        /// <summary>
        /// Constructs a BinaryTreeNode with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="left">The left child.</param>
        /// <param name="right">The right child.</param>
        private BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Data = data;
            LeftChild = left;
            RightChild = right;
            _height = Math.Max(Height(LeftChild), Height(RightChild));
            _height += 1;
        }
        /// <summary>
        /// Gets the height of the tree
        /// </summary>
        /// <param name="t">Binary Tree Node</param>
        /// <returns>height of t</returns>
        public static int Height(BinaryTreeNode<T> t)
        {
            if (t == null)
            {
                return -1;
            }
            return t._height;
        }

        /// <summary>
        /// Builds the result of performing a single rotate right on the binary tree
        /// described by the given root, left child, and right child.
        /// </summary>
        /// <param name="root">The data stored in the root of the original tree.</param>
        /// <param name="left">The left child of the root of the original tree.</param>
        /// <param name="right">The right child of the root of the original tree.</param>
        /// <returns>The result of performing a single rotate right on the tree described
        /// by the parameters.</returns>
        private static BinaryTreeNode<T> SingleRotateRight(T root, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            BinaryTreeNode<T> newRight = new BinaryTreeNode<T>(root, left.RightChild, right);
            return new BinaryTreeNode<T>(left.Data, left.LeftChild, newRight);
        }
        /// <summary>
        /// Builds the result of performing a single rotate left on the binary tree
        /// described by the given root, left child, and right child.
        /// </summary>
        /// <param name="root">The data stored in the root of the original tree.</param>
        /// <param name="left">The left child of the root of the original tree.</param>
        /// <param name="right">The right child of the root of the original tree.</param>
        /// <returns>The result of performing a single rotate left on the tree described.</returns>
        private static BinaryTreeNode<T> SingleRotateLeft(T root, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            BinaryTreeNode<T> newLeft = new BinaryTreeNode<T>(root, left, right.LeftChild);
            return new BinaryTreeNode<T>(right.Data, newLeft, right.RightChild);
        }
        /// <summary>
        /// Builds the result of performing a double rotate right on the binary tree
        /// described by the given root, left child, and right child.
        /// </summary>
        /// <param name="root">The data stored in the root of the original tree.</param>
        /// <param name="left">The left child of the root of the original tree.</param>
        /// <param name="right">The right child of the root of the original tree.</param>
        /// <returns>The result of performing a double rotate right on the tree described.</returns>
        private static BinaryTreeNode<T> DoubleRotateRight(T root, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            BinaryTreeNode<T> newRight = new BinaryTreeNode<T>(root, left.RightChild.RightChild, right);
            BinaryTreeNode<T> newLeft = new BinaryTreeNode<T>(left.Data, left.LeftChild, left.RightChild.LeftChild);
            return new BinaryTreeNode<T>(left.RightChild.Data, newLeft, newRight);
        }
        /// <summary>
        /// Builds the result of performing a double rotate left on the binary tree
        /// described by the given root, left child, and right child.
        /// </summary>
        /// <param name="root">The data stored in the root of the original tree.</param>
        /// <param name="left">The left child of the root of the original tree.</param>
        /// <param name="right">The right child of the root of the original tree.</param>
        /// <returns>The result of performing a double rotate left on the tree described.</returns>
        private static BinaryTreeNode<T> DoubleRotateLeft(T root, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            BinaryTreeNode<T> newRight = new BinaryTreeNode<T>(right.Data, right.LeftChild.RightChild, right.RightChild);
            BinaryTreeNode<T> newLeft = new BinaryTreeNode<T>(root, left, right.LeftChild.LeftChild);
            return new BinaryTreeNode<T>(right.LeftChild.Data, newLeft, newRight);
        }

        /// <summary>
        /// Constructs an AVL Tree from the given data element and trees. The heights of the 
        /// trees must differ by at most two. The tree built will have the same inorder traversal order 
        /// as if the data were at the root, left were the left child, and right were the right
        /// child.
        /// </summary>
        /// <param name="data">A data item to be stored in the tree.</param>
        /// <param name="left">An AVL Tree containing elements less than data.</param>
        /// <param name="right">An AVL Tree containing elements greater than data.</param>
        /// <returns>The AVL Tree constructed.</returns>
        public static BinaryTreeNode<T> GetAvlTree(T data, BinaryTreeNode<T> left,
            BinaryTreeNode<T> right)
        {
            int diff = Height(left) - Height(right);
            if (Math.Abs(diff) > 2)
            {
                throw new ArgumentException();
            }
            else if (diff == 2)
            {
                if (Height(left.LeftChild) > Height(right))
                {
                    return SingleRotateRight(data, left, right);
                }
                else
                {
                    return DoubleRotateRight(data, left, right);
                }
            }
            else if (diff == -2)
            {
                if (Height(right.RightChild) > Height(left))
                {
                    return SingleRotateLeft(data, left, right);
                }
                else
                {
                    return DoubleRotateLeft(data, left, right);
                }
            }
            else
            {
                return new BinaryTreeNode<T>(data, left, right);
            }
        }
    }
}
