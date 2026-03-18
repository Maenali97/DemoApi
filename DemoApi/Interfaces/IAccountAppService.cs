namespace DemoApi
{
    public interface IAccountAppService
    {
        Task<LoginResponse> LoginAsync(LoginDto dto);
    }
}
