﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IIterator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}