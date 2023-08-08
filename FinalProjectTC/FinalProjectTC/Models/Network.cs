using System;
namespace FinalProjectTC.Models
{
	public class Network
	{
        public object Company { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public Locations Location { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Gbfs_href { get; set; }
        public License License { get; set; }
        public bool? Ebikes { get; set; }
    }
}

