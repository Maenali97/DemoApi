namespace DemoApi
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PrefixEn { get; set; }
        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string SuffixEn { get; set; }
        public string FullNameEn { get; set; }
        public string PrefixAr { get; set; }
        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }
        public GenderEnum Gender { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
