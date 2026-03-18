using Domain;

namespace DemoApi
{
    public class Event : Entity<Guid>
    {
        public  string Title { get; set; }
        public  string SubTitle { get; set; }
        public  string Body { get; set; }
        public  string Location { get; set; }
        public  DateTime StartDateTime { get; set; }
        public  DateTime EndDateTime { get; set; }
        public  DateTime CreationDate { get; set; }
        public  int Type { get; set; }
    }
}
