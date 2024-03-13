using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

/*
 * https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-8.0#the-identity-model
 * https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-8.0#entity-type-relationships
 *
 * IdentityDbContext contains the following types:
 *      1. User - Represents the user
 *      2. Role - Represents the role
 *      3. UserClaim - Represents a claim that a user possesses
 *      4. UserToken - Represents an authentication token for a user
 *      5. UserLogin - Associates a user with a login
 *      6. RoleClaim - Represents a claim that's granted to all users within a role.
 *      7. UserRole - A join entity that associates users and roles.
 *
 * Here are how the entity types are related:
 *      Each 'User' can have many 'UserClaims'.
 *      Each 'User' can have many 'UserLogins'.
 *      Each 'User' can have many 'UserTokens'.
 *      Each 'Role' can have many associated 'RoleClaims'.
 *      Each 'User' can have many associated 'Roles', and each 'Role' can be associated with many Users
 *           This is a many-to-many relationship that requires a join table in the database
 *           The join table is represented by the 'UserRole' entity type
 * 
 */
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<CustomIdentityUser>(options);
    