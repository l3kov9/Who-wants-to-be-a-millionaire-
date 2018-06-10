namespace GetRichOrDieTrying.Services.Contracts
{
    public interface IAdminService
    {
        bool SaveQuestion(string text,
            string correctAnswer,
            string firstWrongAnswer,
            string secondWrongAnswer,
            string thirdWrongAnswer,
            int questionNumber);
    }
}
