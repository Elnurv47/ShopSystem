using UnityEngine;

public class ProductDatabase : MonoBehaviour
{
    public static ProductDatabase Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Product Iron;
    public Product Gold;
    public Product Wood;
    public Product Phone;
}
