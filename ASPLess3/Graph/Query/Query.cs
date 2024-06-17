using ASPLess3.Models;
using ASPLess3.Dto;
using ASPLess3.Abstraction;
using ASPLess3.Repository;

namespace ASPLess3.Graph.Query
{
	public class Query(IProductRepository productRepository)
	{

		public IEnumerable<ProductDto> GetProducts() => productRepository.GetAllProducts();


		public IEnumerable<ProductGroupDto> GetProductGroups([Service] ProductGroupRepository groupRepository) => 
			groupRepository.GetAllProductGroups();
		
	}
}
