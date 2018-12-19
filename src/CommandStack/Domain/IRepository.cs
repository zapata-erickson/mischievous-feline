using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CommandStack.Domain
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
    {
        IEnumerable<TAggregateRoot> Find(Expression<Func<TAggregateRoot, bool>> whereCriteria);
    }
}
