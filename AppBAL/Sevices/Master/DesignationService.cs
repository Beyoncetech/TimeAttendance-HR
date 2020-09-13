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
    public interface IDesignationService
    {
        Task<CommonResponce> GetDesignationById(int DesignationId);       
        Task<CommonResponce> Insert(Designation DesignationToInsert);
        Task<CommonResponce> Update(Designation DesignationToInsert);
        Task<CommonResponce> Delete(int DesignationId);

    }
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository _designationRepository;
        private readonly IMapper _mapper;
        private readonly ICommonRepository<Tblmdesignation> _commonRepository;
        public DesignationService(IDesignationRepository DBdesignationRepository, IMapper mapper, AppDBContext appDBContext, ICommonRepository<Tblmdesignation> commonRepository)
        {
            _designationRepository = DBdesignationRepository;
            _mapper = mapper;
            _commonRepository = commonRepository;

        }
        public Task<CommonResponce> Delete(int designationId)
        {
            throw new NotImplementedException();
        }
              

        public async Task<CommonResponce> GetDesignationById(int DesignationId)
        {
            Designation designation = null;
            bool isValid = false;
            var dbDesignation = await _designationRepository.GetDesignationById(DesignationId).ConfigureAwait(false);
            if (dbDesignation != null)
            {
                designation = _mapper.Map<Designation>(dbDesignation);
                isValid = true;
            }
            CommonResponce result = new CommonResponce
            {
                Stat = isValid,
                StatusMsg = "",
                StatusObj = designation
            };
            return result;
        }

        public async Task<CommonResponce> Insert(Designation DesignationToInsert)
        {
            bool isValid = false;
            CommonResponce result = new CommonResponce();
            try
            {

                isValid = await _commonRepository.Insert(_mapper.Map<Tblmdesignation>(DesignationToInsert));
                result.Stat = isValid;
                result.StatusMsg = "Designation created successfully";                

            }
            catch (Exception ex)
            {
                result.Stat = isValid;
                result.StatusMsg = "Designation creation is not successful";
                //logger
                //throw;
            }
            return result;
            //throw new NotImplementedException();
        }

        public Task<CommonResponce> Update(Designation DesignationToInsert)
        {
            throw new NotImplementedException();
        }
    }
}
