using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using LegendaryBlog.Models;
namespace LegendaryBlog.Controllers
{
    public class PostsController : Controller
    {
        private BlogModel model = new BlogModel();
        private const int PostsPerPage = 2;
        public ActionResult Index(int? id)
        {
            int pageNumber = id ?? 0;
            IEnumerable<Post> posts = (from post in model.Posts
                                      where post.DateTime < DateTime.Now
                                      orderby post.DateTime descending
                                      select post).Skip(pageNumber*PostsPerPage).Take(PostsPerPage+1);
            ViewBag.IsPreviousLinkVisible = pageNumber > 0;
            ViewBag.IsNextLinkVisible = posts.Count() > PostsPerPage;
            ViewBag.PageNumber = pageNumber;
            ViewBag.IsAdmin = IsAdmin;

            return View(posts.Take(PostsPerPage));
        }
        public ActionResult Details(int id)
        {
            Post post = GetPost(id);
            ViewBag.IsAdmin = IsAdmin;
            return View(post);
        }
        [ValidateInput(false)]
        public ActionResult Comment(int id,string sendID,string body)
        {
            Post post = GetPost(id);
            Comment comment = new Comment();
            comment.Post = post;
            comment.DateTime = DateTime.Now;
            comment.SendID =Convert.ToInt32(sendID);
            comment.Body = body;
            model.Comments.Add(comment);
            model.SaveChanges();
            return RedirectToAction("Details",new { id=id});
        }
        public ActionResult Tags(string id)
        {
            Tag tag = GetTag(id);
            ViewBag.IsAdmin = IsAdmin;
            return View("~Posts/Index,",tag.Posts);
        }


        [ValidateInput(false)]
        public ActionResult Update(int? id,string title,string body,DateTime dateTime,string tags)
        {
            Post post = GetPost(id);
            post.Title = title;
            post.Body = body;
            post.DateTime = dateTime;
            post.Tags.Clear();
            tags = tags ?? string.Empty;
            string[] tagNames = tags.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            foreach (string tagName in tagNames)
            {
                post.Tags.Add(GetTag(tagName));
            }
            if (!id.HasValue)
            {
                model.Posts.Add(post);
               // model.AddToPosts(post);
            }
            model.SaveChanges();
            return RedirectToAction("Details",new { id = post.Id});
        }
        public ActionResult Delete(int id)
        {
            if (IsAdmin)
            {
                Post post = GetPost(id);
                model.Posts.Remove(post);
                model.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteComment(int id)
        {
            if (IsAdmin)
            {
                Comment comment = model.Comments.Where(x => x.Id == id).First();
                model.Comments.Remove(comment);
                model.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        private Tag GetTag(string tagName)
        {
            return model.Tags.Where(x=>x.Name==tagName).FirstOrDefault()??new Tag() { Name=tagName};
        }
        private Post GetPost(int? id)
        {
            return id.HasValue ? model.Posts.Where(x=>x.Id==id).First():new Post() { Id=-1};
        }
        public ActionResult Edit(int? id)
        {
            Post post = GetPost(id);
            StringBuilder tagList = new StringBuilder();
            foreach (Tag tag in post.Tags)
            {
                tagList.AppendFormat("{0}",tag.Name);

            }
            ViewBag.Tags = tagList.ToString();
            return View(post);
        }
        public bool IsAdmin { get { return true /*return Session["IsAdmin"] != null && (bool)Session["IsAdmin"]*/; } }
    }
}