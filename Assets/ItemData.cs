using System;
using UnityEngine;

[Serializable]
public struct ItemData
{
    [SerializeField] private int _id;
    public int Id { get => _id; set => _id = value; }


    [SerializeField] private string _name;
    public string Name { get => _name; set => _name = value; }


    [SerializeField] private bool _isStackable;
    public bool IsStackable { get => _isStackable; set => _isStackable = value; }


    [SerializeField] private int _stackAmount;
    public int StackAmount { get => _stackAmount; set => _stackAmount = value; }


    [SerializeField] private string _description;
    public string Description { get => _description; set => _description = value; }


    [SerializeField] private Sprite _sprite;
    public Sprite Sprite { get => _sprite; set => _sprite = value; }


    [SerializeField] private ItemType _type;
    public ItemType Type { get => _type; set => _type = value; }


    public ItemData(int id, string name, bool isStackable, int stackAmount, string description, Sprite sprite, ItemType type)
    {
        _id = id;
        _name = name;
        _isStackable = isStackable;
        _stackAmount = stackAmount;
        _description = description;
        _sprite = sprite;
        _type = type;
    }

    public static ItemData Empty { get; } = new ItemData(0, "", false, 0, "", null, ItemType.Empty);
}
