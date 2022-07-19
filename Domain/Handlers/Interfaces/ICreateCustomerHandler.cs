using CQRSArchitecture.Domain.Commands.Requests;
using CQRSArchitecture.Domain.Commands.Responses;

namespace CQRSArchitecture.Domain.Handlers.Interfaces
{
    public interface ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
