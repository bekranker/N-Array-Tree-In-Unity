using System.Collections.Generic;
using AI.Tree;
using UnityEngine;

/*

NOTE: İç içe bir sistem olduğundan dolayı (ilk başta rootu tanımlayıp atadıktan sonra) recursive function ile bütün childları parentlarına atamak zorunda kalıyoruz;

               -O-  ==============> _Items ile tanımladığımız root bu;
              |   |
        ------O   O------ ============> bunlar _Items[i]'den gelen SubItemslar;
       |                 | ===============> buradan sonrası zaten recursive function;
    ---O---           ---O---
   |       |         |       |
  -O-     -O-       -O-     -O-
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
   .   .   .         .   .   .
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
-O- -O- -O- -O-   -O- -O- -O- -O- =========> burası da recursive function'da return ettiğimiz yer;


*/
public class ItemHandler : MonoBehaviour
{
	//burada belirttiğimiz Itemlar aslında birer root (başlık);
	// mesela silahlar için weapons, kalkanlar için shields gibi;
	[SerializeField] private List<Item> _Items = new();

	private List<Tree<Item>> _createdTrees = new();
	void Start()
	{
		CreateNArrayTree();
	}

	//Her bir Kategori için farklı Treeler oluşur;
	public void CreateNArrayTree()
	{

		for (int i = 0; i < _Items.Count; i++)
		{
			//root Items'dan gelen eleman oluyor
			Tree<Item> _tree = new Tree<Item>(_Items[i]);

			//Eğer kategorinin altında herhangi bir child yoksa return olur;
			if (_Items[i].SubItems.Count == 0)
			{
				Debug.Log($"There is no Child in --{_Items[i].Name}--");
				return;
			}
			//burada da childları varsa childlerı atayacağız;
			foreach (Item item in _Items[i].SubItems)
			{
				AddChildRecursiveFunction(_tree, _tree.Root, item, 1);
			}

			_createdTrees.Add(_tree);
		}
	}
	//bu fonksiyon kendini sürekli çağırıyor (Eğer child T data'nın içerisinde hala varsa, yoksa return olur);
	private void AddChildRecursiveFunction(Tree<Item> currentTree, TreeNode<Item> currentParent, Item currentItem, int currentLayer)
	{

		int tempCurrentLayer = currentLayer + 1;
		TreeNode<Item> tempParent = currentTree.AddChild(currentParent, currentItem, tempCurrentLayer);
		//child yok return olur ve böylelikle tree'nin belli bir kısmı bitmiş olur;
		if (currentItem.SubItems.Count == 0)
		{
			Debug.Log($"There is no more child data in --{tempParent.Data.Name}--");
			return;
		}

		foreach (Item item in currentItem.SubItems)
		{
			AddChildRecursiveFunction(currentTree, tempParent, item, tempCurrentLayer);
		}

	}
	//For debuging
	public void PrintTreeButtonFunction()
	{
		foreach (Tree<Item> item in _createdTrees)
		{
			PrintAllTree(item.Root);
		}
	}
	private void PrintAllTree(TreeNode<Item> startNode)
	{
		if (startNode.Children.Count == 0) return;
		// Tüm alt düğümler için rekürsif olarak çağır
		foreach (TreeNode<Item> childNode in startNode.Children)
		{
			Debug.Log($"from {startNode.Data.Name} ==> to {childNode.Data.Name}");
			PrintAllTree(childNode); // Çocuk düğüm için aynı işlemi yap
		}
	}
}