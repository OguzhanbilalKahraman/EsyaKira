﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsyaKira.Application.Features.Mediator.Queries.TestimonialQueries;
using EsyaKira.Application.Features.Mediator.Results.FeatureResults;
using EsyaKira.Application.Features.Mediator.Results.TestimonialResults;
using EsyaKira.Application.Interfaces;
using EsyaKira.Domain.Entities;

namespace EsyaKira.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetServiceQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Name = x.Name,
                TestimonialID = x.TestimonialID,
                ImageUrl = x.ImageUrl,
                Title = x.Title,
                Comment = x.Comment
            }).ToList();
        }
    }
}
