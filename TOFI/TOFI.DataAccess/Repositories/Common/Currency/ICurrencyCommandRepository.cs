﻿using DAL.Repositories.Model;
using TOFI.TransferObjects.Common.DataObjects;

namespace DAL.Repositories.Common.Currency
{
    public interface ICurrencyCommandRepository: IModelCommandRepository<CurrencyDto>
    {
    }
}