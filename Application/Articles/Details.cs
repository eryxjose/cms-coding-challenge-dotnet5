using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.Articles
{
    public class Details
    {
        public class Query : IRequest<Result<ArticleDto>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<ArticleDto>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<ArticleDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var article = await _context.Articles.Include(o => o.Tags).FirstOrDefaultAsync(o => o.Id == request.Id);
                return Result<ArticleDto>.Success(_mapper.Map<ArticleDto>(article));
            }
        }
    }
}