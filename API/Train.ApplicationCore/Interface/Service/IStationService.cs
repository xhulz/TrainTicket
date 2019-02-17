using System;
using System.Collections.Generic;
using Train.ApplicationCore.Entity;

namespace Train.ApplicationCore.Interface.Service
{
    public interface IStationService
    {
		IEnumerable<Station> GetStations();
    }
}
