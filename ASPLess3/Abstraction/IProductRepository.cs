using ASPLess3.Dto;


namespace ASPLess3.Abstraction
{
	public interface IProductRepository
    {
        IEnumerable<ProductDto> GetAllProducts();
        int AddProduct(ProductDto productDto);
        void DeleteProduct(int id);
    }
}
