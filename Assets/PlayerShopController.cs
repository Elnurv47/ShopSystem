using System;
using UnityEngine;

public class PlayerShopController : MonoBehaviour, IShopCustomer
{
    private int _coinAmount = 200;

    [SerializeField] private ShopSystem _shopSystem;

    public event EventHandler<CoinChangedEventArgs> OnCoinChanged;

    private void Awake()
    {
        _shopSystem.ShopCustomer = this;
    }

    public int GetCoinAmount()
    {
        return _coinAmount;
    }

    public void SetCoinAmount(int newAmount)
    {
        _coinAmount = newAmount;
        OnCoinChanged?.Invoke(this, new CoinChangedEventArgs(_coinAmount));
    }

    public void HandleBoughtProduct(Product product)
    {
        _coinAmount -= product.Price;
        OnCoinChanged?.Invoke(this, new CoinChangedEventArgs(_coinAmount));
        Debug.Log("Item has been added to inventory: " + product.Data.Name);
    }

    public bool CanBuy(Product product)
    {
        return _coinAmount >= product.Price;
    }
}
