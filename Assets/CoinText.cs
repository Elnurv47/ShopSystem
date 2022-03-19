using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    private Text _coinText;

    [SerializeField] private PlayerShopController _player;

    private void Awake()
    {
        _coinText = GetComponent<Text>();
        _player.OnCoinChanged += Player_OnCoinChanged;
    }

    private void Player_OnCoinChanged(object sender, CoinChangedEventArgs e)
    {
        _coinText.text = e.CoinAmount.ToString();
    }
}
