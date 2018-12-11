using MusicStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            MusicStoreContext context = HttpContext.RequestServices.GetService(typeof(MusicStore.Models.MusicStoreContext)) as MusicStoreContext;

            return View(context.GetAllAlbums());
        }

        public IActionResult Create()
        {
            //musicstorecontext context = httpcontext.requestservices.getservice(typeof(MusicStore.models.musicstorecontext)) as musicstorecontext;

            return View();
        }
    }
}