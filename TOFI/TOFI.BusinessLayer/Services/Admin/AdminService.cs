﻿using BLL.Services.Admin.ViewModels;
using BLL.Services.Auth;
using BLL.Services.User;
using DAL.Repositories.Admin;
using TOFI.TransferObjects.Admin.DataObjects;

namespace BLL.Services.Admin
{
    public class AdminService : UserService<AdminDto, AdminViewModel>, IAdminService
    {
        private readonly IAdminQueryRepository _queryRepository;
        private readonly IAdminCommandRepository _commandRepository;


        public AdminService(IAdminQueryRepository queryRepository,
            IAdminCommandRepository commandRepository, IAuthService authService)
            : base(queryRepository, commandRepository, authService)
        {
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
        }
    }
}