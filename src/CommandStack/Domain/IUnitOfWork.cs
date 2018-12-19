using System;
namespace CommandStack.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}
