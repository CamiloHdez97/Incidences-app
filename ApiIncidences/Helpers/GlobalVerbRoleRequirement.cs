using Microsoft.AspNetCore.Authorization;

namespace ApiIncidences.Helpers
{
    public class GlobalVerbRoleRequirement: IAuthorizationRequirement
{
    public bool IsAllowed(string role, string verb)
    {
        if(string.Equals("Admin", role, StringComparison.OrdinalIgnoreCase)) return true;
        if(string.Equals("Gerente", role, StringComparison.OrdinalIgnoreCase)) return true;
        if(string.Equals("Administrativo", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET",verb, StringComparison.OrdinalIgnoreCase)){};
        if(string.Equals("Trainer", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET",verb, StringComparison.OrdinalIgnoreCase)){};
        if(string.Equals("camper", role, StringComparison.OrdinalIgnoreCase) && string.Equals("GET",verb, StringComparison.OrdinalIgnoreCase)){
            return true;};
        
        return false;
    }
}
}