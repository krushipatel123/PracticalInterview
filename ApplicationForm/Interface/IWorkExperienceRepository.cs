using ApplicationForm.Models;

namespace ApplicationForm.Interface
{
    public interface IWorkExperienceRepository
    {
        Task<IEnumerable<WorkExperience>> GetAllAsync();
        Task<WorkExperience> GetByIdAsync(int id);
        Task UpdateAsync(WorkExperience workExperience);
        Task DeleteAsync(int id);
    }
}
