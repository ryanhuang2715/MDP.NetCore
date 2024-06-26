﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace System.Security.Claims
{
    public static partial class ClaimsPrincipalExtensions
    {
        // Methods
        public static string GetClaimValue(this ClaimsPrincipal principal, string claimType)
        {
            #region Contracts

            if (string.IsNullOrEmpty(claimType) == true) throw new ArgumentException(nameof(claimType));

            #endregion

            // Return
            return principal.Identity?.GetClaimValue(claimType);
        }

        public static List<string> GetAllClaimValue(this ClaimsPrincipal principal, string claimType)
        {
            #region Contracts

            if (string.IsNullOrEmpty(claimType) == true) throw new ArgumentException(nameof(claimType));

            #endregion

            // Return
            return principal.Identity?.GetAllClaimValue(claimType);
        }


        public static string GetClaimValue(this IIdentity identity, string claimType)
        {
            #region Contracts

            if (string.IsNullOrEmpty(claimType) == true) throw new ArgumentException(nameof(claimType));

            #endregion

            // Return
            return (identity as ClaimsIdentity)?.FindFirst(claimType)?.Value;
        }

        public static List<string> GetAllClaimValue(this IIdentity identity, string claimType)
        {
            #region Contracts

            if (string.IsNullOrEmpty(claimType) == true) throw new ArgumentException(nameof(claimType));

            #endregion

            // Return
            return (identity as ClaimsIdentity)?.FindAll(claimType).Select(o => o.Value).ToList();
        }
    }
}