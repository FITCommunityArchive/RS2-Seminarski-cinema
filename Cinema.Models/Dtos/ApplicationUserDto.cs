using System.Collections.Generic;

namespace Cinema.Models.Dtos
{
    public class ApplicationUserDto
    {

        public ApplicationUserDto()
        {
            UserRoles = new List<ApplicationUserRoleDto>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string PhoneNumber { get; set; }

        public IList<ApplicationUserRoleDto> UserRoles { get; set; }
    }
}
