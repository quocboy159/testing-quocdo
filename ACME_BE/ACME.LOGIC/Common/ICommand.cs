﻿using CSharpFunctionalExtensions;

namespace ACME.LOGIC.Common
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
