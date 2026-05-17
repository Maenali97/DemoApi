namespace DemoApi
{
    public class CountryDto : EntityDto<Guid>
    {
        public string CountryAr { get; set; }
        public string CountryEn { get; set; }
    }
}
