using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class CustomerValidationService : ICustomerValidationService
    {
        public bool Validate(Gamer gamer)
        {
			if (gamer.Id == 1 && gamer.FirstName == "Görkem"
				&& gamer.LastName == "Karagöl" && gamer.Age == 18)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}
