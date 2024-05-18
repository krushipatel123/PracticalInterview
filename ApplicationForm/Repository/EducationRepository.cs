using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly ApplicationDbContext _context;

        public EducationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EducationDetails>> GetAllAsync()
        {
            return await _context.EducationDetails.ToListAsync();
        }

        public async Task<EducationDetails> GetByIdAsync(int id)
        {
            return await _context.EducationDetails.FindAsync(id);
        }

        public async Task UpdateAsync(EducationDetails educationDetails)
        {
            _context.Entry(educationDetails).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var educationDetails = await _context.EducationDetails.FindAsync(id);
            if (educationDetails != null)
            {
                _context.EducationDetails.Remove(educationDetails);
                await _context.SaveChangesAsync();
            }
        }
    }
}
