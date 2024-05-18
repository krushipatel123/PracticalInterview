using ApplicationForm.Interface;
using ApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApplicationForm.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BasicDetails>> GetAllAsync()
        {
            return await _context.BasicDetails.ToListAsync();
        }

        public async Task<BasicDetails> GetByIdAsync(int id)
        {
            return await _context.BasicDetails.FindAsync(id);
        }

        public async Task<BasicDetails> AddAsync(BasicDetails basicDetails)
        {
            _context.BasicDetails.Add(basicDetails);
            await _context.SaveChangesAsync();
            return basicDetails;
        }

        public async Task UpdateAsync(BasicDetails basicDetails)
        {
            _context.Entry(basicDetails).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var basicDetails = await _context.BasicDetails.FindAsync(id);
            if (basicDetails != null)
            {
                _context.BasicDetails.Remove(basicDetails);
                await _context.SaveChangesAsync();
            }
        }
    }
}
