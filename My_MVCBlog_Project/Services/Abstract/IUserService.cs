using My_MVCBlog_Project.Entitites;
using My_MVCBlog_Project.Models;

namespace My_MVCBlog_Project.Services.Abstract
{
    public interface IUserService
    {
        ServiceResponse<object> Register(RegisterViewModel model);

        ServiceResponse<User> Login(LoginViewModel model);

        ServiceResponse<User> Create(UserViewModel model,HttpContext httpContext);

        ServiceResponse<List<User>> List();
    }
}
