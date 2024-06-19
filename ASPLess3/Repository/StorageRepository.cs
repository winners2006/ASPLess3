using ASPLess3.Abstraction;
using ASPLess3.Data;
using ASPLess3.Dto;
using ASPLess3.Models;
using AutoMapper;

namespace ASPLess3.Repository
{
    public class StorageRepository : IStorageRepository
    {
        StorageContext storageContext;
        private readonly IMapper _mapper;
        public StorageRepository(StorageContext storageContext, IMapper mapper)
        {
            this.storageContext = storageContext;
            this._mapper = mapper;
        }
        public int AddProductOnStorage(StorageDto storageDto)
        {
            var storage = _mapper.Map<Storage>(storageDto);
            storageContext.Storages.Add(storage);
            storageContext.SaveChanges();
            return storage.Id;
        }

        public IEnumerable<StorageDto> GetProductsCountOnStorage()
        {
            return storageContext.Storages.Select(_mapper.Map<StorageDto>).ToList();
        }
    }
}
