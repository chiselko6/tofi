﻿
using AutoMapper.Configuration;
using BLL.Services.User.ViewModels;
using TOFI.Web.Auth;

namespace TOFI.Web.Mapping
{
    public static class MapperConfig
    {
        public static void LoadConfig(ref MapperConfigurationExpression config)
        {
            BLL.Mapping.MapperConfig.LoadConfig(ref config);

            config.CreateMap<AuthUser, RegisterViewModel>();
            config.CreateMap<RegisterViewModel, AuthUser>();
        }
    }
}