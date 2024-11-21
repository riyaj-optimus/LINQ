using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
   

    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
    }

    class eleven
    {
        //static void Main()
        //{
        //    // Sample data for articles
        //    var articles = new List<Article>
        //{
        //    new Article { ArticleID = 1, Title = "Article 1", DatePublished = DateTime.Now.AddDays(-10) },
        //    new Article { ArticleID = 2, Title = "Article 2", DatePublished = DateTime.Now.AddDays(-9) },
        //    new Article { ArticleID = 3, Title = "Article 3", DatePublished = DateTime.Now.AddDays(-8) },
        //    new Article { ArticleID = 4, Title = "Article 4", DatePublished = DateTime.Now.AddDays(-7) },
        //    new Article { ArticleID = 5, Title = "Article 5", DatePublished = DateTime.Now.AddDays(-6) },
        //    new Article { ArticleID = 6, Title = "Article 6", DatePublished = DateTime.Now.AddDays(-5) },
        //    new Article { ArticleID = 7, Title = "Article 7", DatePublished = DateTime.Now.AddDays(-4) },
        //    new Article { ArticleID = 8, Title = "Article 8", DatePublished = DateTime.Now.AddDays(-3) },
        //    new Article { ArticleID = 9, Title = "Article 9", DatePublished = DateTime.Now.AddDays(-2) },
        //    new Article { ArticleID = 10, Title = "Article 10", DatePublished = DateTime.Now.AddDays(-1) },
        //    new Article { ArticleID = 11, Title = "Article 11", DatePublished = DateTime.Now }
        //};

        //    var res = articles.Take(10);
        //    //this is the general 

        //    int pagenum = 2;//we want the 2nd 10 articles
        //    int pageSize = 10;

        //    var resi =articles.Skip((pagenum-1)*pageSize).Take(pageSize);

        //    foreach (var a in resi)
        //    {
        //        Console.WriteLine(a.ArticleID + "  " + a.Title);
        //    }


        //}

       
    }

}
