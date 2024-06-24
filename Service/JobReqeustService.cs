using HPM.Data;
using HPM.Data.Entities;


namespace HPM.Service
{
    public class JobRequestService : IJobRequestService
    {
        private readonly HpmContext _ctx;
        public JobRequestService(HpmContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(JobRequest jobRequest)
        {
            try
            {
                if (jobRequest.HN != null)
                    _ctx.JobRequests.Add(jobRequest);
                else
                    _ctx.JobRequests.Update(jobRequest);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    //     public bool Delete(int JobId)
    //     {
    //         try
    //         {
    //             var jobRequest = FindById(JobId);
    //             if (jobRequest == null)
    //                 return false;
    //             _ctx.JobRequests.Remove(jobRequest);
    //             _ctx.SaveChanges();
    //             return true;
    //         }
    //         catch (Exception ex)
    //         {

    //             return false;
    //         }
    //     }

    //     public Person FindById(int id)
    //     {
    //         return _ctx.Person.Find(id);
    //     }

    //     public List<Person> GetAll()
    //     {
    //         return _ctx.Person.ToList();
    //     }
     }
}