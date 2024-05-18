using ApplicationForm.Models;

namespace ApplicationForm.Interface
{
    public interface IWorkExperienceManager
    {
        Task<IEnumerable<WorkExperience>> GetAllAsync();
        Task<WorkExperience> GetByIdAsync(int id);
        Task UpdateAsync(WorkExperience workExperience);
        Task DeleteAsync(int id);
    }
}
