﻿using BLL.Services.Auth;
using BLL.Services.Client.ViewModels;
using BLL.Services.User;
using DAL.Repositories.Client;
using TOFI.TransferObjects.Client.DataObjects;

namespace BLL.Services.Client
{
    public class ClientService : UserService<ClientDto, ClientViewModel>, IClientService
    {
        private readonly IClientQueryRepository _queryRepository;
        private readonly IClientCommandRepository _commandRepository;


        public ClientService(IClientQueryRepository queryRepository,
            IClientCommandRepository commandRepository, IAuthService authService)
            : base(queryRepository, commandRepository, authService)
        {
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
        }
    }
}