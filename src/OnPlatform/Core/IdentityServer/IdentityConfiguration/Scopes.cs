﻿using IdentityServer4.Models;

namespace IdentityServer.IdentityConfiguration
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("onShoppingApi.read", "Read Access to OnShopping Api"),
                new ApiScope("onShoppingApi.write", "Write Access to OnShopping Api"),
            };
        }
    }
}
