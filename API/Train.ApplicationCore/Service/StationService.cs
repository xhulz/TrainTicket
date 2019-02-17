using System;
using System.Collections.Generic;
using Train.ApplicationCore.Entity;
using Train.ApplicationCore.Interface.Repository;
using Train.ApplicationCore.Interface.Service;

namespace Train.ApplicationCore.Service
{
	public class StationService : IStationService
    {
		readonly IStationRepository _stationRepository;

		public StationService(IStationRepository stationRepository)
        {
			_stationRepository = stationRepository;
        }

		public IEnumerable<Station> GetStations()
		{
			return _stationRepository.GetStations();
		}
	}
}
