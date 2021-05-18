using System;
using System.Collections.Generic;
using System.Text;

namespace CLL.Security.Identity
{
    public class Director
        : User
    {
        public Director(int user_id, string name, int department_id)
            : base(user_id, name, department_id, nameof(Director))
        {
        }

    }
}
