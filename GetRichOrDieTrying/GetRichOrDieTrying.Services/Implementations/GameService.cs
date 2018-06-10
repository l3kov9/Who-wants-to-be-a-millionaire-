namespace GetRichOrDieTrying.Services.Implementations
{
    using Contracts;
    using Data;
    using GetRichOrDieTrying.Data.Enums;
    using GetRichOrDieTrying.Services.Models;
    using System;
    using System.Linq;

    public class GameService : IGameService
    {
        private readonly GetRichDbContext db;

        public GameService(GetRichDbContext db)
        {
            this.db = db;
        }

        public QuestionServiceModel GetQuestionByDifficulty(QuestionDifficuly difficulty)
        {
            var question = this.db
                .Questions
                .Where(q=>q.QuestionDifficuly == difficulty)
                .Select(q=>new QuestionServiceModel
                {
                    Text = q.Text,
                    PossibleAnswers = q.PossibleAnswers.Select(pa=>new AnswerServiceModel()
                    {
                        Text = pa.Text,
                        IsCorrectAnswer = pa.IsCorrectAnswer
                    }),
                    QuestionDifficuly = difficulty
                })
                .OrderBy(q => Guid.NewGuid())
                .FirstOrDefault();

            return question;
        }
    }
}
