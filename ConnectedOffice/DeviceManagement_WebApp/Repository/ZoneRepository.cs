using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        
        // GET: Zones
        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();

        }
    }
}
