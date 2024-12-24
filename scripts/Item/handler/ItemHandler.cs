using System.Collections.Generic;
using AI.Tree;
using UnityEngine;


/*

NOTE: İç içe bir sistem olduğundan dolayı (ilk başta rootu tanımlayıp atadıktan sonra) recursive function ile bütün childları parentlarına atamak zorunda kalıyoruz.

               -O-  ==============> _Items ile tanımladığımız root bu
              |   |
        ------O   O------ ============> bunlar _Items[i]'den gelen SubItemslar
       |                 | ===============> buradan sonrası zaten recursive function
    ---O---           ---O---
   |       |         |       |
  -O-     -O-       -O-     -O-
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
   .   .   .         .   .   .
 |   |   |   |     |   |   |   |
 |   |   |   |     |   |   |   |
-O- -O- -O- -O-   -O- -O- -O- -O- =========> burası da recursive function'da return ettiğimiz yer.


*/
public class ItemHandler : MonoBehaviour
{
	//burada belirttiğimiz Itemlar aslında birer root (başlık)
	// mesela silahlar için weapons, kalkanlar için shields gibi
	[SerializeField] private List<Item> _Items = new();

	private Tree<Item> _tree;



	//Her bir Kategori için farklı Treeler oluşur.
	public void CreateNArrayTree()
	{

		for (int i = 0; i < _Items.Count; i++)
		{
			//root Items'dan gelen eleman oluyor
			_tree = new Tree<Item>(_Items[i]);

			//Eğer kategorinin altında herhangi bir child yoksa return olur.
			if (_Items[i].SubItems.Count == 0)
			{
				Debug.Log($"There is no Child in --{_Items[i]}--");
				return;
			}
			//burada da childları varsa childlerı atayacağız.
			foreach (Item item in _Items[i].SubItems)
			{
				AddChildRecursiveFunction(_tree, _tree.Root, item);
			}
		}
	}
	//bu fonksiyon kendini sürekli çağırıyor (Eğer child T data'nın içerisinde hala varsa, yoksa return olur)
	private void AddChildRecursiveFunction(Tree<Item> currentTree, TreeNode<Item> currentParent, Item currentItem)
	{
		TreeNode<Item> tempParent = currentTree.AddChild(currentParent, currentItem);
		//child yok return olur ve böylelikle tree'nin belli bir kısmı bitmiş olur.
		if (currentItem.SubItems.Count == 0)
		{
			Debug.Log($"There is no more child data in --{tempParent}--");
			return;
		}

		foreach (Item item in currentItem.SubItems)
		{
			AddChildRecursiveFunction(currentTree, tempParent, item);
		}

	}
}