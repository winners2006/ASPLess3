using Microsoft.AspNetCore.Mvc;
using ASPLess3.Dto;
using ASPLess3.Models;


namespace ASPLess3.Abstraction
{
	public interface IProductRepository
    {
        IEnumerable<ProductDto> GetAllProducts();
        int AddProduct(ProductDto productDto);
        void DeleteProduct(int id);
    }
}
