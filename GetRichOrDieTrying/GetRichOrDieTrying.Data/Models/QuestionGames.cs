namespace GetRichOrDieTrying.Data.Models
{
    public class QuestionGames
    {
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}
