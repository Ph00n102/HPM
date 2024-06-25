using HPM.Data;
using HPM.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace HPM.Services
{
    public class JobReqeustService
    {
        #region Property
        private readonly HpmContext _HpmContext;
        #endregion

        #region Constructor
        public JobReqeustService (HpmContext HpmContext)
        {
            _HpmContext = HpmContext;
        }
        #endregion

        #region Get List of Job
        public async  Task<List<JobRequest>>GetAllJobAsync()
        {
            return await _HpmContext.JobRequests.ToListAsync();
        }
        #endregion

        #region Insert Job
        public async Task<bool>InsertJobAsync(JobRequest jobRequest)
        {
            await _HpmContext.JobRequests.AddAsync(jobRequest);
            await _HpmContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Job by Id
        public async Task<JobRequest>GetJobAsync(int Id)
        {
            JobRequest jobRequest = await _HpmContext.JobRequests.FirstOrDefaultAsync(c => c.JobId.Equals(Id));
            return jobRequest;
        }
        #endregion

        #region Update Job
        public async Task<bool>UpdateJobAsync(JobRequest jobRequest)
        {
             _HpmContext.JobRequests.Update(jobRequest);
            await _HpmContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteJob
        public async Task<bool>DeleteJobAsync(JobRequest jobRequest)
        {
            _HpmContext.Remove(jobRequest);
            await _HpmContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}