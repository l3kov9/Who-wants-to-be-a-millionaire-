namespace GetRichOrDieTrying.Web.Areas.Admins.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area("Admins")]
    [Authorize(Roles = "Administrator")]
    public class BaseAdminController : Controller
    {
    }
}
