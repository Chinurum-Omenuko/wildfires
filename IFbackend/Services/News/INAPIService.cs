using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFbackend.Models;

namespace IFbackend.Services.News
{
    public interface INAPIService
    {
        Task<IEnumerable<News>> GetNewsAsync();
    }
}