using Application.Features.Cars.Models;
using Application.Request;
using Core.Persistence.Dynamic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetListDynamic
{
    public class GetListCarDynamicQuery : IRequest<CarListModel>
    {
        public PageRequest PageRequest { get; set; }
        public Dynamic Dynamic { get; set; }
    }
}
