using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duy.FootballData.Client;
using Duy.FootballData.Common;
using Duy.FootballData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Duy.FootballDataWeb.Controllers
{
    public class FootballController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetLeagueTable()
        {
            var option = new FootballDataOption
            {
                ApiKey = string.Empty,
                ResponseControl = ResponseControl.Full
            };
            IFootballDataClient client = new FootballDataClient(option);
            LeagueTable leagueTable = await client.GetLeagueTable(445, null);

            return Json(leagueTable);
        }
    }
}