using System.Collections.Generic;
using UnityEngine;

public class ProductDatabase : MonoBehaviour
{
    public static ProductDatabase Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public List<Product> Products;
}
