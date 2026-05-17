namespace DemoApi
{
    public class CityDto : EntityDto<Guid>
    {
        public string CityAr { get; set; }
        public string CityEn { get; set; }
        public Guid CountryID { get; set; }
    }
}
