﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw7
{
    public abstract class Entity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
