﻿using ASPLess3.Dto;

namespace ASPLess3.Abstraction
{
    public interface IStorageRepository
    {
        IEnumerable<StorageDto> GetProductsCountOnStorage();
        int AddProductOnStorage(StorageDto storageDto);
    }
}
