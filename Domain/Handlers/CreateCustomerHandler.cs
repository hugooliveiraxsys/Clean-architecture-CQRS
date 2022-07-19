using CQRSArchitecture.Domain.Commands.Requests;
using CQRSArchitecture.Domain.Commands.Responses;
using CQRSArchitecture.Domain.Handlers.Interfaces;
using MediatR;

namespace CQRSArchitecture.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            CreateCustomerResponse response = new CreateCustomerResponse();
            response.Id = Guid.NewGuid();
            response.Name = request.Name;
            response.Email = request.Email;
            response.Date = DateTime.Now;

            return response;
        }
    }
}
