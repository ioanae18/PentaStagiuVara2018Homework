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

		public static List<Post> posts = new List<Post>();
		public static int Id = 0;

        // GET: Posts
        public ActionResult Index()
        {
			/*
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
			*/

			ViewBag.DT = DateTime.Now;
			return View(posts);
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

		[HttpGet]
		public ActionResult Delete(int id)
		{
			Post post = posts.Find(p => p.ID == id);

			if (post == null)
			{
				return HttpNotFound();
			}

			posts.Remove(post);
			return View(posts);
		}

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Post post = posts.Find(p => p.ID == id);
			posts.Remove(post);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Edit(int id)
		{
			Post post = posts.Find(u => u.ID == id);

			if (post == null)
			{
				return HttpNotFound();
			}

			return View(post);
		}

		[HttpPost]
		public ActionResult Edit(Post post)
		{
			Post findPost = posts.Find(p => p.ID == post.ID);
			List<Post> result = new List<Post>();

			foreach (Post p in posts)
			{
				if (!p.Equals(findPost)) result.Add(p); else result.Add(post);
			}

			posts = result;
			return RedirectToAction("Index");
		}
	}
}