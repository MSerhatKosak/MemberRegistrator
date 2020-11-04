using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
   public class UserForLogin:IDto
    {
        public string Mail { get; set; }
        public string Password { get; set; }

    }
}
