using System;

public class CoinChangedEventArgs : EventArgs
{
    private int _coinAmount;

    public int CoinAmount { get => _coinAmount; private set => _coinAmount = value; }

    public CoinChangedEventArgs(int coinAmount)
    {
        CoinAmount = coinAmount;
    }
}
