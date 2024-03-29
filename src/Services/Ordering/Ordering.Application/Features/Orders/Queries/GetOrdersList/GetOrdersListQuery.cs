﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Queries.GetOrdersList
{
    public class GetOrdersListQuery :IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }
        public GetOrdersListQuery(string username)
        {
            UserName = username ?? throw new ArgumentNullException(nameof(username));
        }
    }
}
