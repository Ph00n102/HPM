using HPM.Data.Entities;
using Newtonsoft.Json.Linq;


namespace HPM.Controller;

public class JobsController
{
    //private static Uri DataBaseAddress { get; set; } = new Uri("http://183.89.226.246:88");
    private static Uri DataBaseAddress { get; set; } = new Uri("http://172.16.0.111:8899");

    public async static Task<List<JobRequest>> GetJobName()
    {
        var jobsreq = new Dictionary<string, string>();
        //param.Add("Paramiter_HN", tempx);
        var content = new FormUrlEncodedContent(jobsreq);
        var client = new HttpClient();
        client.BaseAddress = DataBaseAddress;
        //var clientData = GetClientData();
        var response = await client.PostAsync("api/JobRequest/GetJobName", content);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var json = await response.Content.ReadAsStringAsync();

            return JArray.Parse(json).ToObject<List<JobRequest>>();

        }

        else return new List<JobRequest>();
    }
}