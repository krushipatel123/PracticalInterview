using ApplicationForm.Interface;
using ApplicationForm.Models;

namespace ApplicationForm.Manager
{
    public class WorkExperienceManager : IWorkExperienceManager
    {
        private readonly IWorkExperienceRepository _repository;

        public WorkExperienceManager(IWorkExperienceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<WorkExperience>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<WorkExperience> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(WorkExperience workExperience)
        {
            await _repository.UpdateAsync(workExperience);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
