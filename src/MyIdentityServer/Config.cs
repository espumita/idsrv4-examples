using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace MyIdentityServer {
    public static class Config {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[] {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiResource> ApiResource =>
            new ApiResource[] {

            };

        public static IEnumerable<Client> Clients =>
            new Client[] {
                new Client {
                    ClientName = "Api Generic client for Authorization Code Flow",
                    ClientId = "my_api_authorization_code_client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = false,
                    RedirectUris = new List<string> {
                        "https://localhost:44346/authorization-code-flow-redirect-ok"
                    },
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                    },
                    ClientSecrets = {
                        new Secret("myLittleSecret".Sha256())
                    },
                },
                new Client {
                    ClientName = "Api Generic client for Authorization Code Flow with PKCE",
                    ClientId = "my_api_pkce_authorization_code_client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RedirectUris = new List<string> {
                        "https://localhost:44346/authorization-code-flow-redirect-ok"
                    },
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                    },
                    ClientSecrets = {
                        new Secret("myLittleSecret".Sha256())
                    }
                }

            };

    }
}