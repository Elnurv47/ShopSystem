using System;

public interface IShopCustomer
{
    IInventory Inventory { get; set; }
    int GetCoinAmount();
    void SetCoinAmount(int newAmount);
    void HandleBoughtProduct(Product product);
    bool CanBuy(Product product);

    event Action<int> OnCoinChanged;
}
