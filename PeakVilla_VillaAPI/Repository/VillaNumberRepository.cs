using Microsoft.EntityFrameworkCore;
using PeakVilla_VillaAPI.Data;
using PeakVilla_VillaAPI.Models;
using PeakVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace PeakVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
