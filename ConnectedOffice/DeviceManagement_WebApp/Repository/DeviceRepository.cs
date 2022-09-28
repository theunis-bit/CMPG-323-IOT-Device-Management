using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagementWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Device.ToList();
        }

        public void Insert(Device device_)
        {
            _context.Device.Add(device_);
        }

        public Device GetById(Guid? DeviceId)
        {
            return _context.Device.Find(DeviceId);
        }

        public void Update(Device device_)
        {
            _context.Device.Attach(device_);
            _context.Entry(device_).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(Guid? categoryId)
        {
            Category category_ = _context.Category.Find(categoryId);
            _context.Category.Remove(category_);
        }
    }
}

