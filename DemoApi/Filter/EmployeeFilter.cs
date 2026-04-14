namespace DemoApi
{
    public class EmployeeFilter
    {
        public int Skip { get; set; } =0 ;
        public int Size { get; set; } = 10;
        public string Email { get; set; }
        public string Name { get; set; }
        public GenderEnum? Gender { get; set; }
        public bool? IsCitizen { get; set; }
    }
}
