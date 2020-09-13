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
    public interface IDesignationRepository 
    {
        Task<Tblmdesignation> GetDesignationById(int DesignationId);    

    }
    public class DesignationRepository : IDesignationRepository
    {
        private readonly AppDBContext _DBContext;
        public DesignationRepository(AppDBContext appDBContext)
        {
            _DBContext = appDBContext;
        }
        //public void Delete(Tblmdesignation entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Tblmdesignation>> GetAll()
        //{
        //    var dbDesignations = await _DBContext.Tblmdesignation.ToListAsync();
        //    return dbDesignations;
        //}
       
        public async Task<Tblmdesignation> GetDesignationById(int DesignationId)
        {
            var dbDesignation = await _DBContext.Tblmdesignation.Where(c => c.Id.Equals(DesignationId)).FirstOrDefaultAsync();
            return dbDesignation;
        }
        
    }
}
