using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GameSellingManager
    {
        public void GameSale(Gamer gamer, Campaigns campaigns)
        {
            Console.WriteLine("Sayın "+gamer.FirstName +" Oyunu "+
                campaigns.CampaignName + " kampanyasında başarıyla satın aldınız!");
        }
    }
}
