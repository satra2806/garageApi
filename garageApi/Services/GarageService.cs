using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using garageApi.models;

using garageApi.Services;

namespace garageApi.Services
{
    public class GarageService: IGarageService
    {
        private readonly IMongoCollection<GarageData> _garage;
        private readonly GarageDatabaseSettings _settings;
        public GarageService(IOptions<GarageDatabaseSettings> settings)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _garage = database.GetCollection<GarageData>(_settings.GarageCollectionName);
        }
        public async Task<List<GarageData>> GetAllAsync()
        {
            return await _garage.Find(c => true).ToListAsync();
        }

    }
}
