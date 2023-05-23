using Application.Security.Entity;

namespace Application.Security.IJsonWebToken;

public interface IJwtFactory
{
    AppUserToken GetJwt(AppUser appUser);
}