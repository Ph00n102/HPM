namespace HPM.Models
{
public class jobsrequest
    {
        public string lastName { get; set; }
        public int jobId { get; set; }
        public DateTime dateRequest { get; set; }
        public DateTime timeRequest { get; set; }
        public string hn { get; set; }
        public string pname { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string age { get; set; }
        public string sexs { get; set; }
        public string startPoint { get; set; }
        public string destination { get; set; }
        public string jobstatus { get; set; }
        public string department { get; set; }
        public string materialName { get; set; }
        public string urgentType { get; set; }
        public string patientType { get; set; }
        public int personId { get; set; }
        public DateTime timeClose { get; set; }
        public DateTime dateClase { get; set; }
        public string remark { get; set; }
    }
}