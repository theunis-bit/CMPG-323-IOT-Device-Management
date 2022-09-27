using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        // GET: Devices
        public List<Device> GetAll()
        {
            return _context.Device.ToList();
        }
    }
}
