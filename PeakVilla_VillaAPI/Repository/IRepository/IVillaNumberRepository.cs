using PeakVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace PeakVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
