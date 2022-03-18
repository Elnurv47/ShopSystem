using System;

public class ProductAddedEventArgs : EventArgs
{
    private Product _product;

    public Product Product { 
        get => _product; 
        private set => _product = value; 
    }

    public ProductAddedEventArgs(Product product)
    {
        Product = product;
    }
}
