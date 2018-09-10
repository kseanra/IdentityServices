using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServices.Config
{
    public static class ApiResources
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("GmailAPI", "Gmail API"),
                new ApiResource("MyAPI", "My API")
            };
        }
    }
}
