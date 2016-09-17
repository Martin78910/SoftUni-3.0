using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1ExtractUsers();
        }

        private static void Problem1ExtractUsers()
        {
            //            var db = new BlogDbContext();
            //            foreach (var user in db.Users)
            //                Console.WriteLine(user.UserName);
            //        }
            //    }
            //}

            //            Problem2QueryData();
            //        }

            //        private static void Problem2QueryData()
            //        {
            //var db = new BlogDbContext();
            //var posts = db.Posts.Select(p => new
            //{
            //    p.Id,
            //    p.Title,
            //    Comments = p.Comments.Count(),
            //    Tags = p.Tags.Count()
            //});
            //Console.WriteLine("SQL query:\n{0}\n", posts);
            //foreach (var p in posts)
            //    Console.WriteLine($"{p.Id} {p.Title} ({p.Comments} comments, {p.Tags} tags)");
            //        }
            //    }
            //}

            //var db = new BlogDbContext();
            //var post = new Post()
            //{
            //    Title = "New Title",
            //    Body = "New Post Body",
            //    Date = DateTime.Now
            //};
            //db.Posts.Add(post);
            //db.SaveChanges();
            //Console.WriteLine("Post #{0} created.", post.Id);

            //            var db = new BlogDbContext();
            //            var post = new Post()
            //            {
            //                Title = "New Post Title",
            //                Date = DateTime.Now,
            //                Body = "This post have comments and tags",
            //                User = db.Users.First(),
            //                Comments = new Comment[] {
            //new Comment() { Text = "Comment 1", Date = DateTime.Now },
            //new Comment() { Text = "Comment 2", Date = DateTime.Now,
            //  User = db.Users.First() } },
            //                Tags = db.Tags.Take(3).ToList()
            //            };
            //            db.Posts.Add(post);
            //            db.SaveChanges();

            //var db = new BlogDbContext();
            //var user = db.Users
            //    .Where(u => u.UserName == "Mariika")
            //    .First();
            //user.PasswordHash =
            //  Guid.NewGuid().ToByteArray();
            //db.SaveChanges();
            //Console.WriteLine(
            //    "User #{0} ({1}) has a new random password.",
            //    user.Id, user.UserName);

            //var db = new BlogDbContext();
            //var lastPost = db.Posts
            //  .OrderByDescending(p => p.Id)
            //  .First();
            //db.Comments.RemoveRange(
            //  lastPost.Comments);
            //lastPost.Tags.Clear();
            //db.Posts.Remove(lastPost);
            //db.SaveChanges();
            //Console.WriteLine(
            //  $"Deleted post #{lastPost.Id}");


            var db = new BlogDbContext();
            var startDate = new DateTime(2016, 05, 19);
            var endDate = new DateTime(2016, 06, 14);
            var posts = db.Database.SqlQuery<PostData>(
              @"SELECT ID, Title, Date FROM Posts
WHERE CONVERT(date, Date)
BETWEEN {0} AND {1}
ORDER BY Date",
              startDate, endDate);
            foreach (var p in posts)
                Console.WriteLine(
                  $"#{p.ID}: {p.Title} ({p.Date})");

        }
    }

    internal class PostData
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }


}
