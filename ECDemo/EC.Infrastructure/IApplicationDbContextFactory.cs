﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Infrastructure
{
    public interface IApplicationDbContextFactory:IDisposable
    {
        ApplicationDbContext Get();
    }
}
