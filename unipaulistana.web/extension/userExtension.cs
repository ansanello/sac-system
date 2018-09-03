namespace unipaulistana.web.extensions
{
    using System.Security.Claims;
    using System.Security.Principal;
    public static class UserExtended
    {
        public static string GetFullName(this IPrincipal user)
        {
            var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.Name);
            return claim == null ? null : claim.Value;
        }

        public static string GetAddress(this IPrincipal user)
        {
            var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.StreetAddress);
            return claim == null ? null : claim.Value;
        }

        public static string GetPicture(this IPrincipal user)
        {
            var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.UserData);
            return claim == null ? null : claim.Value;
        }
        
    }
}

/////////////////// MODO DE USO
/*

In my controller:

using XXX.CodeHelpers.Extended;

var claimAddress = User.GetAddress();
In my razor:

@using DinexWebSeller.CodeHelpers.Extended;

@User.GetFullName()

https://stackoverflow.com/questions/21404935/mvc-5-access-claims-identity-user-data

 */