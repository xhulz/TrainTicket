using System;
using System.Collections.Generic;
using Train.ApplicationCore.Entity;
using Train.ApplicationCore.Interface.Data;

namespace Train.Infrastructure.Data
{
	public class DataContext : IDataContext
	{
		public IEnumerable<Station> Stations { get => new Station[] {
            new Station { Name = "DARTFORD"},
            new Station { Name = "DARTMOUTH"},
    		new Station { Name = "TOWER HILL"},
    		new Station { Name = "DERBY"},
    		new Station { Name = "LIVERPOOL"},
    		new Station { Name = "LIVERPOOL LIME STREET"},
    		new Station { Name = "PADDINGTON"},
    		new Station { Name = "EUSTON"},
    		new Station { Name = "LONDON BRIDGE"},
    		new Station { Name = "VICTORIA"}
        }; }
	}
}
