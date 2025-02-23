﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverterLibrary
{
    public interface ISerializer
    {
        string Serialize(IEnumerable<NodeAbstraction> nodes);
    }
    public interface ISerializer<TTo> : ISerializer
    {
    }
}
