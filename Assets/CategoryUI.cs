using System;
using UnityEngine;

public class CategoryUI : MonoBehaviour
{
    [SerializeField] private Category _category;

    public Category Category { get => _category; }

    private void Awake()
    {
        _category?.SetCategoryUI(this);
    }

    public void Add(GameObject productUIObject)
    {
        productUIObject.transform.SetParent(transform);
    }
}
