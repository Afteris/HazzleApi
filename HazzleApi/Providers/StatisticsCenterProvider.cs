using Microsoft.AspNetCore.Mvc;
using HazzleApi.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using HazzleApi.Models;


namespace HazzleApi.Services
{
    public class StatisticsCenterProvider : IStatisticsCenterProvider
    {
        private readonly string baseUrl = "http://pxnet2.stat.fi/pxweb/api/v1/fi/StatFin";

        readonly HttpClient _httpClient;
        public StatisticsCenterProvider()
        {
            _httpClient = new HttpClient();
        }
        
        public async Task<List<StatisticsModel>> GetStatisticsCenterSchemaAsync()
        {
            var task =
            await
                _httpClient.GetAsync(baseUrl + "/?query=*&filter=*");

            task.EnsureSuccessStatusCode();

            var payload = task.Content.ReadAsStringAsync();

            List<StatisticsModel> statisticsModels = JsonConvert.DeserializeObject<List<StatisticsModel>>(payload.Result.ToString());

            return statisticsModels.FindAll(item => item.title.Contains("asuntojen"));
           
        }

       
    }
}
