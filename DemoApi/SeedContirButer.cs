namespace DemoApi
{
    public static class SeedContirButer
    {
        public static async Task SeedEmployeeAsync(IServiceProvider serviceProvider)
        {
            var employeeRepository = serviceProvider.GetRequiredService<IEmployeeRepository>();

            var employees = new List<Employee>
{
    new Employee
    {
        Email = "ahmad@example.com",
        Password = "123456",
        PrefixEn = "Mr.",
        FirstNameEn = "Ahmad",
        SecondNameEn = "Saleh",
        ThirdNameEn = "Yousef",
        LastNameEn = "Khalil",
        FullNameEn = "Mr. Ahmad Saleh Yousef Khalil",

        PrefixAr = "السيد",
        FirstNameAr = "أحمد",
        SecondNameAr = "صالح",
        ThirdNameAr = "يوسف",
        LastNameAr = "خليل",
        FullNameAr = "السيد أحمد صالح يوسف خليل",

        DateOfBirth = new DateTime(1988, 3, 10),
        Gender = GenderEnum.Male,
        MaritalStatus = MaritalStatusEnum.Married,
        Religion = "Islam",
        NationalNumber = "1111111111",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 900,
        PhoneNumber = "+962791111111",
        Location = "Amman",
        HiringDate = new DateTime(2022, 5, 1)
    },

    new Employee
    {
        Email = "sara@example.com",
        Password = "123456",
        PrefixEn = "Ms.",
        FirstNameEn = "Sara",
        SecondNameEn = "Ahmad",
        ThirdNameEn = "Hassan",
        LastNameEn = "Omar",
        FullNameEn = "Ms. Sara Ahmad Hassan Omar",

        PrefixAr = "الآنسة",
        FirstNameAr = "سارة",
        SecondNameAr = "أحمد",
        ThirdNameAr = "حسن",
        LastNameAr = "عمر",
        FullNameAr = "الآنسة سارة أحمد حسن عمر",

        DateOfBirth = new DateTime(1995, 7, 20),
        Gender = GenderEnum.Female,
        MaritalStatus = MaritalStatusEnum.Single,
        Religion = "Islam",
        NationalNumber = "2222222222",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 800,
        PhoneNumber = "+962792222222",
        Location = "Zarqa",
        HiringDate = new DateTime(2023, 2, 10)
    },

    new Employee
    {
        Email = "khaled@example.com",
        Password = "123456",
        PrefixEn = "Mr.",
        FirstNameEn = "Khaled",
        SecondNameEn = "Mohammad",
        ThirdNameEn = "Ali",
        LastNameEn = "Nasser",
        FullNameEn = "Mr. Khaled Mohammad Ali Nasser",

        PrefixAr = "السيد",
        FirstNameAr = "خالد",
        SecondNameAr = "محمد",
        ThirdNameAr = "علي",
        LastNameAr = "ناصر",
        FullNameAr = "السيد خالد محمد علي ناصر",

        DateOfBirth = new DateTime(1985, 11, 5),
        Gender = GenderEnum.Male,
        MaritalStatus = MaritalStatusEnum.Married,
        Religion = "Islam",
        NationalNumber = "3333333333",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 1100,
        PhoneNumber = "+962793333333",
        Location = "Irbid",
        HiringDate = new DateTime(2021, 6, 15)
    },

    new Employee
    {
        Email = "lina@example.com",
        Password = "123456",
        PrefixEn = "Ms.",
        FirstNameEn = "Lina",
        SecondNameEn = "George",
        ThirdNameEn = "Hanna",
        LastNameEn = "Haddad",
        FullNameEn = "Ms. Lina George Hanna Haddad",

        PrefixAr = "الآنسة",
        FirstNameAr = "لينا",
        SecondNameAr = "جورج",
        ThirdNameAr = "حنا",
        LastNameAr = "حداد",
        FullNameAr = "الآنسة لينا جورج حنا حداد",

        DateOfBirth = new DateTime(1992, 9, 1),
        Gender = GenderEnum.Female,
        MaritalStatus = MaritalStatusEnum.Single,
        Religion = "Christianity",
        NationalNumber = "4444444444",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 950,
        PhoneNumber = "+962794444444",
        Location = "Amman",
        HiringDate = new DateTime(2020, 8, 20)
    },

    new Employee
    {
        Email = "mohammad@example.com",
        Password = "123456",
        PrefixEn = "Mr.",
        FirstNameEn = "Mohammad",
        SecondNameEn = "Ahmad",
        ThirdNameEn = "Saleh",
        LastNameEn = "Fares",
        FullNameEn = "Mr. Mohammad Ahmad Saleh Fares",

        PrefixAr = "السيد",
        FirstNameAr = "محمد",
        SecondNameAr = "أحمد",
        ThirdNameAr = "صالح",
        LastNameAr = "فارس",
        FullNameAr = "السيد محمد أحمد صالح فارس",

        DateOfBirth = new DateTime(1987, 4, 12),
        Gender = GenderEnum.Male,
        MaritalStatus = MaritalStatusEnum.Married,
        Religion = "Islam",
        NationalNumber = "5555555555",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 1000,
        PhoneNumber = "+962795555555",
        Location = "Aqaba",
        HiringDate = new DateTime(2019, 3, 3)
    },

    new Employee
    {
        Email = "rana@example.com",
        Password = "123456",
        PrefixEn = "Ms.",
        FirstNameEn = "Rana",
        SecondNameEn = "Ali",
        ThirdNameEn = "Hassan",
        LastNameEn = "Salem",
        FullNameEn = "Ms. Rana Ali Hassan Salem",

        PrefixAr = "الآنسة",
        FirstNameAr = "رنا",
        SecondNameAr = "علي",
        ThirdNameAr = "حسن",
        LastNameAr = "سالم",
        FullNameAr = "الآنسة رنا علي حسن سالم",

        DateOfBirth = new DateTime(1998, 12, 30),
        Gender = GenderEnum.Female,
        MaritalStatus = MaritalStatusEnum.Single,
        Religion = "Islam",
        NationalNumber = "6666666666",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 700,
        PhoneNumber = "+962796666666",
        Location = "Salt",
        HiringDate = new DateTime(2024, 1, 5)
    },

    new Employee
    {
        Email = "yousef@example.com",
        Password = "123456",
        PrefixEn = "Mr.",
        FirstNameEn = "Yousef",
        SecondNameEn = "Khaled",
        ThirdNameEn = "Mahmoud",
        LastNameEn = "Darwish",
        FullNameEn = "Mr. Yousef Khaled Mahmoud Darwish",

        PrefixAr = "السيد",
        FirstNameAr = "يوسف",
        SecondNameAr = "خالد",
        ThirdNameAr = "محمود",
        LastNameAr = "درويش",
        FullNameAr = "السيد يوسف خالد محمود درويش",

        DateOfBirth = new DateTime(1991, 6, 18),
        Gender = GenderEnum.Male,
        MaritalStatus = MaritalStatusEnum.Married,
        Religion = "Islam",
        NationalNumber = "7777777777",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 1050,
        PhoneNumber = "+962797777777",
        Location = "Madaba",
        HiringDate = new DateTime(2022, 9, 9)
    },

    new Employee
    {
        Email = "noor@example.com",
        Password = "123456",
        PrefixEn = "Ms.",
        FirstNameEn = "Noor",
        SecondNameEn = "Ahmad",
        ThirdNameEn = "Ali",
        LastNameEn = "Ali",
        FullNameEn = "Ms. Noor Ahmad Ali Ali",

        PrefixAr = "الآنسة",
        FirstNameAr = "نور",
        SecondNameAr = "أحمد",
        ThirdNameAr = "علي",
        LastNameAr = "علي",
        FullNameAr = "الآنسة نور أحمد علي علي",

        DateOfBirth = new DateTime(1996, 2, 14),
        Gender = GenderEnum.Female,
        MaritalStatus = MaritalStatusEnum.Single,
        Religion = "Islam",
        NationalNumber = "8888888888",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 850,
        PhoneNumber = "+962798888888",
        Location = "Jerash",
        HiringDate = new DateTime(2023, 6, 1)
    },

    new Employee
    {
        Email = "omar@example.com",
        Password = "123456",
        PrefixEn = "Mr.",
        FirstNameEn = "Omar",
        SecondNameEn = "Zaid",
        ThirdNameEn = "Ahmad",
        LastNameEn = "Zaid",
        FullNameEn = "Mr. Omar Zaid Ahmad Zaid",

        PrefixAr = "السيد",
        FirstNameAr = "عمر",
        SecondNameAr = "زيد",
        ThirdNameAr = "أحمد",
        LastNameAr = "زيد",
        FullNameAr = "السيد عمر زيد أحمد زيد",

        DateOfBirth = new DateTime(1989, 10, 22),
        Gender = GenderEnum.Male,
        MaritalStatus = MaritalStatusEnum.Married,
        Religion = "Islam",
        NationalNumber = "9999999999",
        CreationDate = DateTime.Now,
        IsCitizen = true,
        IsActive = true,
        BasicSalary = 1150,
        PhoneNumber = "+962799999999",
        Location = "Amman",
        HiringDate = new DateTime(2020, 11, 11)
    }
};

            foreach (var employee in employees)
            {
                var existing = employeeRepository.FindByEmail(employee.Email);
                if (existing == null)
                {
                    await employeeRepository.InsertAsync(employee);
                }
            }
        }
    }
}
