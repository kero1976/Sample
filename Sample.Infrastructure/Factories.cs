using Sample.Domain;
using Sample.Domain.Repositories;
using Sample.Infrastructure.Fake;
using Sample.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure
{
    public static class Factories
    {
        public static IMeasureRepository CreateMesure()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif

            return new MeasureSqlServer();
        }
    }
}
