using ApplicationForm.Interface;
using ApplicationForm.Models;

namespace ApplicationForm.Manager
{
    public class EducationManager : IEducationManager
    {
        private readonly IEducationRepository _repository;

        public EducationManager(IEducationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EducationDetails>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<EducationDetails> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(EducationDetails educationDetails)
        {
            await _repository.UpdateAsync(educationDetails);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
