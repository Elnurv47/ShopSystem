using UnityEngine;
using UnityEngine.UI;

public class ProductUI : MonoBehaviour
{
    private Product _product;
    private IShopCustomer _shopCustomer;

    [SerializeField] private Text _headerText;
    [SerializeField] private Image _image;
    [SerializeField] private Text _priceText;
    [SerializeField] private Button _buyButton;

    private void Start()
    {
        _shopCustomer = GetComponentInParent<ShopSystem>().ShopCustomer;
        _shopCustomer.OnCoinChanged += ShopCustomer_OnCoinChanged;
    }

    private void ShopCustomer_OnCoinChanged(int coinAmount)
    {
        _buyButton.interactable = _shopCustomer.CanBuy(_product);
    }

    public void SetProduct(Product product)
    {
        _product = product;
        UpdateUI();
    }

    private void UpdateUI()
    {
        _headerText.text = _product.Data.Name;
        _image.sprite = _product.Data.Sprite;
        _priceText.text = _product.Price.ToString();
    }

    public void OnBuyButtonClicked()
    {
        _shopCustomer.HandleBoughtProduct(_product);
    }
}
