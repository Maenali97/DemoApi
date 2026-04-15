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
    Email = "hassan@example.com",
    Password = "123456",
    PrefixEn = "Mr.",
    FirstNameEn = "Hassan",
    SecondNameEn = "Mahmoud",
    ThirdNameEn = "Ali",
    LastNameEn = "Saleh",
    FullNameEn = "Mr. Hassan Mahmoud Ali Saleh",

    PrefixAr = "السيد",
    FirstNameAr = "حسن",
    SecondNameAr = "محمود",
    ThirdNameAr = "علي",
    LastNameAr = "صالح",
    FullNameAr = "السيد حسن محمود علي صالح",

    DateOfBirth = new DateTime(1990, 5, 5),
    Gender = GenderEnum.Male,
    MaritalStatus = MaritalStatusEnum.Married,
    Religion = "Islam",
    NationalNumber = "1010101010",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 950,
    PhoneNumber = "+962770000001",
    Location = "Amman",
    HiringDate = new DateTime(2021, 4, 10)
},

new Employee
{
    Email = "dana@example.com",
    Password = "123456",
    PrefixEn = "Ms.",
    FirstNameEn = "Dana",
    SecondNameEn = "Khaled",
    ThirdNameEn = "Ahmad",
    LastNameEn = "Naser",
    FullNameEn = "Ms. Dana Khaled Ahmad Naser",

    PrefixAr = "الآنسة",
    FirstNameAr = "دانا",
    SecondNameAr = "خالد",
    ThirdNameAr = "أحمد",
    LastNameAr = "ناصر",
    FullNameAr = "الآنسة دانا خالد أحمد ناصر",

    DateOfBirth = new DateTime(1997, 8, 12),
    Gender = GenderEnum.Female,
    MaritalStatus = MaritalStatusEnum.Single,
    Religion = "Islam",
    NationalNumber = "2020202020",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 780,
    PhoneNumber = "+962770000002",
    Location = "Irbid",
    HiringDate = new DateTime(2023, 3, 15)
},

new Employee
{
    Email = "fadi@example.com",
    Password = "123456",
    PrefixEn = "Mr.",
    FirstNameEn = "Fadi",
    SecondNameEn = "Samir",
    ThirdNameEn = "Hussein",
    LastNameEn = "Abbas",
    FullNameEn = "Mr. Fadi Samir Hussein Abbas",

    PrefixAr = "السيد",
    FirstNameAr = "فادي",
    SecondNameAr = "سمير",
    ThirdNameAr = "حسين",
    LastNameAr = "عباس",
    FullNameAr = "السيد فادي سمير حسين عباس",

    DateOfBirth = new DateTime(1986, 1, 25),
    Gender = GenderEnum.Male,
    MaritalStatus = MaritalStatusEnum.Married,
    Religion = "Islam",
    NationalNumber = "3030303030",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 1200,
    PhoneNumber = "+962770000003",
    Location = "Zarqa",
    HiringDate = new DateTime(2018, 7, 7)
},

new Employee
{
    Email = "reem@example.com",
    Password = "123456",
    PrefixEn = "Ms.",
    FirstNameEn = "Reem",
    SecondNameEn = "Yousef",
    ThirdNameEn = "Ali",
    LastNameEn = "Hamdan",
    FullNameEn = "Ms. Reem Yousef Ali Hamdan",

    PrefixAr = "الآنسة",
    FirstNameAr = "ريم",
    SecondNameAr = "يوسف",
    ThirdNameAr = "علي",
    LastNameAr = "حمدان",
    FullNameAr = "الآنسة ريم يوسف علي حمدان",

    DateOfBirth = new DateTime(1994, 6, 9),
    Gender = GenderEnum.Female,
    MaritalStatus = MaritalStatusEnum.Single,
    Religion = "Islam",
    NationalNumber = "4040404040",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 820,
    PhoneNumber = "+962770000004",
    Location = "Salt",
    HiringDate = new DateTime(2022, 10, 1)
},

new Employee
{
    Email = "bassam@example.com",
    Password = "123456",
    PrefixEn = "Mr.",
    FirstNameEn = "Bassam",
    SecondNameEn = "Omar",
    ThirdNameEn = "Saleh",
    LastNameEn = "Khatib",
    FullNameEn = "Mr. Bassam Omar Saleh Khatib",

    PrefixAr = "السيد",
    FirstNameAr = "بسام",
    SecondNameAr = "عمر",
    ThirdNameAr = "صالح",
    LastNameAr = "خطيب",
    FullNameAr = "السيد بسام عمر صالح خطيب",

    DateOfBirth = new DateTime(1983, 3, 3),
    Gender = GenderEnum.Male,
    MaritalStatus = MaritalStatusEnum.Married,
    Religion = "Islam",
    NationalNumber = "5050505050",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 1300,
    PhoneNumber = "+962770000005",
    Location = "Aqaba",
    HiringDate = new DateTime(2017, 5, 5)
},

new Employee
{
    Email = "lama@example.com",
    Password = "123456",
    PrefixEn = "Ms.",
    FirstNameEn = "Lama",
    SecondNameEn = "Ahmad",
    ThirdNameEn = "Salem",
    LastNameEn = "Fares",
    FullNameEn = "Ms. Lama Ahmad Salem Fares",

    PrefixAr = "الآنسة",
    FirstNameAr = "لمى",
    SecondNameAr = "أحمد",
    ThirdNameAr = "سالم",
    LastNameAr = "فارس",
    FullNameAr = "الآنسة لمى أحمد سالم فارس",

    DateOfBirth = new DateTime(1999, 11, 11),
    Gender = GenderEnum.Female,
    MaritalStatus = MaritalStatusEnum.Single,
    Religion = "Islam",
    NationalNumber = "6060606060",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 720,
    PhoneNumber = "+962770000006",
    Location = "Madaba",
    HiringDate = new DateTime(2024, 2, 1)
},

new Employee
{
    Email = "tariq@example.com",
    Password = "123456",
    PrefixEn = "Mr.",
    FirstNameEn = "Tariq",
    SecondNameEn = "Hassan",
    ThirdNameEn = "Maher",
    LastNameEn = "Zein",
    FullNameEn = "Mr. Tariq Hassan Maher Zein",

    PrefixAr = "السيد",
    FirstNameAr = "طارق",
    SecondNameAr = "حسن",
    ThirdNameAr = "ماهر",
    LastNameAr = "زين",
    FullNameAr = "السيد طارق حسن ماهر زين",

    DateOfBirth = new DateTime(1984, 2, 17),
    Gender = GenderEnum.Male,
    MaritalStatus = MaritalStatusEnum.Married,
    Religion = "Islam",
    NationalNumber = "7070707070",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 1150,
    PhoneNumber = "+962770000007",
    Location = "Jerash",
    HiringDate = new DateTime(2019, 9, 9)
},

new Employee
{
    Email = "aya@example.com",
    Password = "123456",
    PrefixEn = "Ms.",
    FirstNameEn = "Aya",
    SecondNameEn = "Ali",
    ThirdNameEn = "Khaled",
    LastNameEn = "Rashid",
    FullNameEn = "Ms. Aya Ali Khaled Rashid",

    PrefixAr = "الآنسة",
    FirstNameAr = "آية",
    SecondNameAr = "علي",
    ThirdNameAr = "خالد",
    LastNameAr = "رشيد",
    FullNameAr = "الآنسة آية علي خالد رشيد",

    DateOfBirth = new DateTime(1993, 7, 7),
    Gender = GenderEnum.Female,
    MaritalStatus = MaritalStatusEnum.Married,
    Religion = "Islam",
    NationalNumber = "8080808080",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 900,
    PhoneNumber = "+962770000008",
    Location = "Amman",
    HiringDate = new DateTime(2020, 12, 12)
},

new Employee
{
    Email = "zayd@example.com",
    Password = "123456",
    PrefixEn = "Mr.",
    FirstNameEn = "Zayd",
    SecondNameEn = "Faisal",
    ThirdNameEn = "Ahmad",
    LastNameEn = "Qasem",
    FullNameEn = "Mr. Zayd Faisal Ahmad Qasem",

    PrefixAr = "السيد",
    FirstNameAr = "زيد",
    SecondNameAr = "فيصل",
    ThirdNameAr = "أحمد",
    LastNameAr = "قاسم",
    FullNameAr = "السيد زيد فيصل أحمد قاسم",

    DateOfBirth = new DateTime(1991, 1, 1),
    Gender = GenderEnum.Male,
    MaritalStatus = MaritalStatusEnum.Single,
    Religion = "Islam",
    NationalNumber = "9090909090",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 870,
    PhoneNumber = "+962770000009",
    Location = "Irbid",
    HiringDate = new DateTime(2023, 5, 5)
},

new Employee
{
    Email = "salma@example.com",
    Password = "123456",
    PrefixEn = "Ms.",
    FirstNameEn = "Salma",
    SecondNameEn = "Omar",
    ThirdNameEn = "Hussein",
    LastNameEn = "Najjar",
    FullNameEn = "Ms. Salma Omar Hussein Najjar",

    PrefixAr = "الآنسة",
    FirstNameAr = "سلمى",
    SecondNameAr = "عمر",
    ThirdNameAr = "حسين",
    LastNameAr = "نجار",
    FullNameAr = "الآنسة سلمى عمر حسين نجار",

    DateOfBirth = new DateTime(1996, 4, 4),
    Gender = GenderEnum.Female,
    MaritalStatus = MaritalStatusEnum.Single,
    Religion = "Islam",
    NationalNumber = "1112223334",
    CreationDate = DateTime.Now,
    IsCitizen = true,
    IsActive = true,
    BasicSalary = 830,
    PhoneNumber = "+962770000010",
    Location = "Zarqa",
    HiringDate = new DateTime(2022, 6, 6)
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
