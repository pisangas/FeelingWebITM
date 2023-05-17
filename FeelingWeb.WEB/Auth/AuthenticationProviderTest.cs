using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace FeelingWeb.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(1000);
            var anonimous = new ClaimsIdentity();
            
            var EduardoUser = new ClaimsIdentity(new List<Claim>{
                new Claim("FirstName", "Eduardo"),
                new Claim("LastName", "Gil"),
                new Claim(ClaimTypes.Name, "pisangas@gmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            }, authenticationType: "test");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(EduardoUser)));
        }

    }
}
