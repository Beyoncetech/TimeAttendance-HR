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
    public interface IShiftService
    {
        Task<CommonResponce> GetShiftById(int ShiftId);
        Task<CommonResponce> GetShiftByCode(string ShiftCode);
        Task<CommonResponce> Insert(Shift ShiftToInsert);
        Task<CommonResponce> Update(Shift ShiftToInsert);
        Task<CommonResponce> Delete(int ShiftId);

    }
    public class ShiftService : IShiftService
    {
        private readonly IShiftRepository _shiftRepository;
        private readonly IMapper _mapper;
        private readonly ICommonRepository<Tblmshift> _;
        private readonly ICommonRepository<Tblmshift> _commonRepository;
        public ShiftService(IShiftRepository DBshiftRepository, IMapper mapper, AppDBContext appDBContext,ICommonRepository<Tblmshift> commonRepository) 
        {
            _shiftRepository = DBshiftRepository;
            _mapper = mapper;
            _commonRepository = commonRepository;
        }
        public Task<CommonResponce> Delete(int ShiftId)
        {
            throw new NotImplementedException();
        }

        public async Task<CommonResponce> GetShiftByCode(string ShiftCode)
        {
            Shift shift = null;
            bool isValid = false;
            var dbShift = await _shiftRepository.GetShiftByCode(ShiftCode).ConfigureAwait(false);
            if (dbShift != null)
            {
                shift = _mapper.Map<Shift>(dbShift);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = shift
            };
            return result;
        }

        public async Task<CommonResponce> GetShiftById(int ShiftId)
        {
            Shift shift = null;
            bool isValid = false;
            var dbShift = await _shiftRepository.GetShiftById(ShiftId).ConfigureAwait(false);
            if (dbShift != null)
            {
                shift = _mapper.Map<Shift>(dbShift);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = shift
            };
            return result;
        }

        public async Task<CommonResponce> Insert(Shift ShiftToInsert)
        {
            bool isValid = false;
            CommonResponce result = new CommonResponce();
            try
            {

                isValid = await _commonRepository.Insert(_mapper.Map<Tblmshift>(ShiftToInsert));
                result.Stat = isValid;
                result.StatusMsg = "Shift created successfully";                

            }
            catch (Exception ex)
            {
                result.Stat = isValid;
                result.StatusMsg = "Shift creation is not successful";
                //logger
                //throw;
            }
            return result;
            //throw new NotImplementedException();
        }

        public Task<CommonResponce> Update(Shift ShiftToInsert)
        {
            throw new NotImplementedException();
        }
    }
}
