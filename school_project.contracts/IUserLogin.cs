using school_project.dto;

namespace school_project.contracts
{
    interface IUserLogin
    {
        bool ValidateUser(LogiUserDTO user);

    }
}
