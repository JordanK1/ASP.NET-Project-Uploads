using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyBlogger__ASP.NET_Sec._2_Project_.Models;

namespace DailyBlogger__ASP.NET_Sec._2_Project_.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }
        
        public IActionResult List()//Lists out all the created blog posts.
        {
            IEnumerable<BlogPost> posts = _context.blogPost.ToList<BlogPost>();
            return View(posts);
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()//Makes a new blog post.
        {
            BlogPost blogPost = new BlogPost();

            return View(blogPost);
        }

        [HttpPost]//Designating this action should only use HttpPost, not HttpGet
        [ValidateAntiForgeryToken]//Security measure to ensure the POST is coming from the authorized user and not another source.
        public IActionResult Create([Bind("blogTitle, content, blogDate")] BlogPost blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                _context.SaveChanges();
                return RedirectToAction(nameof(List));//Returns the user to the list page of the blog after creating a new entry.
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            BlogPost blogPost = _context.blogPost.Find(id);
            return View(blogPost);
        }

        public IActionResult Edit(int id)
        {
            BlogPost blogPost = _context.blogPost.Find(id);
            return View(blogPost);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([Bind("blogTitle, content, blogDate,id")] BlogPost blog)
        {
            if (ModelState.IsValid)
            {
                _context.Update(blog);
                _context.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            return View(blog);
        }

        public IActionResult Delete([Bind("id")] int id)
        {
            BlogPost blogPost = _context.blogPost.Find(id);
            _context.Remove(blogPost);
            _context.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
