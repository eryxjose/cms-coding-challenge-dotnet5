using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Persistence;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Application.Core;

namespace Application.Articles
{
    public class List
    {
        public class Query : IRequest<Result<PagedList<ArticleDto>>>
        {
            public FilterParams FilterParams { get; set; }
            
            public PagingParams PagingParams { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<PagedList<ArticleDto>>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
            }

            public async Task<Result<PagedList<ArticleDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var articles = _context.Articles.Include(o => o.Tags).AsQueryable();

                if (!String.IsNullOrEmpty(request.FilterParams.Tag))
                {
                    articles = articles.Where(o => o.Tags.Any(o => o.Name.ToLower() == request.FilterParams.Tag.ToLower()));
                }

                var resp = articles.Select(article => new ArticleDto
                {
                    Id = article.Id,
                    FullText = article.FullText,
                    Title = article.Title,
                    Tags = article.Tags.Select(x => new TagDto{ Name = x.Name, Id = x.Id}).ToList()
                });

                return Result<PagedList<ArticleDto>>.Success(
                    await PagedList<ArticleDto>.CreateAsync(
                        resp, request.PagingParams.PageNumber, request.PagingParams.PageSize));
            }
        }
    }
}