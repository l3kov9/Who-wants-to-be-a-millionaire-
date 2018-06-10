namespace GetRichOrDieTrying.Services.Models
{
    using Data.Enums;
    using System.Collections.Generic;

    public class QuestionServiceModel
    {
        public string Text { get; set; }

        public QuestionDifficuly QuestionDifficuly { get; set; }

        public IEnumerable<AnswerServiceModel> PossibleAnswers { get; set; } = new List<AnswerServiceModel>(4);
    }
}
