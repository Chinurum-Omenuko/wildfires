using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IFbackend.Services.News;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IFbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly INAPIService _nAPIService;

        public NewsController(INAPIService nAPIService)
        {
            _nAPIService = nAPIService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.News>>> GetNews()
        {
           var news = await _nAPIService.GetNewsAsync();
           return Ok(news);
        }
    }
}