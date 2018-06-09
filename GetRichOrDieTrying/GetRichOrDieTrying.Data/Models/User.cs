namespace GetRichOrDieTrying.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public IEnumerable<Game> Games { get; set; } = new List<Game>();
    }
}
