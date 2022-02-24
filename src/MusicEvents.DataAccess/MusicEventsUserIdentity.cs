using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MusicEvents.DataAccess;

public class MusicEventsUserIdentity : IdentityUser
{
    [StringLength(100)]
    public string FirstName { get; set; }

    [StringLength(100)]
    public string LastName { get; set; }

    public int Age { get; set; }

    // 1 = DNI
    // 2 = RUC (EMPRESAS)
    public int TypeDocument { get; set; }

    [StringLength(20)]
    public string DocumentNumber { get; set; }
}
