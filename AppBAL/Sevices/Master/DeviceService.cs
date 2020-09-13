using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppDAL.DBModels;
using AppDAL.DBRepository;
using AppDAL.DBRepository.Master;
using AppModel;
using AppModel.BusinessModel.Master;
using AutoMapper;

namespace AppBAL.Sevices.Master
{
    public interface IDeviceService
    {
        Task<CommonResponce> GetDeviceById(int DeviceId);
        Task<CommonResponce> GetDeviceByCpuId(string CpuId);
        Task<CommonResponce> GetDeviceByIpAddress(string IpAddress);
        Task<CommonResponce> GetDevicesByOuid(int Ouid);
        Task<CommonResponce> Insert(Device DeviceToInsert); 
        Task<CommonResponce> Update(Device DeviceToInsert);
        Task<CommonResponce> Delete(int DeviceId);

    }
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;
        private readonly ICommonRepository<Tblmdevice> _commonRepository;
        public DeviceService(IDeviceRepository DBdeviceRepository, IMapper mapper, AppDBContext appDBContext, ICommonRepository<Tblmdevice> commonRepository)
        {
            _deviceRepository = DBdeviceRepository;
            _mapper = mapper;
            _commonRepository = commonRepository;
        }   
        public Task<CommonResponce> Delete(int deviceId)
        {
            throw new NotImplementedException();
        }
              

        public async Task<CommonResponce> GetDeviceById(int DeviceId)
        {
            Device device = null;
            bool isValid = false;
            var dbDevice = await _deviceRepository.GetDeviceById(DeviceId).ConfigureAwait(false);
            if (dbDevice != null)
            {
                device = _mapper.Map<Device>(dbDevice);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = device
            };
            return result;
        }

        public async Task<CommonResponce> Insert(Device DeviceToInsert)
        {
            bool isValid = false;
            CommonResponce result = new CommonResponce();
            try
            {

                isValid = await _commonRepository.Insert(_mapper.Map<Tblmdevice>(DeviceToInsert));
                result.Stat = isValid;
                result.StatusMsg = "Device created successfully";                

            }
            catch (Exception ex)
            {
                result.Stat = isValid;
                result.StatusMsg = "Device creation is not successful";
                //logger
                //throw;
            }
            return result;
            //throw new NotImplementedException();
        }

        public Task<CommonResponce> Update(Device DeviceToInsert)
        {
            throw new NotImplementedException();
        }

        public async Task<CommonResponce> GetDeviceByCpuId(string CpuId)
        {
            Device device = null;
            bool isValid = false;
            var dbDevice = await _deviceRepository.GetDeviceByCpuId(CpuId.Trim()).ConfigureAwait(false);
            if (dbDevice != null)
            {
                device = _mapper.Map<Device>(dbDevice);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = device
            };
            return result;
        }

        public async Task<CommonResponce> GetDeviceByIpAddress(string IpAddress)
        {
            Device device = null;
            bool isValid = false;
            var dbDevice = await _deviceRepository.GetDeviceByIpAddress(IpAddress.Trim()).ConfigureAwait(false);
            if (dbDevice != null)
            {
                device = _mapper.Map<Device>(dbDevice);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = device
            };
            return result;
        }

        public async Task<CommonResponce> GetDevicesByOuid(int Ouid)
        {
            List<Device> devices = null;
            bool isValid = false;
            var dbDevices = await _deviceRepository.GetDevicesByOuid(Ouid).ConfigureAwait(false);
            if (dbDevices != null)
            {
                devices = _mapper.Map<List<Device>>(dbDevices);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = devices
            };
            return result;
        }
    }
}
