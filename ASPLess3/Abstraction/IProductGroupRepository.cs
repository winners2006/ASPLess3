using ASPLess3.Dto;
using ASPLess3.Models;

namespace ASPLess3.Abstraction
{
	public interface IProductGroupRepository
	{
		IEnumerable<ProductGroupDto> GetAllProductGroups();
		int AddProductGroup(ProductGroupDto productGroupDto);
		void DeleteProductGroup(int id);
	}
}
