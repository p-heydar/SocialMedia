using CQRS.Core.Commands;

namespace CQRS.Core.Infrastructure;

public interface ICommandDispatcher
{
    void RegisterHandler<T>(Func<T, Task<T>> handler) where T : BaseCommand;
    void SendAsync(BaseCommand command);
}