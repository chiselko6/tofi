﻿using BLL.Services.Common.Price.ViewModels;
using BLL.Services.Credits.BankCredits.CreditTypes.ViewModels;
using BLL.Services.Model.ViewModels;
using BLL.Services.User.ViewModels;

namespace BLL.Services.Credits.CreditAccount.ViewModels
{
    public class CreditAccountViewModel : ModelViewModel
    {
        public string CreditAgreementNumber { get; set; }
        
        public string Description { get; set; }
        
        public UserViewModel User { get; set; }

        public CreditTypeViewModel CreditType { get; set; }
    }
}