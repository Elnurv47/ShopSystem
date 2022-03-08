using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ShopSystem : MonoBehaviour
{
    private List<Product> _products;
    private List<Category> _categories;

    [SerializeField] private GameObject _productUIPrefab;
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
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        GameObject spawnedProductUIObject = Instantiate(_productUIPrefab);

        ProductUI spawnedProductUI = spawnedProductUIObject.GetComponent<ProductUI>();

        spawnedProductUI.SetProduct(product);

        Category appropriateCategory = FindAppropriateCategory(product);

        appropriateCategory.Add(spawnedProductUIObject);
    }

    private Category FindAppropriateCategory(Product product)
    {
        return _categories.Find(
            category => category.Name == product.Category.Name
        );
    }
}
