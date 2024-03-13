using Microsoft.AspNetCore.Identity;

namespace API.Data;

public class CustomIdentityUser : IdentityUser
{
    [ProtectedPersonalData] 
    public string FirstName { get; set; }
    
    [ProtectedPersonalData] 
    public char MiddleInitial { get; set; }
    
    [ProtectedPersonalData] 
    public string LastName { get; set; }
    
    [ProtectedPersonalData]
    public DateTime BirthDate { get; set; }
    
    [ProtectedPersonalData]
    public Address Address { get; set; }
}