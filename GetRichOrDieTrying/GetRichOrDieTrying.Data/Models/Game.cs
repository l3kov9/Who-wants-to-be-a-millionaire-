namespace GetRichOrDieTrying.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<QuestionGames> Questions { get; set; } = new List<QuestionGames>();

        [Range(0,100000)]
        public int FinalSum { get; set; }
    }
}
