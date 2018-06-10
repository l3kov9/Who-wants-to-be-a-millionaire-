namespace GetRichOrDieTrying.Web.Areas.Games.Controllers
{
    using Data.Enums;
    using Microsoft.AspNetCore.Mvc;
    using Services.Contracts;

    public class HomeController : BaseGameController
    {
        private readonly IUserService users;
        private readonly IGameService games;

        public HomeController(IUserService users, IGameService games)
        {
            this.users = users;
            this.games = games;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Play(int id = 1)
        {
            var difficult = QuestionDifficuly.One;

            switch (id)
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
                    break;
            }

            var question = this.games.GetQuestionByDifficulty(difficult);

            return View(question);
        }
    }
}
