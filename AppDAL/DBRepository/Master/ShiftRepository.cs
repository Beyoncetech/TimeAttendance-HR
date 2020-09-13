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
    public interface IShiftRepository 
    {
        Task<Tblmshift> GetShiftById(int ShiftId);
        Task<Tblmshift> GetShiftByCode(string ShiftCode);
    }
    public class ShiftRepository : IShiftRepository
    {
        private readonly AppDBContext _DBContext;
        public ShiftRepository(AppDBContext appDBContext)
        {
            _DBContext = appDBContext;
        }
        //public void Delete(Tblmshift entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Tblmshift>> GetAll()
        //{
        //    var dbShifts = await _DBContext.Tblmshift.ToListAsync();
        //    return dbShifts;
        //}

        public async Task<Tblmshift> GetShiftByCode(string ShiftCode)
        {
            var dbShift = await _DBContext.Tblmshift.Where(c => c.Code.Equals(ShiftCode)).FirstOrDefaultAsync();
            return dbShift;
        }

        public async Task<Tblmshift> GetShiftById(int ShiftId)
        {
            var dbShift = await _DBContext.Tblmshift.Where(c => c.Id.Equals(ShiftId)).FirstOrDefaultAsync();
            return dbShift;
        }

        //public void Insert(Tblmshift entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Tblmshift entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
