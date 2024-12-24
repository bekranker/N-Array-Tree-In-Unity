using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public bool Sold;
    public Sprite CoverImage;
    [Range(0, 1000)] public int Price;
    public string Description;
    public float Damage;
    public List<Item> SubItems;

}
