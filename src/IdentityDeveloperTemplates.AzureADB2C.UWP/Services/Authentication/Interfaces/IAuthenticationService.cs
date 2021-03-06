﻿using System.Threading.Tasks;

namespace IdentityDeveloperTemplates.AzureADB2C.UWP.Services.Authentication.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticationData> Authenticate();
    }
}
