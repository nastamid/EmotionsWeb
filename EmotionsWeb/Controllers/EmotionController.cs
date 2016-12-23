using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmotionsWeb.Models;

namespace EmotionsWeb.Controllers
{
    public class EmotionController : Controller
    {
        EmotionsDBDataContext db = new EmotionsDBDataContext();
        // GET: Emotion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Map()
        {
            //Map
            var posts = db.Posts.OrderByDescending(x => x.Id).ToList();
            return View(posts);
        }
    }
}