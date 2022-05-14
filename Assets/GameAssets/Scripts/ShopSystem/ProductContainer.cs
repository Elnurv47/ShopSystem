using System.Collections.Generic;
using UnityEngine;

public class ProductContainer : MonoBehaviour
{
    public static ProductContainer Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public List<Product> Products;
}
