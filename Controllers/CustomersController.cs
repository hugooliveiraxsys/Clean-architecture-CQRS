using CQRSArchitecture.Domain.Commands.Requests;
using CQRSArchitecture.Domain.Commands.Responses;
using CQRSArchitecture.Domain.Handlers.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSArchitecture.Controllers
{
    [ApiController]
    [Route("Customers")]
    public class CustomersController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command  
        )
        {
            return mediator.Send(command);
        }
    }
}
