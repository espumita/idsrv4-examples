using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4.Test;

namespace MyIdentityServer {
    public class TestUsers {

        public static List<TestUser> Users = new List<TestUser> {
            new TestUser {
                SubjectId = "B0339CB4-AC7E-4D7A-A265-D327DC3D7433",
                Username = "Bob",
                Password = "1234",
                Claims = new List<Claim> {
                    new Claim("nick_name", "BobDogsLover25"),
                    new Claim("favorite_Pet", "Dog")
                }
            },
            new TestUser {
                SubjectId = "F2FD22F3-90B6-42D7-8325-69B134E4200F",
                Username = "Mike",
                Password = "qwer",
                Claims = new List<Claim> {
                    new Claim("nick_name", "TheRealMike"),
                    new Claim("favorite_Pet", "All")
                }
            }
        };

    }
}