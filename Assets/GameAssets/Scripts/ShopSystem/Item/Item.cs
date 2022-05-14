using System;
using UnityEngine;

[Serializable]
public class Item
{
    public int Amount { get; set; }

    [SerializeField] private ItemData _data;

    public ItemData Data { get => _data; private set => _data = value; }

    public Item(int amount, ItemData data)
    {
        Amount = amount;
        Data = data;
    }

    public Item(Item copy)
    {
        Amount = copy.Amount;
        Data = copy.Data;
    }

    public bool IsEmpty { get => Type.Equals(ItemType.Empty); }

    public Sprite Sprite { get => Data.Sprite; }

    public ItemType Type { get => Data.Type; }

    public override string ToString()
    {
        return $"{Amount}x {Data.Name}";
    }
}
