using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ShopSystem : MonoBehaviour
{
    private List<Product> _products;
    private List<Category> _categories;

    private IShopCustomer _shopCustomer;

    [SerializeField] private List<CategoryUI> _categoryUIList;

    private void Awake()
    {
        _products = new List<Product>();
        _categories = new List<Category>();
    }

    private void Start()
    {
        _categories.AddRange(
            _categoryUIList
            .Select(categoryUI => categoryUI.Category)
        );

        List<Product> products = ProductDatabase.Instance.Products;

        products.ForEach(product => AddProduct(product));
    }

    public void SetShopCustomer(IShopCustomer shopCustomer)
    {
        _shopCustomer = shopCustomer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);

        Category appropriateCategory = FindAppropriateCategory(product);

        appropriateCategory.Add(product);
    }

    private Category FindAppropriateCategory(Product product)
    {
        return _categories.Find(
            category => category.Name == product.Category.Name
        );
    }
}
