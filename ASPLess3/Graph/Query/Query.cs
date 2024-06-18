using ASPLess3.Abstraction;
using ASPLess3.Dto;

namespace ASPLess3.Graph.Query
{
	public class Query
	{
		public IEnumerable<ProductDto> GetProducts([Service] IProductRepository productRepository) =>
			productRepository.GetAllProducts();

		public IEnumerable<ProductGroupDto> GetProductGroups([Service] IProductGroupRepository groupRepository) =>
			groupRepository.GetAllProductGroups();
	}
}
