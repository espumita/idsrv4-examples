using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MyAPI.Models;

namespace MyAPI.Controllers {
    [ApiController]
    [Authorize]
    [Route("api/pets")]
    public class PetsController : ControllerBase {

        private readonly ILogger<PetsController> logger;

        public PetsController(ILogger<PetsController> logger) {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Pet>> Get() {
            
            var identityToken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.IdToken);

            Debug.WriteLine($"Identity token: {identityToken}");

            return new List<Pet> {
                new Pet {
                    Name = "Tigger",
                    Age = 5,
                    Type = PetType.Cat
                },
                new Pet {
                    Name = "Bailey",
                    Age = 8,
                    Type = PetType.Dog
                },
                new Pet {
                    Name = "Scruffy",
                    Age = 2,
                    Type = PetType.Bird
                }
            };
        }
    }

}
