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
    public class ZonesRepository : GenericRepository<Zone>, IZonesRepository
    {
        public ZonesRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public IEnumerable<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }

        public void Insert(Zone zones_)
        {
            _context.Zone.Add(zones_);
        }

        public Zone GetById(Guid? ZoneId)
        {
            return _context.Zone.Find(ZoneId);
        }

        public void Update(Zone zones_)
        {
            _context.Zone.Attach(zones_);
            _context.Entry(zones_).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(Guid? zonesId)
        {
            Zone zones_ = _context.Zone.Find(zonesId);
            _context.Zone.Remove(zones_);
        }
    }
}
