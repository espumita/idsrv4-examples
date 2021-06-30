using System.Collections.Generic;
using IdentityServer4.Models;

namespace MyIdentityServer {
    public static class Config {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[] {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[] {

            };

        public static IEnumerable<Client> Clients =>
            new Client[] {
                new Client {
                    ClientName = "Api Generic client",
                    ClientId = "my_api_client",
                    AllowedGrantTypes = new[] {
                        GrantType.AuthorizationCode
                    },
                    RequirePkce = false,
                    RedirectUris = new List<string> {
                        "https://localhost:44346/authorization-code-flow-redirect-ok"
                    },
                    AllowedScopes = {
                        IdentityServer4.IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServer4.IdentityServerConstants.StandardScopes.Profile
                    },
                    ClientSecrets = {
                        new Secret("myLittleSecret".Sha256())
                    }
                }
            };
    }
}