using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsyaKira.Application.Features.Mediator.Results.ProductPricingResults;

namespace EsyaKira.Application.Features.Mediator.Queries.ProductPricingQueries
{
	public class GetProductPricingWithTimePeriodQuery : IRequest<List<GetProductPricingWithTimePeriodQueryResult>>
	{
	}
}
