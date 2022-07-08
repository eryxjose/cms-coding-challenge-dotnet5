using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Articles;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Article, ArticleDto>();
                // .ForMember(d => d.Tags, o => o.MapFrom(s => s.Tags.Select(y => y).ToList()));
                
            
            // CreateMap<Article, ArticleDto>()
            //     .ForMember(d => d.Tags, o => o.MapFrom(x => x.Tags));

            CreateMap<Tag, TagDto>();

            // CreateMap<Article, Article>();

            // CreateMap<Article, ArticleDto>();
            //     // .ForMember(d => d.FullText, o => o.MapFrom(s => s.FullText))
            //     // .ForMember(d => d.Title, o => o.MapFrom(s => s.Title))
            //     // .ForMember(d => d.Tags, o => o.MapFrom(s => s.Tags));

            // CreateMap<Tag, TagDto>()
            //     .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
            //     .ForMember(d => d.Name, o => o.MapFrom(s => s.Name));
        }
    }
}