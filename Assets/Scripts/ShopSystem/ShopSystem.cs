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
