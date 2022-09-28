using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;

namespace DeviceManagementWebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {

        IEnumerable<Zone> GetAll();
        Zone GetById(Guid? ZoneId);
        void Insert(Zone zone_);
        void Update(Zone zone_);
        void Delete(Guid? ZoneId);

    }
}
