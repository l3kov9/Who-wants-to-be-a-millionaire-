namespace GetRichOrDieTrying.Data.Models
{
    using Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Question text must be between 5 and 100 symbols")]
        public string Text { get; set; }

        public QuestionDifficuly QuestionDifficuly { get; set; }

        public IEnumerable<Answer> PossibleAnswers { get; set; } = new List<Answer>(4);

        public IEnumerable<QuestionGames> Games { get; set; } = new List<QuestionGames>();
    }
}
