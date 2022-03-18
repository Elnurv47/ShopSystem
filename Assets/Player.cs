using System;
using UnityEngine;

public class CoinChangedEventArgs : EventArgs
{
    private int _coin;

    public int Coin { get => _coin; private set => _coin = value; }

    public CoinChangedEventArgs(int coin)
    {
        Coin = coin;
    }
}

public interface IShopCustomer
{
    int GetCoinAmount();
    void SetCoinAmount(int newAmount);

    event EventHandler<CoinChangedEventArgs> OnCoinChanged;
}

public class Player : MonoBehaviour, IShopCustomer
{
    private int _coinAmount = 200;

    [SerializeField] private ShopSystem _shopSystem;

    public event EventHandler<CoinChangedEventArgs> OnCoinChanged;

    private void Awake()
    {
        _shopSystem.SetShopCustomer(this);
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
}
