namespace GetRichOrDieTrying.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class GetRichDbContext : IdentityDbContext<User>
    {
        public GetRichDbContext(DbContextOptions<GetRichDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionGames> QuestionGames { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<QuestionGames>()
                .HasKey(qg => new { qg.QuestionId, qg.GameId });

            builder
                .Entity<User>()
                .HasMany(u => u.Games)
                .WithOne(g => g.User)
                .HasForeignKey(g => g.UserId);

            builder
                .Entity<Question>()
                .HasMany(q => q.PossibleAnswers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId);

            builder
                .Entity<Question>()
                .HasMany(q => q.Games)
                .WithOne(qg => qg.Question)
                .HasForeignKey(qu => qu.QuestionId);

            builder
                .Entity<Game>()
                .HasMany(g => g.Questions)
                .WithOne(qg => qg.Game)
                .HasForeignKey(qg => qg.GameId);

            base.OnModelCreating(builder);
        }
    }
}
