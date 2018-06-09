namespace GetRichOrDieTrying.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Answer text must be between 5 and 100 symbols")]
        public string Text { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
