using Domain;

namespace DemoApi
{
    public class Employee : Entity<Guid>
    {
        public  string Email { get; set; }
        public  string Password { get; set; }
        public  string PrefixEn { get; set; }
        public  string FirstNameEn { get; set; }
        public  string SecondNameEn { get; set; }
        public  string ThirdNameEn { get; set; }
        public  string LastNameEn { get; set; }
        public  string SuffixEn { get; set; }
        public  string FullNameEn { get; set; }
        public  string PrefixAr { get; set; }
        public  string FirstNameAr { get; set; }
        public  string SecondNameAr { get; set; }
        public  string ThirdNameAr { get; set; }
        public  string LastNameAr { get; set; }
        public  string SuffixAr { get; set; }
        public  string FullNameAr { get; set; }
        public  DateTime? DateOfBirth { get; set; }
        public  string ShortNameEn { get; set; }
        public  string ShortNameAr { get; set; }
        public  GenderEnum Gender { get; set; }
        public  MaritalStatusEnum MaritalStatus { get; set; }
        public  string Religion { get; set; }
        public  string NationalNumber { get; set; }
        public  DateTime CreationDate { get; set; }
        public  bool IsDeleted { get; set; }
        public  bool IsCitizen { get; set; }
        public  bool IsActive { get; set; }
        public  string Facebook { get; set; }
        public  string Instgram { get; set; }
        public  string Twitter { get; set; }
        public  string LinkedIn { get; set; }
        public  string GooglePlus { get; set; }
        public  string Skype { get; set; }
        public  decimal BasicSalary { get; set; }
        public  string ZIP { get; set; }
        public  string PhoneNumber { get; set; }
        public  string About { get; set; }
        public  string Bio { get; set; }
        public  string Location { get; set; }
        public  Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public  string CompanyName { get; set; }
        public  Guid ManegerID { get; set; }
        public  DateTime? HiringDate { get; set; }

        public Employee() { }    

        public Employee(
            Guid id, string email,
            string password, string firstNameEn,
            string secondNameEn, string thirdNameEn,
            string lastNameEn, string firstNameAr,
            string secondNameAr,string thirdNameAr,
            string lastNameAr, DateTime dateOfBirth,
            GenderEnum gender,MaritalStatusEnum maritalStatus,
            string nationalNumber,string phoneNumber
            )
        {
            Id = id;
            Email = email;
            Password = password;
            FirstNameEn = firstNameEn;
            SecondNameEn = secondNameEn;
            ThirdNameEn = thirdNameEn;
            LastNameEn = lastNameEn;
            FirstNameAr = firstNameAr;
            SecondNameAr = secondNameAr;
            ThirdNameAr = thirdNameAr;
            LastNameAr = lastNameAr;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            MaritalStatus = maritalStatus;
            NationalNumber = nationalNumber;
            PhoneNumber = phoneNumber;


        }
    }
}
