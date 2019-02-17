using System;
using System.Collections.Generic;
using Train.ApplicationCore.Entity;

namespace Train.ApplicationCore.Interface.Repository
{
    public interface IStationRepository
    {
		IEnumerable<Station> GetStations();
    }
}
