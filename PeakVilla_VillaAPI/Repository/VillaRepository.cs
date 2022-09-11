using Microsoft.EntityFrameworkCore;
using PeakVilla_VillaAPI.Data;
using PeakVilla_VillaAPI.Models;
using PeakVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace PeakVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
