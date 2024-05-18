using ApplicationForm.Models;

namespace ApplicationForm.Interface
{
    public interface IEducationRepository
    {
        Task<IEnumerable<EducationDetails>> GetAllAsync();
        Task<EducationDetails> GetByIdAsync(int id);
        Task UpdateAsync(EducationDetails educationDetails);
        Task DeleteAsync(int id);
    }
}
