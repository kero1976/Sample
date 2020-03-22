using Sample.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Entities
{
    public sealed class MeasureEntity
    {
        public MeasureEntity(
            int areaId,
            DateTime measureDate,
            float measureValue)
        {
            AreaId = new AreaId(areaId);
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = measureValue;
        }

        public AreaId AreaId { get; }

        public MeasureDate MeasureDate { get; }

        public float MeasureValue { get; }
    }
}
