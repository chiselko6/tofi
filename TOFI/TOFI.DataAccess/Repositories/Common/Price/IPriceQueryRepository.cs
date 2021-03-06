﻿using DAL.Repositories.Model;
using TOFI.TransferObjects.Common.Price.DataObjects;

namespace DAL.Repositories.Common.Price
{
    public interface IPriceQueryRepository: IModelQueryRepository<PriceDto>
    {
    }
}