using System;
using UnityEngine;

public class CoinChangedEventArgs : EventArgs
{
    private int _coinAmount;

    public int CoinAmount { get => _coinAmount; private set => _coinAmount = value; }

    public CoinChangedEventArgs(int coinAmount)
    {
        CoinAmount = coinAmount;
    }
}

public interface IShopCustomer
{
    int GetCoinAmount();
    void SetCoinAmount(int newAmount);
    void HandleBoughtProduct(Product product);
    bool CanBuy(Product product);

    event EventHandler<CoinChangedEventArgs> OnCoinChanged;
}

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
