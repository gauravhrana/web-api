﻿using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace SocialNetwork.OAuth.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> GetScopes()
        {
            return new[]
            {
                StandardScopes.OpenId,
                StandardScopes.Profile,
                StandardScopes.OfflineAccess,
                new Scope
                {
                    Name = "read",
                    DisplayName = "Read data",
                    Type = ScopeType.Resource,
                    Emphasize = false,
                    AllowUnrestrictedIntrospection = true,
                    ScopeSecrets = new List<Secret> { new Secret("secret".Sha256()) }
                },
            };
        }
    }
}