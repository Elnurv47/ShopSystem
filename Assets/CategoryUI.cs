using UnityEngine;

public class CategoryUI : MonoBehaviour
{
    [SerializeField] private Category _category;
    [SerializeField] private GameObject _productUIPrefab;
    [SerializeField] private Transform _slotContainer;

    public Category Category { get => _category; }

    private void Awake()
    {
        _category.OnProductAdded += OnProductAdded;
    }

    private void OnProductAdded(object sender, ProductAddedEventArgs args)
    {
        Add(args.Product);
    }

    public void Add(Product product)
    {
        GameObject spawnedproductUIObject = Instantiate(_productUIPrefab);

        ProductUI spawnedProductUI = spawnedproductUIObject.GetComponent<ProductUI>();

        spawnedProductUI.SetProduct(product);

        spawnedproductUIObject.transform.SetParent(_slotContainer);
    }
}
