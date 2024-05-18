using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.Repository
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkExperienceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WorkExperience>> GetAllAsync()
        {
            return await _context.WorkExperiences.ToListAsync();
        }

        public async Task<WorkExperience> GetByIdAsync(int id)
        {
            return await _context.WorkExperiences.FindAsync(id);
        }
        public async Task UpdateAsync(WorkExperience workExperience)
        {
            _context.Entry(workExperience).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var workExperience = await _context.WorkExperiences.FindAsync(id);
            if (workExperience != null)
            {
                _context.WorkExperiences.Remove(workExperience);
                await _context.SaveChangesAsync();
            }
        }
    }
}
