using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace mysqlefcore
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new BloggingContext())
      {
        var blog = new Blog { Url = "http://sample.com" };
        db.Blogs.Add(blog);
        db.SaveChanges();
      }
    }
  }
}
