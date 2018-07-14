using Module03Week01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module03Week01.Controllers
{
    public class PostsController : Controller
    {

		//public static List<Post> posts = new List<Post>();
		//public static int Id = 0;

        // GET: Posts
        public ActionResult Index()
        {
			Post post = new Post
			{
				ID = 1,
				UserID = 2,
				TimeOfPosting = DateTime.Parse("01/01/2018 12:00:00"),
				Message = "Hello!",
				IsSticky = true,
				Priority = 0,
				postType = PostType.Text
			};

            return View(post);
        }

		public ActionResult Details()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Post post)
		{
			if (post.Message == null)
				return HttpNotFound();
			else
			    return View("Details", post);
		}
	}
}