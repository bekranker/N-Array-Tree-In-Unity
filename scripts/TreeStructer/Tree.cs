using UnityEngine;
using System;

namespace AI.Tree
{
    public class Tree<T>
    {
        public TreeNode<T> Root;

        public Tree(T rootData)
        {
            Root = new TreeNode<T>(rootData);
        }

        public void AddChild(TreeNode<T> parent, T childData)
        {
            TreeNode<T> childNode = new TreeNode<T>(childData);
            parent.Children.Add(childNode);
        }

        public bool RemoveChild(TreeNode<T> parent, T data)
        {
            if (parent == null)
                return false;

            for (int i = 0; i < parent.Children.Count; i++)
            {
                TreeNode<T> child = parent.Children[i];
                if (child.Data.Equals(data))
                {
                    parent.Children.RemoveAt(i);
                    return true;
                }

                if (RemoveChild(child, data))
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