﻿using Abp.AutoMapper;
using BoilerPlate.Authentication.External;

namespace BoilerPlate.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
