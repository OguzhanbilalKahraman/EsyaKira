
using EsyaKira.Application.Features.CQRS.Queries.BannerQueries;
using EsyaKira.Application.Features.CQRS.Results.BannerResult;
using EsyaKira.Application.Interfaces;
using EsyaKira.Domain.Entities;

namespace EsyaKira.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        public readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerID = values.BannerID,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl
            };
        }
    }
}
