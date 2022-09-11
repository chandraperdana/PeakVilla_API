using PeakVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace PeakVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
