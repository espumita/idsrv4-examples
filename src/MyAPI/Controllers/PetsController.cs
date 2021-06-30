using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using MyAPI.Models;

namespace MyAPI.Controllers {
    [ApiController]
    [Route("api/pets")]
    public class PetsController : ControllerBase {

        private readonly ILogger<PetsController> logger;

        public PetsController(ILogger<PetsController> logger) {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pet> Get() {
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
