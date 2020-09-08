using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazzleApi.Models;
using HazzleApi.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HazzleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ILogger<StatisticsController> _logger;
        private readonly IStatisticsCenterProvider _statisticsCenterProvider;

        public StatisticsController(ILogger<StatisticsController> logger, IStatisticsCenterProvider statisticsCenterProvider)
        {
            _logger = logger;
            _statisticsCenterProvider = statisticsCenterProvider;
        }

        [HttpGet]
        public async Task<List<StatisticsModel>> Get()
        {
            return await _statisticsCenterProvider.GetStatisticsCenterSchemaAsync();
        }
    }
}
