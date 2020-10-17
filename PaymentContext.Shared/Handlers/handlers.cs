using PaymentContext.Shared.Commands;

namespace Paymentcontext.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }

}