namespace GetRichOrDieTrying.Web.Areas.Admins.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AddQuestionViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Question text must be between 5 and 100 symbols")]
        public string Text { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Answer text must be between 5 and 100 symbols")]
        public string CorrectAnswer { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Answer text must be between 5 and 100 symbols")]
        public string FirstWrongAnswer { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Answer text must be between 5 and 100 symbols")]
        public string SecondWrongAnswer { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Answer text must be between 5 and 100 symbols")]
        public string ThirdWrongAnswer { get; set; }

        [Range(1,15)]
        public int QuestionNumber { get; set; }
    }
}
