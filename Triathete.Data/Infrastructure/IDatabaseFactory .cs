﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathete.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        MyContext DataContext { get; }
    }

}
