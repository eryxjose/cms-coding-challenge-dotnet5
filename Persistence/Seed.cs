using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Articles.Any()) return;
            
            var tag1 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "tag1"
            };
            var tag2 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "tag2"
            };
            var tag3 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "tag3"
            };
            var tag4 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "tag4"
            };
            var tag5 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "tag5"
            };
            var tags = new List<Tag>
            {
                tag1, tag2, tag3, tag4, tag5
            };

            await context.Tags.AddRangeAsync(tags);
            await context.SaveChangesAsync();
            
            var article1 = new Article
            {
                Id = Guid.NewGuid(),
                Title = "Título do primeiro artigo",
                FullText = "Texto do primeiro artigo",
                Tags = new List<Tag>
                {
                    tag1, tag3
                }
            };
            var article2 = new Article
            {
                Id = Guid.NewGuid(),
                Title = "Título do segundo artigo",
                FullText = "Texto do segundo artigo",
                Tags = new List<Tag>
                {
                    tag1
                }
            };
            var article3 = new Article
            {
                Id = Guid.NewGuid(),
                Title = "Título do terceiro artigo",
                FullText = "Texto do terceiro artigo",
                Tags = new List<Tag>
                {
                    tag2, tag4
                }
            };
            var article4 = new Article
            {
                Id = Guid.NewGuid(),
                Title = "Título do quarto artigo",
                FullText = "Texto do quarto artigo",
                Tags = new List<Tag>
                {
                    tag3, tag5
                }
            };
            var articles = new List<Article>
            {
                article1, article2, article3, article4
            };

            await context.Articles.AddRangeAsync(articles);
            await context.SaveChangesAsync();
        }
    }
}