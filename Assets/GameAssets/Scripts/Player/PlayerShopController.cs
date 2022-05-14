using System;
using UnityEngine;

public class PlayerShopController : MonoBehaviour, IShopCustomer
{
    private int _coinAmount = 200;

    [SerializeField] private ShopSystem _shopSystem;

    public IInventory Inventory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event Action<int> OnCoinChanged;

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
        OnCoinChanged?.Invoke(_coinAmount);
    }

    public void HandleBoughtProduct(Product product)
    {
        _coinAmount -= product.Price;
        OnCoinChanged?.Invoke(_coinAmount);
        Inventory.AddItem(new Item(1, product.ItemData));
    }

    public bool CanBuy(Product product)
    {
        return _coinAmount >= product.Price;
    }
}
