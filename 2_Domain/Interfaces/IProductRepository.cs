﻿using Domain.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetTopProduct();
    }
}
