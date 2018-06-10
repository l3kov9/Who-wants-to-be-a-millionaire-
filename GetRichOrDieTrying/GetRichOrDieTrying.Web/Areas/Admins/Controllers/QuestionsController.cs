namespace GetRichOrDieTrying.Web.Areas.Admins.Controllers
{
    using GetRichOrDieTrying.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services.Contracts;
    using System;

    public class QuestionsController : BaseAdminController
    {
        private readonly IAdminService admins;

        public QuestionsController(IAdminService admins)
        {
            this.admins = admins;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddQuestionViewModel question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
            }

            var success = this.admins.SaveQuestion(question.Text, question.CorrectAnswer, question.FirstWrongAnswer, question.SecondWrongAnswer,
                question.ThirdWrongAnswer, question.QuestionNumber);

            if (!success)
            {
                this.TempData.AddErrorMessage("Your question adding was unsuccessfull");
            }

            this.TempData.AddSuccessMessage("You've successfully added question to the game");

            return RedirectToAction(nameof(Add));
        }
    }
}
