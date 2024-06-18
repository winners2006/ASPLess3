using ASPLess3.Abstraction;
using ASPLess3.Dto;

namespace ASPLess3.Graph.Mutation
{
	public class Mutation
	{
		public int AddProduct([Service] IProductRepository productRepository, ProductDto productDto) =>
			productRepository.AddProduct(productDto);

		public int AddProductGroup([Service] IProductGroupRepository groupRepository, ProductGroupDto productGroupDto) =>
			groupRepository.AddProductGroup(productGroupDto);
	}
}
