using System;
using UnityEngine;

public class ProductUI : MonoBehaviour
{
    [SerializeField] private Product _product;

    public void SetProduct(Product product)
    {
        _product = product;
        UpdateUI();
    }

    private void UpdateUI()
    {
        throw new NotImplementedException();
    }
}
