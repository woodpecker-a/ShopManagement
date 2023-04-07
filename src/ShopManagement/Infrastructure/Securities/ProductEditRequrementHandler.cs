using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Securities
{
    public class ProductEditRequrementHandler : AuthorizationHandler<ProductEditRequrement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ProductEditRequrement requrement)
        {
            if (context.User.HasClaim(x => x.Type == "CRUDProduct" && x.Value == "true")) context.Succeed(requrement);

            return Task.CompletedTask;
        }
    }
}
