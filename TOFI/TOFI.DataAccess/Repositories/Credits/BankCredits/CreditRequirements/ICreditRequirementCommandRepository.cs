﻿using DAL.Repositories.Model;
using DAL.Repositories.User;
using TOFI.TransferObjects.Credits.BankCredits.BankCredit.DataObjects;
using TOFI.TransferObjects.Credits.BankCredits.CreditRequirements.DataObjects;
using TOFI.TransferObjects.Employee.DataObjects;

namespace DAL.Repositories.Credits.BankCredits.CreditRequirements
{
    public interface ICreditRequirementCommandRepository : IModelCommandRepository<CreditRequirementDTO>
    {
    }
}