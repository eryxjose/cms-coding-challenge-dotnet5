using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Articles;
using Application.Core;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class ArticlesController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetArticles([FromQuery] FilterParams param, [FromQuery] PagingParams pagingParams)
        {
            return HandleResult(await Mediator.Send(new List.Query { FilterParams = param, PagingParams = pagingParams }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }
    }
}