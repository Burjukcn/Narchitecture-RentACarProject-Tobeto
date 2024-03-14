

using Application.Features.Brands.Dtos;
using Core.Applicantion.Pipelines.Logging;
using Core.Applicantion.Pipelines.Performans;
using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>,IIntervalRequest,ILoggableRequest
{
    public string Name { get; set; }

    public int Interval => 1;
}