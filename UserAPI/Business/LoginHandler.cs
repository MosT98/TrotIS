using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrotIS.Shared;
using UserAPI.Data;
using UserAPI.DTOs;

namespace UserAPI.Business
{
    public class LoginHandler : IRequestHandler<Login, LoginObj>
    {
        private readonly Context context;
        public LoginHandler(Context context)
        {
            this.context = context;
        }
        private string sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = System.Security.Cryptography.SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public async Task<LoginObj> Handle(Login request, CancellationToken cancellationToken)
        {
            var actualUser = await context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
            if (actualUser != null)
                if (actualUser.Password == request.Password)
                {
                    LoginObj loginObj = new LoginObj(sha256_hash(actualUser.Email), actualUser.FirstName, actualUser.LastName);
                    return loginObj;
                }
            return null;
        }
    }
}
