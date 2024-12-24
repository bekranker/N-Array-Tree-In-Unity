using UnityEngine;
using System;

namespace AI.Tree
{
    public class Tree<T>
    {
        public TreeNode<T> Root;

        public Tree(T root)
        {
            Root = new TreeNode<T>(root);
            Root.Index = 0;
        }

        public TreeNode<T> AddChild(TreeNode<T> parent, T child, int layer)
        {
            TreeNode<T> childNode = new TreeNode<T>(child);
            childNode.Index = layer;
            parent.Children.Add(childNode);
            //ekstra ekledim, tekrar FindNode çağırmamak amaçlı
            return childNode;
        }

        public bool RemoveChild(TreeNode<T> parent, T childnodes)
        {
            if (parent == null)
                return false;

            for (int i = 0; i < parent.Children.Count; i++)
            {
                TreeNode<T> child = parent.Children[i];
                if (child.Data.Equals(childnodes))
                {
                    parent.Children.RemoveAt(i);
                    return true;
                }

                if (RemoveChild(child, childnodes))
                    return true;
            }

            return false;
        }


        public TreeNode<T> FindNode(TreeNode<T> root, T data)
        {
            if (root == null)
                return null;

            if (root.Data.Equals(data))
            {
                return root;
            }

            foreach (TreeNode<T> child in root.Children)
            {
                TreeNode<T> result = FindNode(child, data);
                if (result != null)
                    return result;
            }

            return null;
        }
        public TreeNode<T> FindPreviousNode(TreeNode<T> root, T data)
        {
            TreeNode<T> previous = null;

            if (root == null)
                return null;

            // Traverse through the children nodes
            foreach (TreeNode<T> child in root.Children)
            {
                if (child.Data.Equals(data))
                {
                    // If the current node's data matches, return the previous node (parent)
                    return previous;
                }

                // Before moving to the next child, update the previous node
                previous = root;

                // Recurse through the child nodes
                TreeNode<T> result = FindPreviousNode(child, data);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
        public void Traverse(TreeNode<T> root, Action<TreeNode<T>> visitAction)
        {
            if (root == null)
                return;

            visitAction(root);
            foreach (TreeNode<T> child in root.Children)
            {
                Traverse(child, visitAction);
            }
        }

    }
}