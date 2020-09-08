﻿using HazzleApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HazzleApi.Providers
{
    public interface IStatisticsCenterProvider
    {
        Task<List<StatisticsModel>> GetStatisticsCenterSchemaAsync();
    }
}
