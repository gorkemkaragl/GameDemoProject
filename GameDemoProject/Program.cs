using System;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
			GamerManager gamerManager = new GamerManager(new CustomerValidationService());
			gamerManager.Save(new Gamer
			{
				Id = 1,
				FirstName = "Görkem",
				LastName = "Karagöl",
				Age = 18
			});

			CampaignManager campaignManager = new CampaignManager();
			Campaigns blackFriday = new Campaigns();
			blackFriday.Id = 1;
			blackFriday.CampaignName = "Black Friday";
			blackFriday.CampaignDescription = "Dünyanın en büyük kampanyası";
			campaignManager.Add(blackFriday);

		}
	}
}
