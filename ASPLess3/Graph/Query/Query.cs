using ASPLess3.Models;
using ASPLess3.Dto;
using ASPLess3.Abstraction;
using ASPLess3.Repository;

namespace ASPLess3.Graph.Query
{
    public class Query(IProductRepository productRepository)
    {
        //public IEnumerable<ProductDto> GetProducts() => productRepository.GetAllProducts();
        public IEnumerable<ProductDto> GetProducts([Service] IProductRepository repository) =>
            repository.GetAllProducts();

        public IEnumerable<ProductGroupDto> GetProductGroups([Service] IProductGroupRepository groupRepository) =>
            groupRepository.GetAllProductGroups();

    }
}
