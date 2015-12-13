using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchool.Models
{
    public class ArticleContext : IdentityDbContext<User>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Article>(e =>
            {
                //添加索引
                e.Index(x => x.Id);
                e.Index(x => x.Source);
            });

            builder.Entity<News>(e =>
            {
                //添加新闻索引
                e.Index(x => x.Id);
                e.Index(x => x.Datatime);

            });
        }
    }
}
