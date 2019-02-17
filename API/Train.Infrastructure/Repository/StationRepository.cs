using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Train.ApplicationCore.Entity;
using Train.ApplicationCore.Interface.Data;
using Train.ApplicationCore.Interface.Repository;

namespace Train.Infrastructure.Repository
{
	public class StationRepository : IStationRepository
    {
		readonly IDataContext _dataContext;

		public StationRepository(IDataContext context)
        {
			_dataContext = context;
        }

		public IEnumerable<Station> GetStations()
		{
			return _dataContext.Stations;
		}
	}
}
