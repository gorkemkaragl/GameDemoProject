using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface ICustomerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
