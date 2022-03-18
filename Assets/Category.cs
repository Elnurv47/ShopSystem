using System;
using UnityEngine;

[Serializable]
public class Category
{
    [SerializeField] private string _name;

    public event EventHandler<ProductAddedEventArgs> OnProductAdded;

    public string Name { get => _name; }

    public void Add(Product product)
    {
        OnProductAdded?.Invoke(this, new ProductAddedEventArgs(product));
    }
}
