using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FullText { get; set; }
        public IList<Tag> Tags { get; set; } = new List<Tag>();
    }
}