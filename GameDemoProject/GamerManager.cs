using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GamerManager : IGamerManager
    {
        ICustomerValidationService _customerValidationService;
        

        public GamerManager(CustomerValidationService customerValidationService)
        {
            _customerValidationService = customerValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Save(Gamer gamer)
        {
            if (_customerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Validation failed");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
