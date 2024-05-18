using ApplicationForm.Models;

namespace ApplicationForm.Interface
{
    public interface IEducationManager
    {
        Task<IEnumerable<EducationDetails>> GetAllAsync();
        Task<EducationDetails> GetByIdAsync(int id);
        Task UpdateAsync(EducationDetails educationDetails);
        Task DeleteAsync(int id);
    }
}
