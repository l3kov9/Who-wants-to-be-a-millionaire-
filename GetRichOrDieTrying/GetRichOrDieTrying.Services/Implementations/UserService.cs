namespace GetRichOrDieTrying.Services.Implementations
{
    using Contracts;
    using Data;

    public class UserService : IUserService
    {
        private readonly GetRichDbContext db;

        public UserService(GetRichDbContext db)
        {
            this.db = db;
        }
    }
}
