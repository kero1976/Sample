﻿using Sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
    }
}
