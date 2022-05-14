using UnityEngine;

public class CategoryUI : MonoBehaviour
{
    private Transform _productUIContainer;

    [SerializeField] private Category _category;
    [SerializeField] private GameObject _productUIPrefab;
    [SerializeField] private Transform _productUIArea;

    public Category Category { get => _category; }

    private void Awake()
    {
        _category.OnProductAdded += OnProductAdded;
    }

    private void Start()
    {
        _productUIContainer = _productUIArea.Find("ProductUIContainer");
    }

    private void OnProductAdded(Product product)
    {
        Add(product);
    }

    public void Add(Product product)
    {
        GameObject spawnedproductUIObject = Instantiate(_productUIPrefab, _productUIContainer);

        ProductUI spawnedProductUI = spawnedproductUIObject.GetComponent<ProductUI>();

        spawnedProductUI.SetProduct(product);
    }
}
