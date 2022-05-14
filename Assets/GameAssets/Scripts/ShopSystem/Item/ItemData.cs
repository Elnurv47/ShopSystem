using System;
using UnityEngine;

[Serializable]
public struct ItemData
{
    [SerializeField] private int _id;
    public int Id { get => _id; set => _id = value; }


    [SerializeField] private string _name;
    public string Name { get => _name; set => _name = value; }

    [SerializeField] private string _description;
    public string Description { get => _description; set => _description = value; }


    [SerializeField] private Sprite _sprite;
    public Sprite Sprite { get => _sprite; set => _sprite = value; }


    [SerializeField] private ItemType _type;
    public ItemType Type { get => _type; set => _type = value; }


    public ItemData(int id, string name, string description, Sprite sprite, ItemType type)
    {
        _id = id;
        _name = name;
        _description = description;
        _sprite = sprite;
        _type = type;
    }

    public static ItemData Empty { get; } = new ItemData(0, "", "", null, ItemType.Empty);
}
