using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Articles
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FullText { get; set; }
        public IList<TagDto> Tags { get; set; } = new List<TagDto>();
    }
}