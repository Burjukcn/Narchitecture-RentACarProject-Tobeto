using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.WebAPI.Controllers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand command)
        {
            return Created("", await Mediator.Send(command));
        }
    }
}