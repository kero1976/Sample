using Sample.Domain.Entities;
using Sample.Domain.Repositories;
using System;

namespace Sample.Infrastructure.SqlServer
{
    internal sealed class MeasureSqlServer : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }
    }
}
