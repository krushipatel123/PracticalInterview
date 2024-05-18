using ApplicationForm.Models;

namespace ApplicationForm.Interface
{
    public interface IAplicationManager
    {
        Task<IEnumerable<BasicDetails>> GetAllAsync();
        Task<BasicDetails> GetByIdAsync(int id);
        Task UpdateAsync(BasicDetails basicDetails);
        Task DeleteAsync(int id);
    }
}
