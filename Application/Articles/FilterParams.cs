using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Core;

namespace Application.Articles
{
    public class FilterParams : PagingParams
    {
        public string Tag { get; set; }
    }
}