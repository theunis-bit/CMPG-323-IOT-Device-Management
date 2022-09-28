using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;

namespace DeviceManagementWebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {

        IEnumerable<Device> GetAll();
        Device GetById(Guid? DeviceId);
        void Insert(Device device_);
        void Update(Device device_);
        void Delete(Guid? DeviceId);

    }
}
