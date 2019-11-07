﻿#region copyright

// Copyright Information
// ==================================
// SpyStore.Hol - SpyStore.Hol.Dal - IOrderDetailRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2019/10/04
// See License.txt for more information
// ==================================

#endregion

using System;
using System.Collections.Generic;
using SpyStore.Hol.Dal.Repos.Base;
using SpyStore.Hol.Models.Entities;
using SpyStore.Hol.Models.ViewModels;

namespace SpyStore.Hol.Dal.Repos.Interfaces
{
    public interface IOrderDetailRepo : IRepo<OrderDetail>
    {
        IEnumerable<OrderDetailWithProductInfo> GetOrderDetailsWithProductInfoForOrder(int orderId);
    }
}