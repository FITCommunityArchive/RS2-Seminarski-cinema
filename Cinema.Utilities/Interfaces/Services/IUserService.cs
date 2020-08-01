using Cinema.Models;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces.Services;

namespace Cinema.Utilities.Interfaces
{
    public interface IUserService : ICRUDService<ApplicationUserDto,UserSearchRequest,UserUpsertRequest,UserUpsertRequest>
    {
        //ApplicationUser InsertCustom([FromBody] UserUpsertRequest model);
        //ApplicationUser Authenticate(string username, string password);
        //IEnumerable<ApplicationUser> GetAll();
        //ApplicationUser GetById(int id);
        //ApplicationUser Create(ApplicationUser user, string password);
        //void Update(ApplicationUser user, string password = null);
        //void Delete(int id);
    }
}
