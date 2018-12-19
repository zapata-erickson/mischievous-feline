using System;
namespace CommandStack.Domain
{
    public interface IUnitOfWorkFactory<TUnitOfWork> where TUnitOfWork : IUnitOfWork
    {
        TUnitOfWork CreateNew();
    }
}
