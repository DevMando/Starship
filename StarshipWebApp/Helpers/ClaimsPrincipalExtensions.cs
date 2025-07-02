using StarshipWebApp.Models;
using System.Security.Claims;

namespace StarshipWebApp.Helpers
{
    public static class ClaimsPrincipalExtensions
    {
        public static User ToAppUser(this ClaimsPrincipal user)
        {
            if (user.Identity is not { IsAuthenticated: true }) return new User();

            return new User
            {
                Name = user.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty,
                Email = user.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty,
                PictureUrl = user.FindFirst("picture")?.Value ?? string.Empty,
                GivenName = user.FindFirst(ClaimTypes.GivenName)?.Value ?? string.Empty,
                FamilyName = user.FindFirst(ClaimTypes.Surname)?.Value ?? string.Empty,
                NameIdentifier = user.FindFirst(ClaimTypes.NameIdentifier)?.Value
            };
        }
    }
}
