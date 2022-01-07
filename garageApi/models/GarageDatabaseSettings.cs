using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace garageApi.models
{
    public class GarageDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; } = null!;

        public string GarageCollectionName { get; set; } = null!;
    }
}
