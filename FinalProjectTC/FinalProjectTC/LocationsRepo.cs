using System;
using System.Data;
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
            throw new NotImplementedException();
        }
    }
}

