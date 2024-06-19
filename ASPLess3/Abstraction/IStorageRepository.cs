namespace ASPLess3.Abstraction
{
	public class IStorageRepository
	{
		IEnumerable<StorageDto> GetAllStorages();
		int AddStorage(StorageDto storageDto);
		void UpdateStorageCount(int storageId, int count);
		void DeleteStorage(int id);
	}
}
