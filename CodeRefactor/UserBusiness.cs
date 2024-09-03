using CodeRefactor;

public class UserBusiness
{
    private readonly UserData _userdata;

    public UserBusiness()
    {
        // Please make use of DI to inject the dependency.
        _userdata = new UserData();
    }
    public async Task<List<Users>?> FetchUsersAsync(string apiUrl)
    {
        return await _userdata.GetUsersAsync(apiUrl);
    }


}