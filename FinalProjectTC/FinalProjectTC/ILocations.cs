using System;
using System.Collections.Generic;
using FinalProjectTC.Models;

namespace FinalProjectTC
{
	public interface ILocations
	{
		public IEnumerable<Locations> GetAllLocations();
	}
}

