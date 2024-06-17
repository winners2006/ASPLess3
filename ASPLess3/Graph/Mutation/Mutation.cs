using ASPLess3.Abstraction;
using ASPLess3.Dto;
using ASPLess3.Repository;

namespace ASPLess3.Graph.Mutation
{
    public class Mutation(IProductRepository productRepository)
    {
        public int AddProduct(ProductDto productDto) => productRepository.AddProduct(productDto);
        public int AddProductGroup([Service] IProductGroupRepository productGroupRepository, ProductGroupDto productGroupDto) => productGroupRepository.AddProductGroup(productGroupDto);
    }
}
