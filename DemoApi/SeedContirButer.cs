namespace DemoApi
{
    public static class SeedContirButer
    {
        public static async Task SeedEmployeeAsync(IServiceProvider serviceProvider)
        {
            var employeeRepository = serviceProvider.GetRequiredService<IEmployeeRepository>();
            var emp = employeeRepository.FindByEmail("maen@example.com");
            if (emp == null)
            {

                var employee = new Employee
                {
                    Email = "maen@example.com",
                    Password = "123456",
                    PrefixEn = "Mr.",
                    FirstNameEn = "Maen",
                    SecondNameEn = "Ali",
                    ThirdNameEn = "Abd Al-Hameed",
                    LastNameEn = "Dmour",
                    SuffixEn = "",
                    FullNameEn = "Mr. Maen Ali Abd Al-Hameed Dmour",
                    PrefixAr = "السيد",
                    FirstNameAr = "معن",
                    SecondNameAr = "أحمد",
                    ThirdNameAr = "علي",
                    LastNameAr = "دمور",
                    SuffixAr = "",
                    FullNameAr = "السيد معن أحمد علي دمور",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    ShortNameEn = "Maen",
                    ShortNameAr = "معن",
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    Religion = "Islam",
                    NationalNumber = "1234567890",
                    CreationDate = DateTime.Now,
                    IsDeleted = false,
                    IsCitizen = true,
                    IsActive = true,
                    Facebook = "https://facebook.com/maen",
                    Instgram = "https://instagram.com/maen",
                    Twitter = "https://twitter.com/maen",
                    LinkedIn = "https://linkedin.com/in/maen",
                    GooglePlus = "",
                    Skype = "maen.skype",
                    BasicSalary = 1200.50m,
                    ZIP = "11118",
                    PhoneNumber = "+962790000000",
                    About = "Software Developer",
                    Bio = "ASP.NET Core and Flutter Developer",
                    Location = "Amman",
                    CountryId = Guid.NewGuid(),
                    CityId = Guid.NewGuid(),
                    CompanyName = "Tech Company",
                    ManegerID = Guid.NewGuid(),
                    HiringDate = new DateTime(2024, 1, 1)
                };

                await employeeRepository.InsertAsync(employee);
            }
        }
    }
}
