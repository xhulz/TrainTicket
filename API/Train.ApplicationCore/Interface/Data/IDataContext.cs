using System;
using System.Collections.Generic;
using Train.ApplicationCore.Entity;

namespace Train.ApplicationCore.Interface.Data
{
    public interface IDataContext
    {
		IEnumerable<Station> Stations { get; }
    }
}
