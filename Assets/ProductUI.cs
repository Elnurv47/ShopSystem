using System;
using UnityEngine;
using UnityEngine.UI;

public class ProductBoughtEventArgs : EventArgs
{
    private Product _product;

    public Product Product {
        get => _product;
        private set => _product = value;
    }

    public ProductBoughtEventArgs(Product product)
    {
        Product = product;
    }
}

public class ProductUI : MonoBehaviour
{
    private Product _product;

    [SerializeField] private Text _headerText;
    [SerializeField] private Image _image;
    [SerializeField] private Text _priceText;

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

    }
}
