using MediatR;
using UserAPI.Data;

namespace UserAPI.DTOs
{
    public class GetUserDetail: IRequest<User>
    {
        public GetUserDetail(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
