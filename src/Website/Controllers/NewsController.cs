namespace Website.Controllers
{
    using System.Web.Mvc;

    using BusinessLayer;

    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public ActionResult Index()
        {
            return View(this.newsService.GetNews());
        }
    }
}