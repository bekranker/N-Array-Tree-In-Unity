using UnityEngine;
using System.Collections.Generic;

namespace AI.Tree
{
  public class TreeNode<T>
  {
    public int Index; // 1.2.1 etc;
    public T Data;
    public List<TreeNode<T>> Children;

    public TreeNode(T data)
    {
      Data = data;
      Children = new List<TreeNode<T>>();
    }
  }
}

