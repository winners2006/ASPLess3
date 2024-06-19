using ASPLess3.Dto;
using ASPLess3.Abstraction;

namespace ASPLess3.Graph.Query
{
    public class Query
    {
        //public IEnumerable<ProductDto> GetProducts() => productRepository.GetAllProducts();
        public IEnumerable<ProductDto> GetProducts([Service] IProductRepository repository) =>
            repository.GetAllProducts();

        public IEnumerable<ProductGroupDto> GetProductGroups([Service] IProductGroupRepository groupRepository) =>
            groupRepository.GetAllProductGroups();

        public IEnumerable<StorageDto> GetStorageCount([Service] IStorageRepository storageRepository) =>
            storageRepository.GetProductsCountOnStorage();
    }
}
