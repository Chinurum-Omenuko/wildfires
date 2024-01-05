using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNews = IFbackend.Models.News;

namespace IFbackend.Services.News
{
    public interface INAPIService
    {
        Task<IEnumerable<Models.News>> GetNewsAsync();
    }
}