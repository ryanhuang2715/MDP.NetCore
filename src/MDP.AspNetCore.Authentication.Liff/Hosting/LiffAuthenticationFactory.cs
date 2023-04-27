﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.AspNetCore.Authentication.Liff
{
    [MDP.Registration.Factory<WebApplicationBuilder, LiffAuthenticationSetting>("Authentication", "Liff")]
    public class LiffAuthenticationFactoryFactory
    {
        // Methods
        public void ConfigureService(WebApplicationBuilder webApplicationBuilder, LiffAuthenticationSetting authenticationSetting)
        {
            #region Contracts

            if (webApplicationBuilder == null) throw new ArgumentException($"{nameof(webApplicationBuilder)}=null");
            if (authenticationSetting == null) throw new ArgumentException($"{nameof(authenticationSetting)}=null");

            #endregion

            // AddLiffAuthentication
            webApplicationBuilder.Services.AddLiffAuthentication(authenticationSetting);
        }
    }
}