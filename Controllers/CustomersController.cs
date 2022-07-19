using CQRSArchitecture.Domain.Commands.Requests;
using CQRSArchitecture.Domain.Commands.Responses;
using CQRSArchitecture.Domain.Handlers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CQRSArchitecture.Controllers
{
    [ApiController]
    [Route("Customers")]
    public class CustomersController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
        )
        {
            return handler.Handle(command);
        }
    }
}
