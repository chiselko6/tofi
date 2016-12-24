﻿using System.Collections.Generic;
using BLL.Services.Credits.BankCredits.CreditConditions.ViewModels;
using BLL.Services.Credits.BankCredits.CreditRequirements.ViewModels;
using BLL.Services.Model.ViewModels;

namespace BLL.Services.Credits.BankCredits.CreditTypes.ViewModels
{
    public class CreditTypeViewModel : ModelViewModel
    {
        public List<CreditConditionViewModel> CreditConditions { get; set; }

        public List<CreditRequirementViewModel> CreditRequirement { get; set; }

        public string Description { get; set; }

        public double InterestRate { get; set; }
    }
}