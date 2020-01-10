using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.DTOs
{
    public class RegisterCheck : IRequest<string>
    {
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
