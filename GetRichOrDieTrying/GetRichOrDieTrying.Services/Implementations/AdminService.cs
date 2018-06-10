namespace GetRichOrDieTrying.Services.Implementations
{
    using Contracts;
    using Data;
    using Data.Models;
    using GetRichOrDieTrying.Data.Enums;
    using System.Collections.Generic;

    public class AdminService : IAdminService
    {
        private readonly GetRichDbContext db;

        public AdminService(GetRichDbContext db)
        {
            this.db = db;
        }

        public bool SaveQuestion(string text,
            string correctAnswer,
            string firstWrongAnswer,
            string secondWrongAnswer,
            string thirdWrongAnswer,
            int questionNumber)
        {
            var difficult = QuestionDifficuly.One;

            switch (questionNumber)
            {
                case 1:
                    difficult = QuestionDifficuly.One;
                    break;
                case 2:
                    difficult = QuestionDifficuly.Two;
                    break;
                case 3:
                    difficult = QuestionDifficuly.Three;
                    break;
                case 4:
                    difficult = QuestionDifficuly.Four;
                    break;
                case 5:
                    difficult = QuestionDifficuly.Five;
                    break;
                case 6:
                    difficult = QuestionDifficuly.Six;
                    break;
                case 7:
                    difficult = QuestionDifficuly.Seven;
                    break;
                case 8:
                    difficult = QuestionDifficuly.Eight;
                    break;
                case 9:
                    difficult = QuestionDifficuly.Nine;
                    break;
                case 10:
                    difficult = QuestionDifficuly.Ten;
                    break;
                case 11:
                    difficult = QuestionDifficuly.Eleven;
                    break;
                case 12:
                    difficult = QuestionDifficuly.Twelve;
                    break;
                case 13:
                    difficult = QuestionDifficuly.Thirteen;
                    break;
                case 14:
                    difficult = QuestionDifficuly.Fourteen;
                    break;
                case 15:
                    difficult = QuestionDifficuly.Fifteen;
                    break;
                default:
                    return false;
            }

            var question = new Question()
            {
                Text = text,
                PossibleAnswers = new List<Answer>()
                {
                    new Answer()
                    {
                        Text = correctAnswer,
                        IsCorrectAnswer = true,
                    },
                    new Answer()
                    {
                        Text = firstWrongAnswer
                    },
                    new Answer()
                    {
                        Text = secondWrongAnswer
                    },
                    new Answer()
                    {
                        Text = thirdWrongAnswer
                    }
                },
                QuestionDifficuly = difficult
            };

            this.db.Questions.Add(question);
            this.db.SaveChanges();

            return true;
        }
    }
}
