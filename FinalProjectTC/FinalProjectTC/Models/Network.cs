﻿using System;
namespace FinalProjectTC.Models
{
	public class Network
	{
        public object company { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public string gbfs_href { get; set; }
        public License license { get; set; }
        public bool? ebikes { get; set; }
    }
}

