using Sample.Domain.Entities;
using Sample.Domain.Repositories;
using System;

namespace Sample.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            return new MeasureEntity(
                10,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);
        }
    }
}
