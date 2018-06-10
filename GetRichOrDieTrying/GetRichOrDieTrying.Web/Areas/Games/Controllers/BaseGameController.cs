namespace GetRichOrDieTrying.Web.Areas.Games.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area("Games")]
    [Authorize]
    public class BaseGameController : Controller
    {
    }
}
