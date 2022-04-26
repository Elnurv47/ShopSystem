using System;
using UnityEngine;

[Serializable]
public class Category
{
    //[SerializeField] private string _name;

    [SerializeField] private CategoryType _type;
    public CategoryType Type { get => _type; }

    public event Action<Product> OnProductAdded;
    //public string Name { get => _name; }

    public void Add(Product product)
    {
        OnProductAdded?.Invoke(product);
    }
}
