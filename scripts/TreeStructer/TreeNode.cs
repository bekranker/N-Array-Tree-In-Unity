using UnityEngine;
using System.Collections.Generic;

namespace AI.Tree
{
  public class TreeNode<T>
  {
    public T Data;
    public List<TreeNode<T>> Children;

    public TreeNode(T data)
    {
      Data = data;
      Children = new List<TreeNode<T>>();
    }
  }
}

