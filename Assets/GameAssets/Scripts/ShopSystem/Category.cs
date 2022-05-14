using System;
using UnityEngine;

[Serializable]
public class Category
{
    [SerializeField] private CategoryType _type;
    public CategoryType Type { get => _type; }

    public event Action<Product> OnProductAdded;

    public void Add(Product product)
    {
        OnProductAdded?.Invoke(product);
    }
}
