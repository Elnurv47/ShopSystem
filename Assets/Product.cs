using System;
using UnityEngine;

[Serializable]
public class Product
{
    [SerializeField] private int _price;
    [SerializeField] private ItemData _item;
    [SerializeField] private Category _category;

    public Category Category { get => _category; }
}
