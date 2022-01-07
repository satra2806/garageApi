using garageApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace garageApi.Services
{
    public interface IGarageService
    {
        Task<List<GarageData>> GetAllAsync();

    }
}
