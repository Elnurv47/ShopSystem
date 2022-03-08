using System;
using UnityEngine;

[Serializable]
public class Category
{
    private CategoryUI _categoryUI;

    [SerializeField] private string _name;

    public string Name { get => _name; }

    public void SetCategoryUI(CategoryUI categoryUI)
    {
        _categoryUI = categoryUI;
    }

    public void Add(GameObject productUIObject)
    {
        _categoryUI.Add(productUIObject);
    }
}
