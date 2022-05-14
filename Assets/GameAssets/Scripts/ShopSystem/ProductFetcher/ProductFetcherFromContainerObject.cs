using System.Collections.Generic;

public class ProductFetcherFromContainerObject : IProductFetcher
{
    private ProductContainer _productContainer;

    public ProductFetcherFromContainerObject(ProductContainer productContainer)
    {
        _productContainer = productContainer;
    }

    public List<Product> Fetch()
    {
        return _productContainer.Products;
    }
}
