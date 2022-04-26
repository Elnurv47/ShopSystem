using System;

public interface IShopCustomer
{
    int GetCoinAmount();
    void SetCoinAmount(int newAmount);
    void HandleBoughtProduct(Product product);
    bool CanBuy(Product product);

    event Action<int> OnCoinChanged;
}
