using ApplicationForm.Interface;
using ApplicationForm.Models;

namespace ApplicationForm.Manager
{
    public class ApplicationManager : IAplicationManager
    {
        private readonly IApplicationRepository _repository;

        public ApplicationManager(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BasicDetails>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<BasicDetails> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(BasicDetails basicDetails)
        {
            await _repository.UpdateAsync(basicDetails);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
