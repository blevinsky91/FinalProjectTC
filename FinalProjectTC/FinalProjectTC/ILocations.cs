using System;
using System.Collections.Generic;
using FinalProjectTC.Models;

namespace FinalProjectTC
{
	public interface ILocations
	{
		public IEnumerable<Locations> GetAllLocations();
		public IEnumerable<License> GetLicenses();
		public IEnumerable<Network> GetNetworks();
	}
}

