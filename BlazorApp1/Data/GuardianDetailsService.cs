using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class GuardianDetailsService
    {
        #region
        private readonly AppDbContext _appDbContext;
        #endregion

        #region Constructor
        public GuardianDetailsService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Get list of Guardian Roster
        public async Task<List<GuardianDetails>> GetRosterAsync()
        {
            return await _appDbContext.GuardianRoster.ToListAsync();
        }
        #endregion

        #region Insert Guardian
        public async Task<bool> InsertGuardianAsync(GuardianDetails guardian)
        {
            await _appDbContext.GuardianRoster.AddAsync(guardian);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Guardian by Id
        public async Task<GuardianDetails> GetGuardianAsync(int Id)
        {
            GuardianDetails guardian = await _appDbContext.GuardianRoster.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return guardian;
        }
        #endregion

        #region Update Guardian 
        public async Task<bool>UpdateGuardianAsync(GuardianDetails guardian)
        {
            _appDbContext.GuardianRoster.Update(guardian);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Guardian 
        public async Task<bool> DeleteGuardianAsync(GuardianDetails guardian)
        {
            _appDbContext.Remove(guardian);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
