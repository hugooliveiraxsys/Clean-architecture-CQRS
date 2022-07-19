using CQRSArchitecture.Domain.Commands.Requests;
using CQRSArchitecture.Domain.Commands.Responses;
using CQRSArchitecture.Domain.Handlers.Interfaces;

namespace CQRSArchitecture.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request) {

            CreateCustomerResponse response = new CreateCustomerResponse();
            response.Id = Guid.NewGuid();
            response.Name = request.Name;
            response.Email = request.Email;
            response.Date = DateTime.Now;

            return response;
        }

    }
}
