using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mysqlefcore
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new BloggingContext())
      {
          var blogs = db.Blogs.ToList().Where(b => b.Rating > 3);
          foreach (Blog post in blogs) {
            Console.WriteLine(post.Url);
          }

      }

      // using (var db = new BloggingContext())
      // {
      //   var blog = new Blog { Url = "http://sample.com" };
      //   db.Blogs.Add(blog);
      //   db.SaveChanges();
      // }
    }
  }
}
