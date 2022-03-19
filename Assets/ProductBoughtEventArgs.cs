using System;

public class ProductBoughtEventArgs : EventArgs
{
    private Product _product;

    public Product Product {
        get => _product;
        private set => _product = value;
    }

    public ProductBoughtEventArgs(Product product)
    {
        Product = product;
    }
}
