using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAL.DBModels;
using Microsoft.EntityFrameworkCore;

namespace AppDAL.DBRepository.Master
{
    public interface IDeviceRepository
    {
        Task<Tblmdevice> GetDeviceById(int DeviceId);
        Task<Tblmdevice> GetDeviceByCpuId(string CpuId);
        Task<Tblmdevice> GetDeviceByIpAddress(string IpAddress);
        Task<List<Tblmdevice>> GetDevicesByOuid(int Ouid);
      
    }
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AppDBContext _DBContext;
        public DeviceRepository(AppDBContext appDBContext)
        {
            _DBContext = appDBContext;
        }


        public async Task<Tblmdevice> GetDeviceById(int DeviceId)
        {
            var dbDevice = await _DBContext.Tblmdevice.Where(c => c.Id.Equals(DeviceId)).FirstOrDefaultAsync();
            return dbDevice;
        }

        public async Task<Tblmdevice> GetDeviceByCpuId(string CpuId)
        {
           
            var dbDevice = await _DBContext.Tblmdevice.Where(c => c.Cpuid.Equals(CpuId)).FirstOrDefaultAsync();
            return dbDevice;
        }

        public async Task<Tblmdevice> GetDeviceByIpAddress(string IpAddress)
        {           
            var dbDevice = await _DBContext.Tblmdevice.Where(c => c.Ipaddress.Equals(IpAddress)).FirstOrDefaultAsync();
            return dbDevice;
        }

        public async Task<List<Tblmdevice>> GetDevicesByOuid(int Ouid)
        {
            var dbDevices = await _DBContext.Tblmdevice.Where(c => c.Ouid.Equals(Ouid)).ToListAsync();
            return dbDevices;
        }
    }
}
