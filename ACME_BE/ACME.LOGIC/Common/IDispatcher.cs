using CSharpFunctionalExtensions;

namespace ACME.LOGIC.Common
{
    public interface IDispatcher
    {
         Result Dispatch(ICommand command);

        T Dispatch<T>(IQuery<T> query);
    }
}
