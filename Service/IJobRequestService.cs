using HPM.Data;
using HPM.Data.Entities;
using HPM.Models;


namespace HPM.Service

{
      public interface IJobRequestService
      {
          bool AddUpdate(JobRequest jobRequest);
        //   bool Delete(int JobId);
        //   JobRequest FindById(int JobId);
        //   List<JobRequest> GetAll(); 
      }
}
 