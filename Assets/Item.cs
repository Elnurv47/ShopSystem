using System;
using UnityEngine;

[Serializable]
public class Item : IComparable<Item>
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

    public bool IsStackable { get => Data.IsStackable; }

    public int StackAmount { get => Data.StackAmount; }

    public Sprite Sprite { get => Data.Sprite; }

    public ItemType Type { get => Data.Type; }

    public bool AmountIsLessThanOrEqual(int amountToCheck) => Amount <= amountToCheck;

    public bool IsSameAs(Item item) => Type == item.Type;

    public bool ExceedsStack() => Amount > Data.StackAmount;

    public int CompareTo(Item other)
    {
        if (Data.Id < other.Data.Id) return -1;
        if (Data.Id > other.Data.Id) return 1;
        else return 0;
    }

    public static Item Empty { get => new Item(0, ItemData.Empty); }
}
