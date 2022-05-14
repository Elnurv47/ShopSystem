using UnityEngine;

using System.Linq;
using System.Collections.Generic;

public class ShopSystem : MonoBehaviour
{
    private List<Product> _products;
    private List<Category> _categories;

    private IProductFetcher _productFetcher;

    private IShopCustomer _shopCustomer;

    public IShopCustomer ShopCustomer { get => _shopCustomer; set => _shopCustomer = value; }

    [SerializeField] private Transform _categoryContainer;

    private void Awake()
    {
        _products = new List<Product>();
        _categories = new List<Category>();
    }

    private void Start()
    {
        foreach (Transform childCategory in _categoryContainer)
        {
            CategoryUI categoryUI = childCategory.GetComponent<CategoryUI>();
            Category category = categoryUI.Category;
            _categories.Add(category);
        }

        _productFetcher = new ProductFetcherFromContainerObject(ProductContainer.Instance);

        List<Product> products = _productFetcher.Fetch();

        products.ForEach(product => AddProduct(product));
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
            category => category.Type == product.Category.Type
        );
    }
}
