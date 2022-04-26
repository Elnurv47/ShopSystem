using System;
using UnityEngine;

[Serializable]
public class Product
{
    [SerializeField] private int _price;
    [SerializeField] private ItemData _data;
    [SerializeField] private Category _category;

    public int Price { get => _price; }

    public ItemData Data { get => _data; }

    public Category Category { get => _category; }
}
