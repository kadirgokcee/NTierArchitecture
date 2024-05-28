﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Features.Products
{
    public sealed record CreateProductCommand(
     string Name,
     decimal Price,
     int Quantity,
     Guid CategoryId) : IRequest<Unit>;
}
