using System;
using System.Data;
using Dapper;
using FinalProjectTC.Models;

namespace FinalProjectTC
{
	public class LocationsRepo : ILocations
	{
        private readonly IDbConnection _conn;

        public LocationsRepo(IDbConnection conn)
		{
            _conn = conn;
		}

        public IEnumerable<Locations> GetAllLocations()
        {
            return _conn.Query<Locations>();
        }

        public IEnumerable<License> GetLicenses()
        {
            return _conn.Query<License>();
        }

        public IEnumerable<Network> GetNetworks()
        {
            return _conn.Query<Network>();
        }
    }

    }
}

