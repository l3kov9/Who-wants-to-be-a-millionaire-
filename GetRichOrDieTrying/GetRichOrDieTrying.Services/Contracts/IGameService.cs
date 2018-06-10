namespace GetRichOrDieTrying.Services.Contracts
{
    using Data.Enums;
    using Models;

    public interface IGameService
    {
        QuestionServiceModel GetQuestionByDifficulty(QuestionDifficuly difficulty);
    }
}
